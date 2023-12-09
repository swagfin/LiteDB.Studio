using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LiteDB.Studio.Forms
{
    public partial class StartUpForm : Form
    {
        public StartUpForm(string[] args)
        {
            InitializeComponent();
            SystemVersionLabel.Text = Program.AppVersion;
            RecentOpenedDbGrid.DataSource = new List<RecentOpenedDbFiles>
            {
                new RecentOpenedDbFiles("testDb.db::C:\\local\\litedbs\\withAuth..."),
                new RecentOpenedDbFiles("cache.db::.C:\\users\\access\\litedb..."),
                new RecentOpenedDbFiles("customers.db::.C:\\data\\repository\\s...")
            };
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
                MainForm mainFormRequest = new MainForm(connectionString);
                mainFormRequest.ShowDialog();
                this.Show();
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
                        bool positiveFeedback = requestDbPasswordForm.ShowDialog() == DialogResult.OK;
                        if (positiveFeedback)
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
    }

    public class RecentOpenedDbFiles
    {
        public RecentOpenedDbFiles(string title)
        {
            Title = title;
        }
        public string Title { get; set; }
    }
}
