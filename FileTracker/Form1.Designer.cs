namespace FileTracker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.niFileTracker = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsFileTracker = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbFiles = new System.Windows.Forms.ListBox();
            this.cmsFileTracker.SuspendLayout();
            this.SuspendLayout();
            // 
            // niFileTracker
            // 
            this.niFileTracker.ContextMenuStrip = this.cmsFileTracker;
            this.niFileTracker.Icon = ((System.Drawing.Icon)(resources.GetObject("niFileTracker.Icon")));
            this.niFileTracker.Text = "File Tracker";
            this.niFileTracker.Visible = true;
            // 
            // cmsFileTracker
            // 
            this.cmsFileTracker.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureToolStripMenuItem,
            this.closToolStripMenuItem});
            this.cmsFileTracker.Name = "cmsFileTracker";
            this.cmsFileTracker.Size = new System.Drawing.Size(122, 48);
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.configureToolStripMenuItem.Text = "Configure";
            this.configureToolStripMenuItem.Click += new System.EventHandler(this.configureToolStripMenuItem_Click);
            // 
            // closToolStripMenuItem
            // 
            this.closToolStripMenuItem.Name = "closToolStripMenuItem";
            this.closToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.closToolStripMenuItem.Text = "Close";
            this.closToolStripMenuItem.Click += new System.EventHandler(this.closToolStripMenuItem_Click);
            // 
            // lbFiles
            // 
            this.lbFiles.AllowDrop = true;
            this.lbFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbFiles.FormattingEnabled = true;
            this.lbFiles.Location = new System.Drawing.Point(0, 0);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.Size = new System.Drawing.Size(528, 264);
            this.lbFiles.TabIndex = 1;
            this.lbFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbFiles_DragDrop);
            this.lbFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbFiles_DragEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 266);
            this.Controls.Add(this.lbFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Tracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.cmsFileTracker.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon niFileTracker;
        private System.Windows.Forms.ContextMenuStrip cmsFileTracker;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closToolStripMenuItem;
        private System.Windows.Forms.ListBox lbFiles;
    }
}

