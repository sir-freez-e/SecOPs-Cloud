namespace SecOPs_security_suite
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
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.Restore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateSignatures = new System.Windows.Forms.ToolStripMenuItem();
            this.SendReport = new System.Windows.Forms.ToolStripMenuItem();
            this.Scandrives = new System.Windows.Forms.ToolStripMenuItem();
            this.Scanurl = new System.Windows.Forms.ToolStripMenuItem();
            this.Scanfile = new System.Windows.Forms.ToolStripMenuItem();
            this.lblComputerName = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.ContextMenuStrip.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.ContextMenuStrip = this.ContextMenuStrip;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "SecOPs Security Suite";
            this.NotifyIcon.Visible = true;
            // 
            // ContextMenuStrip
            // 
            this.ContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About,
            this.Restore,
            this.toolStripSeparator1,
            this.Exit});
            this.ContextMenuStrip.Name = "contextMenuStrip";
            this.ContextMenuStrip.Size = new System.Drawing.Size(172, 82);
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(171, 24);
            this.About.Text = "About SecOPs";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Restore
            // 
            this.Restore.Name = "Restore";
            this.Restore.Size = new System.Drawing.Size(171, 24);
            this.Restore.Text = "Restore";
            this.Restore.Click += new System.EventHandler(this.Restore_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(171, 24);
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(800, 28);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdateSignatures,
            this.SendReport,
            this.Scandrives,
            this.Scanurl,
            this.Scanfile});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(46, 24);
            this.File.Text = "File";
            // 
            // UpdateSignatures
            // 
            this.UpdateSignatures.Name = "UpdateSignatures";
            this.UpdateSignatures.Size = new System.Drawing.Size(214, 26);
            this.UpdateSignatures.Text = "Update Signatures";
            this.UpdateSignatures.Click += new System.EventHandler(this.UpdateSignatures_Click);
            // 
            // SendReport
            // 
            this.SendReport.Name = "SendReport";
            this.SendReport.Size = new System.Drawing.Size(214, 26);
            this.SendReport.Text = "Send Report...";
            this.SendReport.Click += new System.EventHandler(this.SendReport_Click);
            // 
            // Scandrives
            // 
            this.Scandrives.Name = "Scandrives";
            this.Scandrives.Size = new System.Drawing.Size(214, 26);
            this.Scandrives.Text = "Scan drive(s)...";
            this.Scandrives.Click += new System.EventHandler(this.Scandrives_Click);
            // 
            // Scanurl
            // 
            this.Scanurl.Name = "Scanurl";
            this.Scanurl.Size = new System.Drawing.Size(214, 26);
            this.Scanurl.Text = "Scan url\'s...";
            this.Scanurl.Click += new System.EventHandler(this.Scanurl_Click);
            // 
            // Scanfile
            // 
            this.Scanfile.Name = "Scanfile";
            this.Scanfile.Size = new System.Drawing.Size(214, 26);
            this.Scanfile.Text = "Scan file(s)...";
            this.Scanfile.Click += new System.EventHandler(this.Scanfile_Click);
            // 
            // lblComputerName
            // 
            this.lblComputerName.AutoSize = true;
            this.lblComputerName.Location = new System.Drawing.Point(13, 40);
            this.lblComputerName.Name = "lblComputerName";
            this.lblComputerName.Size = new System.Drawing.Size(0, 18);
            this.lblComputerName.TabIndex = 2;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(13, 460);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(46, 18);
            this.labelInfo.TabIndex = 3;
            this.labelInfo.Text = "label1";
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowNavigation = false;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(274, 40);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(514, 454);
            this.webBrowser1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.lblComputerName);
            this.Controls.Add(this.MenuStrip);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Form1";
            this.Text = "SecOPs Security Suite";
            this.ContextMenuStrip.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private new System.Windows.Forms.ContextMenuStrip ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStripMenuItem Restore;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem UpdateSignatures;
        private System.Windows.Forms.ToolStripMenuItem SendReport;
        private System.Windows.Forms.ToolStripMenuItem Scandrives;
        private System.Windows.Forms.ToolStripMenuItem Scanurl;
        private System.Windows.Forms.ToolStripMenuItem Scanfile;
        private System.Windows.Forms.Label lblComputerName;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

