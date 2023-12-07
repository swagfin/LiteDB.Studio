using System.Collections.Generic;
using System.Windows.Forms;

namespace LiteDB.Studio.Forms
{
    public partial class StartUpForm : Form
    {
        public StartUpForm()
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
