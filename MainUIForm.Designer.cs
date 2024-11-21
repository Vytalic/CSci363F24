namespace RemoteVehicleManager
{
    partial class MainUIForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUIForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.SidePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.home_tab = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.drivers_tab = new System.Windows.Forms.Button();
            this.vehicles_tab = new System.Windows.Forms.Button();
            this.gps_tab = new System.Windows.Forms.Button();
            this.alerts_tab = new System.Windows.Forms.Button();
            this.history_tab = new System.Windows.Forms.Button();
            this.settings_tab = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.HorizontalBar = new System.Windows.Forms.Panel();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.MainContent = new System.Windows.Forms.Panel();
            this.btnCloseWindows = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnOpenWindows = new System.Windows.Forms.Button();
            this.lblWindows = new System.Windows.Forms.Label();
            this.btnUnlockDoor = new System.Windows.Forms.Button();
            this.btnLockDoor = new System.Windows.Forms.Button();
            this.lblDoors = new System.Windows.Forms.Label();
            this.lblAlarm = new System.Windows.Forms.Label();
            this.btnDeactivateAlarm = new System.Windows.Forms.Button();
            this.btnActivateAlarm = new System.Windows.Forms.Button();
            this.lblEngine = new System.Windows.Forms.Label();
            this.btnStopEngine = new System.Windows.Forms.Button();
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.btnStartEngine = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.VerticalBar = new System.Windows.Forms.Splitter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.drkIcons = new System.Windows.Forms.ImageList(this.components);
            this.lblEngineStatus = new System.Windows.Forms.Label();
            this.lblAlarmStatus = new System.Windows.Forms.Label();
            this.lblDoorsStatus = new System.Windows.Forms.Label();
            this.lblWindowsStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SidePanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.MainContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.DarkGray;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.SidePanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ContentPanel);
            this.splitContainer1.Size = new System.Drawing.Size(1008, 561);
            this.splitContainer1.SplitterDistance = 148;
            this.splitContainer1.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SidePanel.AutoSize = true;
            this.SidePanel.BackColor = System.Drawing.Color.DarkGray;
            this.SidePanel.Controls.Add(this.home_tab);
            this.SidePanel.Controls.Add(this.drivers_tab);
            this.SidePanel.Controls.Add(this.vehicles_tab);
            this.SidePanel.Controls.Add(this.gps_tab);
            this.SidePanel.Controls.Add(this.alerts_tab);
            this.SidePanel.Controls.Add(this.history_tab);
            this.SidePanel.Controls.Add(this.settings_tab);
            this.SidePanel.Controls.Add(this.btnTest);
            this.SidePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.SidePanel.Location = new System.Drawing.Point(0, -16);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Padding = new System.Windows.Forms.Padding(0, 55, 0, 0);
            this.SidePanel.Size = new System.Drawing.Size(152, 577);
            this.SidePanel.TabIndex = 0;
            this.SidePanel.WrapContents = false;
            // 
            // home_tab
            // 
            this.home_tab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.home_tab.BackColor = System.Drawing.Color.LightSkyBlue;
            this.home_tab.FlatAppearance.BorderSize = 2;
            this.home_tab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_tab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_tab.ImageIndex = 2;
            this.home_tab.ImageList = this.imageList2;
            this.home_tab.Location = new System.Drawing.Point(10, 65);
            this.home_tab.Margin = new System.Windows.Forms.Padding(10);
            this.home_tab.Name = "home_tab";
            this.home_tab.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.home_tab.Size = new System.Drawing.Size(132, 50);
            this.home_tab.TabIndex = 0;
            this.home_tab.Text = "  Home";
            this.home_tab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_tab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.home_tab.UseVisualStyleBackColor = false;
            this.home_tab.Click += new System.EventHandler(this.home_tab_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "car.png");
            this.imageList2.Images.SetKeyName(1, "cowbell.png");
            this.imageList2.Images.SetKeyName(2, "house-chimney.png");
            this.imageList2.Images.SetKeyName(3, "marker.png");
            this.imageList2.Images.SetKeyName(4, "settings.png");
            this.imageList2.Images.SetKeyName(5, "time-past.png");
            this.imageList2.Images.SetKeyName(6, "user.png");
            // 
            // drivers_tab
            // 
            this.drivers_tab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.drivers_tab.BackColor = System.Drawing.Color.LightSkyBlue;
            this.drivers_tab.FlatAppearance.BorderSize = 2;
            this.drivers_tab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drivers_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drivers_tab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.drivers_tab.ImageIndex = 6;
            this.drivers_tab.ImageList = this.imageList2;
            this.drivers_tab.Location = new System.Drawing.Point(10, 135);
            this.drivers_tab.Margin = new System.Windows.Forms.Padding(10);
            this.drivers_tab.Name = "drivers_tab";
            this.drivers_tab.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.drivers_tab.Size = new System.Drawing.Size(132, 50);
            this.drivers_tab.TabIndex = 1;
            this.drivers_tab.Text = "  Drivers";
            this.drivers_tab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.drivers_tab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.drivers_tab.UseVisualStyleBackColor = false;
            this.drivers_tab.Click += new System.EventHandler(this.drivers_tab_Click);
            // 
            // vehicles_tab
            // 
            this.vehicles_tab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vehicles_tab.BackColor = System.Drawing.Color.LightSkyBlue;
            this.vehicles_tab.FlatAppearance.BorderSize = 2;
            this.vehicles_tab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vehicles_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicles_tab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vehicles_tab.ImageIndex = 0;
            this.vehicles_tab.ImageList = this.imageList2;
            this.vehicles_tab.Location = new System.Drawing.Point(10, 205);
            this.vehicles_tab.Margin = new System.Windows.Forms.Padding(10);
            this.vehicles_tab.Name = "vehicles_tab";
            this.vehicles_tab.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.vehicles_tab.Size = new System.Drawing.Size(132, 50);
            this.vehicles_tab.TabIndex = 2;
            this.vehicles_tab.Text = "  Vehicles";
            this.vehicles_tab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vehicles_tab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.vehicles_tab.UseVisualStyleBackColor = false;
            this.vehicles_tab.Click += new System.EventHandler(this.vehicles_tab_Click);
            // 
            // gps_tab
            // 
            this.gps_tab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gps_tab.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gps_tab.FlatAppearance.BorderSize = 2;
            this.gps_tab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gps_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gps_tab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gps_tab.ImageIndex = 3;
            this.gps_tab.ImageList = this.imageList2;
            this.gps_tab.Location = new System.Drawing.Point(10, 275);
            this.gps_tab.Margin = new System.Windows.Forms.Padding(10);
            this.gps_tab.Name = "gps_tab";
            this.gps_tab.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.gps_tab.Size = new System.Drawing.Size(132, 50);
            this.gps_tab.TabIndex = 3;
            this.gps_tab.Text = "  GPS";
            this.gps_tab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gps_tab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.gps_tab.UseVisualStyleBackColor = false;
            this.gps_tab.Click += new System.EventHandler(this.gps_tab_Click);
            // 
            // alerts_tab
            // 
            this.alerts_tab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alerts_tab.BackColor = System.Drawing.Color.LightSkyBlue;
            this.alerts_tab.FlatAppearance.BorderSize = 2;
            this.alerts_tab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alerts_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alerts_tab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alerts_tab.ImageIndex = 1;
            this.alerts_tab.ImageList = this.imageList2;
            this.alerts_tab.Location = new System.Drawing.Point(10, 345);
            this.alerts_tab.Margin = new System.Windows.Forms.Padding(10);
            this.alerts_tab.Name = "alerts_tab";
            this.alerts_tab.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.alerts_tab.Size = new System.Drawing.Size(132, 50);
            this.alerts_tab.TabIndex = 4;
            this.alerts_tab.Text = "  Alerts";
            this.alerts_tab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alerts_tab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.alerts_tab.UseVisualStyleBackColor = false;
            this.alerts_tab.Click += new System.EventHandler(this.alerts_tab_Click);
            // 
            // history_tab
            // 
            this.history_tab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.history_tab.BackColor = System.Drawing.Color.LightSkyBlue;
            this.history_tab.FlatAppearance.BorderSize = 2;
            this.history_tab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.history_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history_tab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.history_tab.ImageIndex = 5;
            this.history_tab.ImageList = this.imageList2;
            this.history_tab.Location = new System.Drawing.Point(10, 415);
            this.history_tab.Margin = new System.Windows.Forms.Padding(10);
            this.history_tab.Name = "history_tab";
            this.history_tab.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.history_tab.Size = new System.Drawing.Size(132, 50);
            this.history_tab.TabIndex = 5;
            this.history_tab.Text = "  History";
            this.history_tab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.history_tab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.history_tab.UseVisualStyleBackColor = false;
            this.history_tab.Click += new System.EventHandler(this.history_tab_Click);
            // 
            // settings_tab
            // 
            this.settings_tab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settings_tab.BackColor = System.Drawing.Color.LightSkyBlue;
            this.settings_tab.FlatAppearance.BorderSize = 2;
            this.settings_tab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings_tab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settings_tab.ImageIndex = 4;
            this.settings_tab.ImageList = this.imageList2;
            this.settings_tab.Location = new System.Drawing.Point(10, 485);
            this.settings_tab.Margin = new System.Windows.Forms.Padding(10);
            this.settings_tab.Name = "settings_tab";
            this.settings_tab.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.settings_tab.Size = new System.Drawing.Size(132, 50);
            this.settings_tab.TabIndex = 6;
            this.settings_tab.Text = "  Settings";
            this.settings_tab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settings_tab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settings_tab.UseVisualStyleBackColor = false;
            this.settings_tab.Click += new System.EventHandler(this.settings_tab_Click);
            // 
            // btnTest
            // 
            this.btnTest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTest.Location = new System.Drawing.Point(10, 548);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(132, 26);
            this.btnTest.TabIndex = 7;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.splitContainer2);
            this.ContentPanel.Controls.Add(this.VerticalBar);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(856, 561);
            this.ContentPanel.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(3, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.TopPanel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.MainContent);
            this.splitContainer2.Size = new System.Drawing.Size(853, 561);
            this.splitContainer2.SplitterDistance = 100;
            this.splitContainer2.TabIndex = 1;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.DarkGray;
            this.TopPanel.Controls.Add(this.HorizontalBar);
            this.TopPanel.Controls.Add(this.lblCurrentTime);
            this.TopPanel.Controls.Add(this.lblCurrentDate);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(853, 100);
            this.TopPanel.TabIndex = 0;
            // 
            // HorizontalBar
            // 
            this.HorizontalBar.BackColor = System.Drawing.Color.Black;
            this.HorizontalBar.Location = new System.Drawing.Point(0, 97);
            this.HorizontalBar.Name = "HorizontalBar";
            this.HorizontalBar.Size = new System.Drawing.Size(853, 3);
            this.HorizontalBar.TabIndex = 2;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.Location = new System.Drawing.Point(316, 45);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(220, 39);
            this.lblCurrentTime.TabIndex = 1;
            this.lblCurrentTime.Text = "Current Time";
            this.lblCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDate.Location = new System.Drawing.Point(306, 9);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(148, 29);
            this.lblCurrentDate.TabIndex = 0;
            this.lblCurrentDate.Text = "Current Date";
            this.lblCurrentDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainContent
            // 
            this.MainContent.BackColor = System.Drawing.Color.DarkGray;
            this.MainContent.Controls.Add(this.lblWindowsStatus);
            this.MainContent.Controls.Add(this.lblDoorsStatus);
            this.MainContent.Controls.Add(this.lblAlarmStatus);
            this.MainContent.Controls.Add(this.lblEngineStatus);
            this.MainContent.Controls.Add(this.btnCloseWindows);
            this.MainContent.Controls.Add(this.btnOpenWindows);
            this.MainContent.Controls.Add(this.lblWindows);
            this.MainContent.Controls.Add(this.btnUnlockDoor);
            this.MainContent.Controls.Add(this.btnLockDoor);
            this.MainContent.Controls.Add(this.lblDoors);
            this.MainContent.Controls.Add(this.lblAlarm);
            this.MainContent.Controls.Add(this.btnDeactivateAlarm);
            this.MainContent.Controls.Add(this.btnActivateAlarm);
            this.MainContent.Controls.Add(this.lblEngine);
            this.MainContent.Controls.Add(this.btnStopEngine);
            this.MainContent.Controls.Add(this.btnStartEngine);
            this.MainContent.Controls.Add(this.panel2);
            this.MainContent.Controls.Add(this.panel1);
            this.MainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContent.Location = new System.Drawing.Point(0, 0);
            this.MainContent.Name = "MainContent";
            this.MainContent.Size = new System.Drawing.Size(853, 457);
            this.MainContent.TabIndex = 0;
            // 
            // btnCloseWindows
            // 
            this.btnCloseWindows.BackColor = System.Drawing.Color.LightCoral;
            this.btnCloseWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseWindows.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCloseWindows.ImageIndex = 6;
            this.btnCloseWindows.ImageList = this.imageList1;
            this.btnCloseWindows.Location = new System.Drawing.Point(620, 322);
            this.btnCloseWindows.Name = "btnCloseWindows";
            this.btnCloseWindows.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.btnCloseWindows.Size = new System.Drawing.Size(105, 98);
            this.btnCloseWindows.TabIndex = 27;
            this.btnCloseWindows.Text = "Close";
            this.btnCloseWindows.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCloseWindows.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "bell-ring.png");
            this.imageList1.Images.SetKeyName(1, "bell-slash.png");
            this.imageList1.Images.SetKeyName(2, "down.png");
            this.imageList1.Images.SetKeyName(3, "lock.png");
            this.imageList1.Images.SetKeyName(4, "lock-open-alt.png");
            this.imageList1.Images.SetKeyName(5, "power.png");
            this.imageList1.Images.SetKeyName(6, "up.png");
            // 
            // btnOpenWindows
            // 
            this.btnOpenWindows.AutoSize = true;
            this.btnOpenWindows.BackColor = System.Drawing.Color.PaleGreen;
            this.btnOpenWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenWindows.ImageIndex = 2;
            this.btnOpenWindows.ImageList = this.imageList1;
            this.btnOpenWindows.Location = new System.Drawing.Point(484, 322);
            this.btnOpenWindows.Name = "btnOpenWindows";
            this.btnOpenWindows.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnOpenWindows.Size = new System.Drawing.Size(105, 99);
            this.btnOpenWindows.TabIndex = 26;
            this.btnOpenWindows.Text = "Open";
            this.btnOpenWindows.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOpenWindows.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOpenWindows.UseVisualStyleBackColor = false;
            // 
            // lblWindows
            // 
            this.lblWindows.AutoSize = true;
            this.lblWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindows.Location = new System.Drawing.Point(474, 264);
            this.lblWindows.Name = "lblWindows";
            this.lblWindows.Size = new System.Drawing.Size(226, 55);
            this.lblWindows.TabIndex = 25;
            this.lblWindows.Text = "Windows";
            this.lblWindows.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUnlockDoor
            // 
            this.btnUnlockDoor.BackColor = System.Drawing.Color.LightCoral;
            this.btnUnlockDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnlockDoor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUnlockDoor.ImageIndex = 4;
            this.btnUnlockDoor.ImageList = this.imageList1;
            this.btnUnlockDoor.Location = new System.Drawing.Point(262, 322);
            this.btnUnlockDoor.Name = "btnUnlockDoor";
            this.btnUnlockDoor.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.btnUnlockDoor.Size = new System.Drawing.Size(105, 98);
            this.btnUnlockDoor.TabIndex = 24;
            this.btnUnlockDoor.Text = "Unlock";
            this.btnUnlockDoor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUnlockDoor.UseVisualStyleBackColor = false;
            // 
            // btnLockDoor
            // 
            this.btnLockDoor.AutoSize = true;
            this.btnLockDoor.BackColor = System.Drawing.Color.PaleGreen;
            this.btnLockDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLockDoor.ImageIndex = 3;
            this.btnLockDoor.ImageList = this.imageList1;
            this.btnLockDoor.Location = new System.Drawing.Point(126, 322);
            this.btnLockDoor.Name = "btnLockDoor";
            this.btnLockDoor.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnLockDoor.Size = new System.Drawing.Size(105, 99);
            this.btnLockDoor.TabIndex = 23;
            this.btnLockDoor.Text = "Lock";
            this.btnLockDoor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLockDoor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLockDoor.UseVisualStyleBackColor = false;
            // 
            // lblDoors
            // 
            this.lblDoors.AutoSize = true;
            this.lblDoors.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoors.Location = new System.Drawing.Point(116, 264);
            this.lblDoors.Name = "lblDoors";
            this.lblDoors.Size = new System.Drawing.Size(158, 55);
            this.lblDoors.TabIndex = 22;
            this.lblDoors.Text = "Doors";
            this.lblDoors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlarm
            // 
            this.lblAlarm.AutoSize = true;
            this.lblAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlarm.Location = new System.Drawing.Point(474, 26);
            this.lblAlarm.Name = "lblAlarm";
            this.lblAlarm.Size = new System.Drawing.Size(154, 55);
            this.lblAlarm.TabIndex = 21;
            this.lblAlarm.Text = "Alarm";
            this.lblAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDeactivateAlarm
            // 
            this.btnDeactivateAlarm.AutoSize = true;
            this.btnDeactivateAlarm.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeactivateAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeactivateAlarm.ImageIndex = 1;
            this.btnDeactivateAlarm.ImageList = this.imageList1;
            this.btnDeactivateAlarm.Location = new System.Drawing.Point(610, 91);
            this.btnDeactivateAlarm.Name = "btnDeactivateAlarm";
            this.btnDeactivateAlarm.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnDeactivateAlarm.Size = new System.Drawing.Size(116, 99);
            this.btnDeactivateAlarm.TabIndex = 20;
            this.btnDeactivateAlarm.Text = "Deactivate";
            this.btnDeactivateAlarm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeactivateAlarm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeactivateAlarm.UseVisualStyleBackColor = false;
            // 
            // btnActivateAlarm
            // 
            this.btnActivateAlarm.AutoSize = true;
            this.btnActivateAlarm.BackColor = System.Drawing.Color.PaleGreen;
            this.btnActivateAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivateAlarm.ImageIndex = 0;
            this.btnActivateAlarm.ImageList = this.imageList1;
            this.btnActivateAlarm.Location = new System.Drawing.Point(484, 91);
            this.btnActivateAlarm.Name = "btnActivateAlarm";
            this.btnActivateAlarm.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnActivateAlarm.Size = new System.Drawing.Size(105, 99);
            this.btnActivateAlarm.TabIndex = 19;
            this.btnActivateAlarm.Text = "Activate";
            this.btnActivateAlarm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActivateAlarm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnActivateAlarm.UseVisualStyleBackColor = false;
            // 
            // lblEngine
            // 
            this.lblEngine.AutoSize = true;
            this.lblEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEngine.Location = new System.Drawing.Point(116, 26);
            this.lblEngine.Name = "lblEngine";
            this.lblEngine.Size = new System.Drawing.Size(180, 55);
            this.lblEngine.TabIndex = 18;
            this.lblEngine.Text = "Engine";
            this.lblEngine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStopEngine
            // 
            this.btnStopEngine.BackColor = System.Drawing.Color.LightCoral;
            this.btnStopEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopEngine.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStopEngine.ImageIndex = 0;
            this.btnStopEngine.ImageList = this.imageList3;
            this.btnStopEngine.Location = new System.Drawing.Point(262, 91);
            this.btnStopEngine.Name = "btnStopEngine";
            this.btnStopEngine.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnStopEngine.Size = new System.Drawing.Size(105, 98);
            this.btnStopEngine.TabIndex = 17;
            this.btnStopEngine.Text = "Stop";
            this.btnStopEngine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStopEngine.UseVisualStyleBackColor = false;
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "cross.png");
            // 
            // btnStartEngine
            // 
            this.btnStartEngine.AutoSize = true;
            this.btnStartEngine.BackColor = System.Drawing.Color.PaleGreen;
            this.btnStartEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartEngine.ImageIndex = 5;
            this.btnStartEngine.ImageList = this.imageList1;
            this.btnStartEngine.Location = new System.Drawing.Point(126, 91);
            this.btnStartEngine.Name = "btnStartEngine";
            this.btnStartEngine.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnStartEngine.Size = new System.Drawing.Size(105, 99);
            this.btnStartEngine.TabIndex = 16;
            this.btnStartEngine.Text = "Start";
            this.btnStartEngine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStartEngine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStartEngine.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(126, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 3);
            this.panel2.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(426, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 385);
            this.panel1.TabIndex = 14;
            // 
            // VerticalBar
            // 
            this.VerticalBar.BackColor = System.Drawing.Color.Black;
            this.VerticalBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.VerticalBar.Enabled = false;
            this.VerticalBar.Location = new System.Drawing.Point(0, 0);
            this.VerticalBar.Name = "VerticalBar";
            this.VerticalBar.Size = new System.Drawing.Size(3, 561);
            this.VerticalBar.TabIndex = 0;
            this.VerticalBar.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // drkIcons
            // 
            this.drkIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("drkIcons.ImageStream")));
            this.drkIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.drkIcons.Images.SetKeyName(0, "drkcar.png");
            this.drkIcons.Images.SetKeyName(1, "drkcowbell.png");
            this.drkIcons.Images.SetKeyName(2, "drkhouse-chimney.png");
            this.drkIcons.Images.SetKeyName(3, "drkmarker.png");
            this.drkIcons.Images.SetKeyName(4, "drksettings.png");
            this.drkIcons.Images.SetKeyName(5, "drktime-past.png");
            this.drkIcons.Images.SetKeyName(6, "drkuser.png");
            // 
            // lblEngineStatus
            // 
            this.lblEngineStatus.AutoSize = true;
            this.lblEngineStatus.Location = new System.Drawing.Point(303, 51);
            this.lblEngineStatus.Name = "lblEngineStatus";
            this.lblEngineStatus.Size = new System.Drawing.Size(43, 13);
            this.lblEngineStatus.TabIndex = 28;
            this.lblEngineStatus.Text = "(Status)";
            // 
            // lblAlarmStatus
            // 
            this.lblAlarmStatus.AutoSize = true;
            this.lblAlarmStatus.Location = new System.Drawing.Point(643, 51);
            this.lblAlarmStatus.Name = "lblAlarmStatus";
            this.lblAlarmStatus.Size = new System.Drawing.Size(43, 13);
            this.lblAlarmStatus.TabIndex = 29;
            this.lblAlarmStatus.Text = "(Status)";
            // 
            // lblDoorsStatus
            // 
            this.lblDoorsStatus.AutoSize = true;
            this.lblDoorsStatus.Location = new System.Drawing.Point(280, 283);
            this.lblDoorsStatus.Name = "lblDoorsStatus";
            this.lblDoorsStatus.Size = new System.Drawing.Size(43, 13);
            this.lblDoorsStatus.TabIndex = 30;
            this.lblDoorsStatus.Text = "(Status)";
            // 
            // lblWindowsStatus
            // 
            this.lblWindowsStatus.AutoSize = true;
            this.lblWindowsStatus.Location = new System.Drawing.Point(706, 283);
            this.lblWindowsStatus.Name = "lblWindowsStatus";
            this.lblWindowsStatus.Size = new System.Drawing.Size(43, 13);
            this.lblWindowsStatus.TabIndex = 31;
            this.lblWindowsStatus.Text = "(Status)";
            // 
            // MainUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "MainUIForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainUIForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.SidePanel.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.MainContent.ResumeLayout(false);
            this.MainContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel SidePanel;
        private System.Windows.Forms.Button home_tab;
        private System.Windows.Forms.Button drivers_tab;
        private System.Windows.Forms.Button vehicles_tab;
        private System.Windows.Forms.Button gps_tab;
        private System.Windows.Forms.Button alerts_tab;
        private System.Windows.Forms.Button history_tab;
        private System.Windows.Forms.Button settings_tab;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Splitter VerticalBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Panel MainContent;
        private System.Windows.Forms.Panel HorizontalBar;
        private System.Windows.Forms.Button btnCloseWindows;
        private System.Windows.Forms.Button btnOpenWindows;
        private System.Windows.Forms.Label lblWindows;
        private System.Windows.Forms.Button btnUnlockDoor;
        private System.Windows.Forms.Button btnLockDoor;
        private System.Windows.Forms.Label lblDoors;
        private System.Windows.Forms.Label lblAlarm;
        private System.Windows.Forms.Button btnDeactivateAlarm;
        private System.Windows.Forms.Button btnActivateAlarm;
        private System.Windows.Forms.Label lblEngine;
        private System.Windows.Forms.Button btnStopEngine;
        private System.Windows.Forms.Button btnStartEngine;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.ImageList drkIcons;
        private System.Windows.Forms.Label lblAlarmStatus;
        private System.Windows.Forms.Label lblEngineStatus;
        private System.Windows.Forms.Label lblWindowsStatus;
        private System.Windows.Forms.Label lblDoorsStatus;
    }
}

