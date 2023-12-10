using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LiteDB.Studio.Forms
{
    public partial class StartUpForm : Form
    {
        private string RecentSaveFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RecentConnections.temp");
        public List<string> RecentConnections { get; private set; } = new List<string>();

        public StartUpForm(string[] args)
        {
            InitializeComponent();
            SystemVersionLabel.Text = Program.AppVersion;
        }
        private void StartUpForm_Load(object sender, EventArgs e)
        {
            RefreshRecentFiles();
        }

        private void RefreshRecentFiles()
        {
            try
            {
                if (!File.Exists(RecentSaveFile))
                {
                    RecentOpenedDbGrid.Visible = false;
                    return;
                }
                //set datasource reversed
                this.RecentConnections = File.ReadAllLines(RecentSaveFile, Encoding.UTF8).Select(x => x.Trim()).Distinct().Take(10).Reverse().ToList();
                RecentOpenedDbGrid.DataSource = this.RecentConnections.Select(x => new RecentOpenedDbFile(x)).ToList() ?? new List<RecentOpenedDbFile>();
                RecentOpenedDbGrid.Visible = (RecentOpenedDbGrid.RowCount > 0);
            }
            catch { }
        }
        private void AddToRecentFiles(string connectionFileName)
        {
            try
            {
                if (this.RecentConnections.Contains(connectionFileName.Trim()))
                    this.RecentConnections.Remove(connectionFileName.Trim());
                this.RecentConnections.Add(connectionFileName.Trim());
                File.WriteAllLines(RecentSaveFile, this.RecentConnections, Encoding.UTF8);
            }
            catch { }
        }

        private void StartUpForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DragUIHelper.ReleaseCapture();
                DragUIHelper.SendMessage(Handle, DragUIHelper.WM_NCLBUTTONDOWN, DragUIHelper.HT_CAPTION, 0);
            }
        }

        private void CloseBtn_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void OpenDbButton_Click(object sender, System.EventArgs e)
        {
            OpenDbButton.Enabled = false;
            ConnectionString connectionString = TriggerAttemptOpenDatabase();
            if (connectionString != null)
            {
                //save last connection
                AddToRecentFiles(connectionString.Filename);
                MainForm mainFormRequest = new MainForm(connectionString);
                mainFormRequest.ShowDialog();
                this.Show();
                //refresh  recent files
                RefreshRecentFiles();
            }
            OpenDbButton.Enabled = true;
        }

        private ConnectionString TriggerAttemptOpenDatabase(string dbFilePath = null, string password = null, bool passwordTriggered = false)
        {
            try
            {
                //** check if db file path provided
                if (string.IsNullOrEmpty(dbFilePath))
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        // Set the filter for file extensions
                        openFileDialog.Filter = "LiteDb Files (*.litedb, *.db)|*.litedb;*.db|All Files (*.*)|*.*";
                        openFileDialog.FilterIndex = 1;
                        openFileDialog.Multiselect = false;
                        // Display the OpenFileDialog
                        if (openFileDialog.ShowDialog() != DialogResult.OK)
                            return null;
                        // Get the selected file name and check if it exists
                        dbFilePath = openFileDialog.FileName;
                    }
                }
                //check if file exists
                if (!System.IO.File.Exists(dbFilePath))
                    throw new Exception($"The specified db file no longer exist, path: {dbFilePath}");
                //proceed to Open Db in Shared Connection
                this.Hide();
                ConnectionString dbConnectionString = new ConnectionString
                {
                    Connection = ConnectionType.Shared,
                    Filename = dbFilePath,
                    Password = password
                };
                try
                {
                    using (LiteDatabase liteDatabase = new LiteDatabase(dbConnectionString))
                    {
                        _ = liteDatabase.UserVersion; //force open
                    };
                }
                catch (LiteException ex)
                {
                    if (ex.Message.Contains("encrypted") || passwordTriggered)
                    {
                        RequestDbPasswordForm requestDbPasswordForm = new RequestDbPasswordForm(ex.Message);
                        if (requestDbPasswordForm.ShowDialog() != DialogResult.OK)
                        {
                            this.Show();
                            return null;
                        }
                        return TriggerAttemptOpenDatabase(dbFilePath, requestDbPasswordForm.DbPassword, true);
                    }
                    else
                        Program.HandleError(ex);
                    //show Window
                    this.Show();
                }
                //if no exception
                return dbConnectionString;
            }
            catch (Exception ex)
            {
                Program.HandleError(ex);
                return null;
            }
        }

        private void RecentOpenedDbGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (RecentOpenedDbGrid.SelectedRows.Count == 0)
                    return;
                DataGridViewRow selectedRow = RecentOpenedDbGrid.SelectedRows[0];
                RecentOpenedDbFile recentOpenedDbFile = (RecentOpenedDbFile)selectedRow.DataBoundItem;
                if (recentOpenedDbFile == null)
                    return;
                //attempt open Db
                ConnectionString connectionString = TriggerAttemptOpenDatabase(recentOpenedDbFile.FilePath);
                if (connectionString != null)
                {
                    //save last connection
                    AddToRecentFiles(connectionString.Filename);
                    MainForm mainFormRequest = new MainForm(connectionString);
                    mainFormRequest.ShowDialog();
                    this.Show();
                    //refresh  recent files
                    RefreshRecentFiles();
                }
            }
            catch (Exception ex) { Program.HandleError(ex); }
        }

        private void RecentOpenedDbGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            RecentOpenedDbGrid.ClearSelection();
        }

        private void RecentOpenedDbGrid_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                RecentOpenedDbGrid.CurrentCell = RecentOpenedDbGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                e.ContextMenuStrip = RecentConnectionsContextMenu;
            }
        }

        private void removeFromRecentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (RecentOpenedDbGrid.SelectedRows.Count == 0)
                    return;
                DataGridViewRow selectedRow = RecentOpenedDbGrid.SelectedRows[0];
                RecentOpenedDbFile recentOpenedDbFile = (RecentOpenedDbFile)selectedRow.DataBoundItem;
                if (recentOpenedDbFile == null)
                    return;
                if (this.RecentConnections.Contains(recentOpenedDbFile.FilePath.Trim()))
                    this.RecentConnections.Remove(recentOpenedDbFile.FilePath.Trim());
                File.WriteAllLines(RecentSaveFile, this.RecentConnections, Encoding.UTF8);
                RefreshRecentFiles();
            }
            catch (Exception ex) { Program.HandleError(ex); }
        }
    }

    public class RecentOpenedDbFile
    {
        public RecentOpenedDbFile(string filePath)
        {
            FilePath = filePath;
        }
        public string FilePath { get; set; }
        public string Title { get { return FilePath.FormatFilePath(41); } }
    }
}
