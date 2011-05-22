namespace Productivity
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.program_timer = new System.Windows.Forms.Timer(this.components);
            this.work_timer = new System.Windows.Forms.Timer(this.components);
            this.ActiveApp = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.detailsLabel = new System.Windows.Forms.LinkLabel();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timerSwitch = new System.Windows.Forms.Button();
            this.ElapsedTime = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.productiveWindowsList = new System.Windows.Forms.TextBox();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SystrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Systray_Config = new System.Windows.Forms.ToolStripMenuItem();
            this.SystrayExit = new System.Windows.Forms.ToolStripMenuItem();
            this.hideButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detectApps = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SystrayMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // program_timer
            // 
            this.program_timer.Enabled = true;
            this.program_timer.Interval = 200;
            this.program_timer.Tick += new System.EventHandler(this.program_timer_Tick);
            // 
            // work_timer
            // 
            this.work_timer.Interval = 1000;
            this.work_timer.Tick += new System.EventHandler(this.work_timer_Tick);
            // 
            // ActiveApp
            // 
            this.ActiveApp.AutoEllipsis = true;
            this.ActiveApp.AutoSize = true;
            this.ActiveApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiveApp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ActiveApp.Location = new System.Drawing.Point(20, 20);
            this.ActiveApp.MaximumSize = new System.Drawing.Size(400, 0);
            this.ActiveApp.MinimumSize = new System.Drawing.Size(400, 36);
            this.ActiveApp.Name = "ActiveApp";
            this.ActiveApp.Size = new System.Drawing.Size(400, 36);
            this.ActiveApp.TabIndex = 0;
            this.ActiveApp.Text = "Active application";
            this.ActiveApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ActiveApp.Click += new System.EventHandler(this.ActiveApp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ActiveApp);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 68);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Active Application";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resetButton);
            this.groupBox2.Controls.Add(this.detailsLabel);
            this.groupBox2.Controls.Add(this.timerLabel);
            this.groupBox2.Controls.Add(this.timerSwitch);
            this.groupBox2.Controls.Add(this.ElapsedTime);
            this.groupBox2.Location = new System.Drawing.Point(12, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 154);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estimated Productive Time";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(98, 113);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Location = new System.Drawing.Point(78, 68);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(48, 13);
            this.detailsLabel.TabIndex = 3;
            this.detailsLabel.TabStop = true;
            this.detailsLabel.Text = "Details...";
            this.detailsLabel.Visible = false;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Location = new System.Drawing.Point(64, 93);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(66, 13);
            this.timerLabel.TabIndex = 2;
            this.timerLabel.Text = "Timer is OFF";
            // 
            // timerSwitch
            // 
            this.timerSwitch.Location = new System.Drawing.Point(13, 113);
            this.timerSwitch.Name = "timerSwitch";
            this.timerSwitch.Size = new System.Drawing.Size(75, 23);
            this.timerSwitch.TabIndex = 1;
            this.timerSwitch.Text = "On/Off";
            this.timerSwitch.UseVisualStyleBackColor = true;
            this.timerSwitch.Click += new System.EventHandler(this.timerSwitch_Click);
            // 
            // ElapsedTime
            // 
            this.ElapsedTime.AutoSize = true;
            this.ElapsedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElapsedTime.Location = new System.Drawing.Point(63, 40);
            this.ElapsedTime.Name = "ElapsedTime";
            this.ElapsedTime.Size = new System.Drawing.Size(70, 24);
            this.ElapsedTime.TabIndex = 0;
            this.ElapsedTime.Text = "0:00:00";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.productiveWindowsList);
            this.groupBox3.Location = new System.Drawing.Point(203, 110);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 153);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Productive Windows";
            this.groupBox3.UseCompatibleTextRendering = true;
            // 
            // productiveWindowsList
            // 
            this.productiveWindowsList.Location = new System.Drawing.Point(6, 19);
            this.productiveWindowsList.Multiline = true;
            this.productiveWindowsList.Name = "productiveWindowsList";
            this.productiveWindowsList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.productiveWindowsList.Size = new System.Drawing.Size(237, 117);
            this.productiveWindowsList.TabIndex = 0;
            this.productiveWindowsList.WordWrap = false;
            // 
            // TrayIcon
            // 
            this.TrayIcon.ContextMenuStrip = this.SystrayMenu;
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "ProdCounter";
            this.TrayIcon.Visible = true;
            this.TrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseDoubleClick);
            // 
            // SystrayMenu
            // 
            this.SystrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Systray_Config,
            this.SystrayExit});
            this.SystrayMenu.Name = "SystrayMenu";
            this.SystrayMenu.Size = new System.Drawing.Size(128, 48);
            // 
            // Systray_Config
            // 
            this.Systray_Config.Name = "Systray_Config";
            this.Systray_Config.Size = new System.Drawing.Size(127, 22);
            this.Systray_Config.Text = "Configure";
            this.Systray_Config.Click += new System.EventHandler(this.Systray_Config_Click);
            // 
            // SystrayExit
            // 
            this.SystrayExit.Name = "SystrayExit";
            this.SystrayExit.Size = new System.Drawing.Size(127, 22);
            this.SystrayExit.Text = "Exit";
            this.SystrayExit.Click += new System.EventHandler(this.SystrayExit_Click);
            // 
            // hideButton
            // 
            this.hideButton.Location = new System.Drawing.Point(150, 273);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(75, 23);
            this.hideButton.TabIndex = 6;
            this.hideButton.Text = "Hide";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(231, 273);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(464, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSiteToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // openSiteToolStripMenuItem
            // 
            this.openSiteToolStripMenuItem.Name = "openSiteToolStripMenuItem";
            this.openSiteToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.openSiteToolStripMenuItem.Text = "Open site";
            this.openSiteToolStripMenuItem.Click += new System.EventHandler(this.openSiteToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // detectApps
            // 
            this.detectApps.Location = new System.Drawing.Point(326, 273);
            this.detectApps.Name = "detectApps";
            this.detectApps.Size = new System.Drawing.Size(126, 23);
            this.detectApps.TabIndex = 1;
            this.detectApps.Text = "Detect applications...";
            this.detectApps.UseVisualStyleBackColor = true;
            this.detectApps.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 308);
            this.ControlBox = false;
            this.Controls.Add(this.detectApps);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hideButton);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Productivity Counter";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.SystrayMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer program_timer;
        private System.Windows.Forms.Timer work_timer;
        private System.Windows.Forms.Label ActiveApp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label ElapsedTime;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.ContextMenuStrip SystrayMenu;
        private System.Windows.Forms.ToolStripMenuItem SystrayExit;
        private System.Windows.Forms.TextBox productiveWindowsList;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Button timerSwitch;
        private System.Windows.Forms.Button hideButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ToolStripMenuItem Systray_Config;
        private System.Windows.Forms.LinkLabel detailsLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button detectApps;

    }
}

