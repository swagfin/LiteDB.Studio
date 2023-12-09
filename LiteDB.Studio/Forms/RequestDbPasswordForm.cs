using System;
using System.Windows.Forms;

namespace LiteDB.Studio.Forms
{
    public partial class RequestDbPasswordForm : Form
    {
        public string DbPassword { get; private set; } = string.Empty;
        public RequestDbPasswordForm(string errorMessage = null)
        {
            InitializeComponent();
            this.ErrorMessageBox.Text = (!string.IsNullOrEmpty(errorMessage)) ? errorMessage : "Password is required!";
        }

        private void RequestDbPasswordForm_Load(object sender, EventArgs e)
        {
            DbPasswordBox.Focus();
            DbPasswordBox.Select();
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DbPasswordBox.Text))
            {
                DbPasswordBox.Focus();
                DbPasswordBox.Select();
            }
            else
            {
                this.DbPassword = DbPasswordBox.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void RequestDbPasswordForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DragUIHelper.ReleaseCapture();
                DragUIHelper.SendMessage(Handle, DragUIHelper.WM_NCLBUTTONDOWN, DragUIHelper.HT_CAPTION, 0);
            }
        }
    }
}
