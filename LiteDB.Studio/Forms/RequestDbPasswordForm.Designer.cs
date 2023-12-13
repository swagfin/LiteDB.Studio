namespace LiteDB.Studio.Forms
{
    partial class RequestDbPasswordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DbPasswordBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.ErrorMessageBox = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.label2.Location = new System.Drawing.Point(39, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Encrypted Database";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.label1.Location = new System.Drawing.Point(15, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Password";
            // 
            // DbPasswordBox
            // 
            this.DbPasswordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.DbPasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DbPasswordBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DbPasswordBox.ForeColor = System.Drawing.Color.Black;
            this.DbPasswordBox.Location = new System.Drawing.Point(19, 131);
            this.DbPasswordBox.Name = "DbPasswordBox";
            this.DbPasswordBox.Size = new System.Drawing.Size(409, 27);
            this.DbPasswordBox.TabIndex = 0;
            this.DbPasswordBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.label3.Location = new System.Drawing.Point(14, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 39);
            this.label3.TabIndex = 9;
            this.label3.Text = "Some LiteDB databases may be encypted for security purposes.";
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ConnectBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.ConnectBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(228)))));
            this.ConnectBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(230)))), ((int)(((byte)(243)))));
            this.ConnectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectBtn.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.ConnectBtn.Location = new System.Drawing.Point(331, 174);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(97, 34);
            this.ConnectBtn.TabIndex = 1;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = false;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // ErrorMessageBox
            // 
            this.ErrorMessageBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMessageBox.ForeColor = System.Drawing.Color.Crimson;
            this.ErrorMessageBox.Location = new System.Drawing.Point(17, 164);
            this.ErrorMessageBox.Name = "ErrorMessageBox";
            this.ErrorMessageBox.Size = new System.Drawing.Size(308, 53);
            this.ErrorMessageBox.TabIndex = 11;
            this.ErrorMessageBox.Text = "Password is required!";
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CloseBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.CloseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(228)))));
            this.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(230)))), ((int)(((byte)(243)))));
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.CloseBtn.Location = new System.Drawing.Point(432, 11);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(26, 23);
            this.CloseBtn.TabIndex = 12;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LiteDB.Studio.Properties.Resources.iconpack_lock;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // RequestDbPasswordForm
            // 
            this.AcceptButton = this.ConnectBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(470, 231);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.ErrorMessageBox);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DbPasswordBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RequestDbPasswordForm";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RequestDbPasswordForm";
            this.Load += new System.EventHandler(this.RequestDbPasswordForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RequestDbPasswordForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DbPasswordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Label ErrorMessageBox;
        private System.Windows.Forms.Button CloseBtn;
    }
}