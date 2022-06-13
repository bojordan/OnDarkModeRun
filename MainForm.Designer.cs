namespace OnDarkModeChange
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.stateCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.currentStateLabel = new System.Windows.Forms.Label();
            this.systemTrayNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.systemTrayNotifyIconMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.currentStateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemTrayNotifyIconMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // stateCheckTimer
            // 
            this.stateCheckTimer.Enabled = true;
            this.stateCheckTimer.Interval = 1000;
            this.stateCheckTimer.Tick += new System.EventHandler(this.stateCheckTimer_Tick);
            // 
            // currentStateLabel
            // 
            this.currentStateLabel.AutoSize = true;
            this.currentStateLabel.Location = new System.Drawing.Point(12, 9);
            this.currentStateLabel.Name = "currentStateLabel";
            this.currentStateLabel.Size = new System.Drawing.Size(138, 25);
            this.currentStateLabel.TabIndex = 0;
            this.currentStateLabel.Text = "<Current State>";
            // 
            // systemTrayNotifyIcon
            // 
            this.systemTrayNotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.systemTrayNotifyIcon.ContextMenuStrip = this.systemTrayNotifyIconMenuStrip;
            this.systemTrayNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("systemTrayNotifyIcon.Icon")));
            this.systemTrayNotifyIcon.Text = "OnDarkModeRun";
            this.systemTrayNotifyIcon.Visible = true;
            // 
            // systemTrayNotifyIconMenuStrip
            // 
            this.systemTrayNotifyIconMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.systemTrayNotifyIconMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentStateMenuItem,
            this.toolStripSeparator1,
            this.quitMenuItem});
            this.systemTrayNotifyIconMenuStrip.Name = "contextMenuStrip1";
            this.systemTrayNotifyIconMenuStrip.Size = new System.Drawing.Size(211, 74);
            // 
            // currentStateMenuItem
            // 
            this.currentStateMenuItem.Name = "currentStateMenuItem";
            this.currentStateMenuItem.Size = new System.Drawing.Size(210, 32);
            this.currentStateMenuItem.Text = "<Current State>";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // quitMenuItem
            // 
            this.quitMenuItem.Name = "quitMenuItem";
            this.quitMenuItem.Size = new System.Drawing.Size(210, 32);
            this.quitMenuItem.Text = "Quit";
            this.quitMenuItem.Click += new System.EventHandler(this.quitMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 76);
            this.Controls.Add(this.currentStateLabel);
            this.Name = "MainForm";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "OnDarkModeRun";
            this.systemTrayNotifyIconMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer stateCheckTimer;
        private Label currentStateLabel;
        private NotifyIcon systemTrayNotifyIcon;
        private ContextMenuStrip systemTrayNotifyIconMenuStrip;
        private ToolStripMenuItem quitMenuItem;
        private ToolStripMenuItem currentStateMenuItem;
        private ToolStripSeparator toolStripSeparator1;
    }
}