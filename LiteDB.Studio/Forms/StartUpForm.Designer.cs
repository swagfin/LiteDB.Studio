namespace LiteDB.Studio.Forms
{
    partial class StartUpForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartUpForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.RecentOpenedDbGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.SystemVersionLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.RecentFilesStatusLabel = new System.Windows.Forms.Label();
            this.RecentConnectionsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeFromRecentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.OpenDbButton = new System.Windows.Forms.Button();
            this.NewDbButton = new System.Windows.Forms.Button();
            this.ColumnImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnRecentProjectTemplates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilePathColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RecentOpenedDbGrid)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.RecentConnectionsContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lite DB Studio";
            // 
            // RecentOpenedDbGrid
            // 
            this.RecentOpenedDbGrid.AllowUserToAddRows = false;
            this.RecentOpenedDbGrid.AllowUserToDeleteRows = false;
            this.RecentOpenedDbGrid.AllowUserToResizeColumns = false;
            this.RecentOpenedDbGrid.AllowUserToResizeRows = false;
            this.RecentOpenedDbGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.RecentOpenedDbGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RecentOpenedDbGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.RecentOpenedDbGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecentOpenedDbGrid.ColumnHeadersVisible = false;
            this.RecentOpenedDbGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnImage,
            this.ColumnRecentProjectTemplates,
            this.FilePathColumn});
            this.RecentOpenedDbGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.RecentOpenedDbGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.RecentOpenedDbGrid.Location = new System.Drawing.Point(17, 116);
            this.RecentOpenedDbGrid.Margin = new System.Windows.Forms.Padding(100, 3, 3, 3);
            this.RecentOpenedDbGrid.MultiSelect = false;
            this.RecentOpenedDbGrid.Name = "RecentOpenedDbGrid";
            this.RecentOpenedDbGrid.ReadOnly = true;
            this.RecentOpenedDbGrid.RowHeadersVisible = false;
            this.RecentOpenedDbGrid.RowTemplate.Height = 41;
            this.RecentOpenedDbGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RecentOpenedDbGrid.ShowEditingIcon = false;
            this.RecentOpenedDbGrid.Size = new System.Drawing.Size(348, 364);
            this.RecentOpenedDbGrid.TabIndex = 1;
            this.RecentOpenedDbGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RecentOpenedDbGrid_CellContentClick);
            this.RecentOpenedDbGrid.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.RecentOpenedDbGrid_CellContextMenuStripNeeded);
            this.RecentOpenedDbGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.RecentOpenedDbGrid_DataBindingComplete);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recent opened Databases";
            // 
            // SystemVersionLabel
            // 
            this.SystemVersionLabel.AutoSize = true;
            this.SystemVersionLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystemVersionLabel.ForeColor = System.Drawing.Color.DimGray;
            this.SystemVersionLabel.Location = new System.Drawing.Point(729, 488);
            this.SystemVersionLabel.Name = "SystemVersionLabel";
            this.SystemVersionLabel.Size = new System.Drawing.Size(39, 14);
            this.SystemVersionLabel.TabIndex = 1;
            this.SystemVersionLabel.Text = "v1.204";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.label4.Location = new System.Drawing.Point(392, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quick Actions";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.flowLayoutPanel1.Controls.Add(this.OpenDbButton);
            this.flowLayoutPanel1.Controls.Add(this.NewDbButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(397, 116);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(372, 364);
            this.flowLayoutPanel1.TabIndex = 5;
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
            this.CloseBtn.Location = new System.Drawing.Point(743, 12);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(26, 23);
            this.CloseBtn.TabIndex = 6;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // RecentFilesStatusLabel
            // 
            this.RecentFilesStatusLabel.AutoSize = true;
            this.RecentFilesStatusLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecentFilesStatusLabel.ForeColor = System.Drawing.Color.SeaShell;
            this.RecentFilesStatusLabel.Location = new System.Drawing.Point(85, 126);
            this.RecentFilesStatusLabel.Name = "RecentFilesStatusLabel";
            this.RecentFilesStatusLabel.Size = new System.Drawing.Size(128, 15);
            this.RecentFilesStatusLabel.TabIndex = 7;
            this.RecentFilesStatusLabel.Text = "No recent connections";
            // 
            // RecentConnectionsContextMenu
            // 
            this.RecentConnectionsContextMenu.BackColor = System.Drawing.SystemColors.HighlightText;
            this.RecentConnectionsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeFromRecentsToolStripMenuItem});
            this.RecentConnectionsContextMenu.Name = "RecentConnectionsContextMenu";
            this.RecentConnectionsContextMenu.Size = new System.Drawing.Size(191, 26);
            // 
            // removeFromRecentsToolStripMenuItem
            // 
            this.removeFromRecentsToolStripMenuItem.Name = "removeFromRecentsToolStripMenuItem";
            this.removeFromRecentsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.removeFromRecentsToolStripMenuItem.Text = "Remove from Recents";
            this.removeFromRecentsToolStripMenuItem.Click += new System.EventHandler(this.removeFromRecentsToolStripMenuItem_Click);
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 14.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewImageColumn1.HeaderText = "ImageColumn";
            this.dataGridViewImageColumn1.Image = global::LiteDB.Studio.Properties.Resources.database;
            this.dataGridViewImageColumn1.MinimumWidth = 25;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 25;
            // 
            // OpenDbButton
            // 
            this.OpenDbButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OpenDbButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.OpenDbButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(228)))));
            this.OpenDbButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(230)))), ((int)(((byte)(243)))));
            this.OpenDbButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenDbButton.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenDbButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.OpenDbButton.Image = global::LiteDB.Studio.Properties.Resources.iconpack_database;
            this.OpenDbButton.Location = new System.Drawing.Point(10, 10);
            this.OpenDbButton.Margin = new System.Windows.Forms.Padding(10);
            this.OpenDbButton.Name = "OpenDbButton";
            this.OpenDbButton.Padding = new System.Windows.Forms.Padding(5);
            this.OpenDbButton.Size = new System.Drawing.Size(165, 85);
            this.OpenDbButton.TabIndex = 2;
            this.OpenDbButton.Tag = "#F3ECEC";
            this.OpenDbButton.Text = "Open Database";
            this.OpenDbButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OpenDbButton.UseVisualStyleBackColor = false;
            this.OpenDbButton.Click += new System.EventHandler(this.OpenDbButton_Click);
            // 
            // NewDbButton
            // 
            this.NewDbButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NewDbButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.NewDbButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(228)))));
            this.NewDbButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(230)))), ((int)(((byte)(243)))));
            this.NewDbButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewDbButton.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewDbButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.NewDbButton.Image = global::LiteDB.Studio.Properties.Resources.iconpack_database_admin;
            this.NewDbButton.Location = new System.Drawing.Point(195, 10);
            this.NewDbButton.Margin = new System.Windows.Forms.Padding(10);
            this.NewDbButton.Name = "NewDbButton";
            this.NewDbButton.Padding = new System.Windows.Forms.Padding(5);
            this.NewDbButton.Size = new System.Drawing.Size(165, 85);
            this.NewDbButton.TabIndex = 3;
            this.NewDbButton.Tag = "#F3ECEC";
            this.NewDbButton.Text = "New Database";
            this.NewDbButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NewDbButton.UseVisualStyleBackColor = false;
            // 
            // ColumnImage
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 14.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(230)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.ColumnImage.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnImage.HeaderText = "ImageColumn";
            this.ColumnImage.Image = global::LiteDB.Studio.Properties.Resources.database;
            this.ColumnImage.MinimumWidth = 23;
            this.ColumnImage.Name = "ColumnImage";
            this.ColumnImage.ReadOnly = true;
            this.ColumnImage.Width = 23;
            // 
            // ColumnRecentProjectTemplates
            // 
            this.ColumnRecentProjectTemplates.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnRecentProjectTemplates.DataPropertyName = "Title";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(230)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.ColumnRecentProjectTemplates.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnRecentProjectTemplates.HeaderText = "Recent Project Templates";
            this.ColumnRecentProjectTemplates.Name = "ColumnRecentProjectTemplates";
            this.ColumnRecentProjectTemplates.ReadOnly = true;
            this.ColumnRecentProjectTemplates.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FilePathColumn
            // 
            this.FilePathColumn.DataPropertyName = "FilePath";
            this.FilePathColumn.HeaderText = "FilePath";
            this.FilePathColumn.Name = "FilePathColumn";
            this.FilePathColumn.ReadOnly = true;
            this.FilePathColumn.Visible = false;
            // 
            // StartUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(781, 506);
            this.Controls.Add(this.RecentOpenedDbGrid);
            this.Controls.Add(this.RecentFilesStatusLabel);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SystemVersionLabel);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartUpForm";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartUpForm";
            this.Load += new System.EventHandler(this.StartUpForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartUpForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.RecentOpenedDbGrid)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.RecentConnectionsContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView RecentOpenedDbGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OpenDbButton;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label SystemVersionLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button NewDbButton;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label RecentFilesStatusLabel;
        private System.Windows.Forms.ContextMenuStrip RecentConnectionsContextMenu;
        private System.Windows.Forms.ToolStripMenuItem removeFromRecentsToolStripMenuItem;
        private System.Windows.Forms.DataGridViewImageColumn ColumnImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRecentProjectTemplates;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilePathColumn;
    }
}