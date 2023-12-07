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
                new RecentOpenedDbFiles("ASP.NET Core Web App (Razor Pages)"),
                new RecentOpenedDbFiles(".NET MAUI Blazor Hybrid App"),
                new RecentOpenedDbFiles("Windows Forms App (.NET Framework)")
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
