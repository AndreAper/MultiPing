namespace MultiPing
{
    partial class frmMain
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanelTopMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.SourceAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnedAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buffer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Roundtrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelSelectedFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLines = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelChecked = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnPerformPing = new System.Windows.Forms.Button();
            this.btnExportToFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanelTopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanelTopMenu);
            this.splitContainer1.Panel1MinSize = 36;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView);
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip);
            this.splitContainer1.Size = new System.Drawing.Size(995, 600);
            this.splitContainer1.SplitterDistance = 36;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 2;
            // 
            // flowLayoutPanelTopMenu
            // 
            this.flowLayoutPanelTopMenu.Controls.Add(this.btnSelectFile);
            this.flowLayoutPanelTopMenu.Controls.Add(this.btnPerformPing);
            this.flowLayoutPanelTopMenu.Controls.Add(this.btnExportToFile);
            this.flowLayoutPanelTopMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelTopMenu.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelTopMenu.Name = "flowLayoutPanelTopMenu";
            this.flowLayoutPanelTopMenu.Size = new System.Drawing.Size(995, 36);
            this.flowLayoutPanelTopMenu.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SourceAddress,
            this.ReturnedAddress,
            this.Buffer,
            this.Roundtrip,
            this.Status});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(995, 541);
            this.dataGridView.TabIndex = 0;
            // 
            // SourceAddress
            // 
            this.SourceAddress.HeaderText = "Source Address";
            this.SourceAddress.Name = "SourceAddress";
            this.SourceAddress.ReadOnly = true;
            // 
            // ReturnedAddress
            // 
            this.ReturnedAddress.HeaderText = "Returned Adress";
            this.ReturnedAddress.Name = "ReturnedAddress";
            this.ReturnedAddress.ReadOnly = true;
            // 
            // Buffer
            // 
            this.Buffer.HeaderText = "Buffer";
            this.Buffer.Name = "Buffer";
            this.Buffer.ReadOnly = true;
            // 
            // Roundtrip
            // 
            this.Roundtrip.HeaderText = "Roundtrip";
            this.Roundtrip.Name = "Roundtrip";
            this.Roundtrip.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelSelectedFile,
            this.toolStripStatusLabelLines,
            this.toolStripStatusLabelChecked,
            this.toolStripProgressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 541);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(995, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelSelectedFile
            // 
            this.toolStripStatusLabelSelectedFile.AutoSize = false;
            this.toolStripStatusLabelSelectedFile.Name = "toolStripStatusLabelSelectedFile";
            this.toolStripStatusLabelSelectedFile.Size = new System.Drawing.Size(628, 17);
            this.toolStripStatusLabelSelectedFile.Spring = true;
            this.toolStripStatusLabelSelectedFile.Text = "Selected File:";
            this.toolStripStatusLabelSelectedFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabelLines
            // 
            this.toolStripStatusLabelLines.AutoSize = false;
            this.toolStripStatusLabelLines.Name = "toolStripStatusLabelLines";
            this.toolStripStatusLabelLines.Size = new System.Drawing.Size(100, 17);
            this.toolStripStatusLabelLines.Text = "Lines:";
            this.toolStripStatusLabelLines.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabelChecked
            // 
            this.toolStripStatusLabelChecked.AutoSize = false;
            this.toolStripStatusLabelChecked.Name = "toolStripStatusLabelChecked";
            this.toolStripStatusLabelChecked.Size = new System.Drawing.Size(100, 17);
            this.toolStripStatusLabelChecked.Text = "Checked:";
            this.toolStripStatusLabelChecked.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(150, 16);
            this.toolStripProgressBar.Step = 1;
            this.toolStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSelectFile.FlatAppearance.BorderSize = 0;
            this.btnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFile.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSelectFile.Image = global::MultiPing.Properties.Resources.folder_Open_16xLG;
            this.btnSelectFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectFile.Location = new System.Drawing.Point(3, 3);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(100, 30);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "Open File";
            this.btnSelectFile.UseVisualStyleBackColor = false;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnPerformPing
            // 
            this.btnPerformPing.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPerformPing.FlatAppearance.BorderSize = 0;
            this.btnPerformPing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerformPing.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPerformPing.Image = global::MultiPing.Properties.Resources.StatusAnnotations_Play_16xLG_color;
            this.btnPerformPing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerformPing.Location = new System.Drawing.Point(109, 3);
            this.btnPerformPing.Name = "btnPerformPing";
            this.btnPerformPing.Size = new System.Drawing.Size(100, 30);
            this.btnPerformPing.TabIndex = 0;
            this.btnPerformPing.Text = "Start Ping";
            this.btnPerformPing.UseVisualStyleBackColor = false;
            this.btnPerformPing.Visible = false;
            this.btnPerformPing.Click += new System.EventHandler(this.btnPerformPing_Click);
            // 
            // btnExportToFile
            // 
            this.btnExportToFile.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnExportToFile.FlatAppearance.BorderSize = 0;
            this.btnExportToFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportToFile.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExportToFile.Image = global::MultiPing.Properties.Resources.save_16xLG;
            this.btnExportToFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportToFile.Location = new System.Drawing.Point(215, 3);
            this.btnExportToFile.Name = "btnExportToFile";
            this.btnExportToFile.Size = new System.Drawing.Size(100, 30);
            this.btnExportToFile.TabIndex = 0;
            this.btnExportToFile.Text = "Save File";
            this.btnExportToFile.UseVisualStyleBackColor = false;
            this.btnExportToFile.Visible = false;
            this.btnExportToFile.Click += new System.EventHandler(this.btnExportToFile_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 600);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMain";
            this.Text = "MultiPing";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanelTopMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTopMenu;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SourceAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnedAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buffer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Roundtrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button btnPerformPing;
        private System.Windows.Forms.Button btnExportToFile;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSelectedFile;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLines;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelChecked;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
    }
}

