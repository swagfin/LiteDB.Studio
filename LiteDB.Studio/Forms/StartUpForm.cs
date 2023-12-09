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
            TriggerOpenDatabase();
            OpenDbButton.Enabled = true;
        }

        private void TriggerOpenDatabase(string dbFilePath = null, string password = null, bool passwordTriggered = false)
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
                            return;
                        // Get the selected file name and check if it exists
                        dbFilePath = openFileDialog.FileName;
                    }
                }
                //check if file exists
                if (!System.IO.File.Exists(dbFilePath))
                    throw new Exception($"The specified db file no longer exist, path: {dbFilePath}");
                //proceed to Open Db in Shared Connection
                try
                {
                    LiteDatabase liteDatabase = new LiteDatabase(new ConnectionString()
                    {
                        Connection = ConnectionType.Shared,
                        Filename = dbFilePath,
                        Password = password
                    });
                    _ = liteDatabase.UserVersion; //force open
                }
                catch (LiteException ex)
                {
                    if (ex.Message.Contains("encrypted") || passwordTriggered)
                    {
                        this.Hide();
                        RequestDbPasswordForm requestDbPasswordForm = new RequestDbPasswordForm(ex.Message);
                        bool positiveFeedback = requestDbPasswordForm.ShowDialog() == DialogResult.OK;
                        this.Show();
                        if (positiveFeedback)
                            TriggerOpenDatabase(dbFilePath, requestDbPasswordForm.DbPassword, true);
                    }
                    else
                        Program.HandleError(ex);
                }
            }
            catch (Exception ex)
            {
                Program.HandleError(ex);
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
