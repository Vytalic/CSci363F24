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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.settings_tab = new System.Windows.Forms.Button();
            this.history_tab = new System.Windows.Forms.Button();
            this.alerts_tab = new System.Windows.Forms.Button();
            this.gps_tab = new System.Windows.Forms.Button();
            this.vehicles_tab = new System.Windows.Forms.Button();
            this.drivers_tab = new System.Windows.Forms.Button();
            this.home_tab = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.VerticalBar = new System.Windows.Forms.Splitter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.MainContent = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.HorizontalBar = new System.Windows.Forms.Panel();
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
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
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
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "bell-ring.png");
            this.imageList1.Images.SetKeyName(1, "bell-slash.png");
            this.imageList1.Images.SetKeyName(2, "car.png");
            this.imageList1.Images.SetKeyName(3, "cowbell.png");
            this.imageList1.Images.SetKeyName(4, "cross.png");
            this.imageList1.Images.SetKeyName(5, "down.png");
            this.imageList1.Images.SetKeyName(6, "house-chimney.png");
            this.imageList1.Images.SetKeyName(7, "lock.png");
            this.imageList1.Images.SetKeyName(8, "lock-open-alt.png");
            this.imageList1.Images.SetKeyName(9, "marker.png");
            this.imageList1.Images.SetKeyName(10, "power.png");
            this.imageList1.Images.SetKeyName(11, "refresh.png");
            this.imageList1.Images.SetKeyName(12, "settings.png");
            this.imageList1.Images.SetKeyName(13, "time-past.png");
            this.imageList1.Images.SetKeyName(14, "up.png");
            this.imageList1.Images.SetKeyName(15, "user.png");
            this.imageList1.Images.SetKeyName(16, "wrench-alt.png");
            // 
            // settings_tab
            // 
            this.settings_tab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settings_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings_tab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settings_tab.ImageIndex = 12;
            this.settings_tab.ImageList = this.imageList1;
            this.settings_tab.Location = new System.Drawing.Point(15, 485);
            this.settings_tab.Margin = new System.Windows.Forms.Padding(15, 10, 10, 10);
            this.settings_tab.Name = "settings_tab";
            this.settings_tab.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.settings_tab.Size = new System.Drawing.Size(125, 50);
            this.settings_tab.TabIndex = 6;
            this.settings_tab.Text = "  Settings";
            this.settings_tab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settings_tab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settings_tab.UseVisualStyleBackColor = true;
            this.settings_tab.Click += new System.EventHandler(this.settings_tab_Click);
            // 
            // history_tab
            // 
            this.history_tab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.history_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history_tab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.history_tab.ImageIndex = 13;
            this.history_tab.ImageList = this.imageList1;
            this.history_tab.Location = new System.Drawing.Point(15, 415);
            this.history_tab.Margin = new System.Windows.Forms.Padding(15, 10, 10, 10);
            this.history_tab.Name = "history_tab";
            this.history_tab.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.history_tab.Size = new System.Drawing.Size(125, 50);
            this.history_tab.TabIndex = 5;
            this.history_tab.Text = "  History";
            this.history_tab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.history_tab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.history_tab.UseVisualStyleBackColor = true;
            this.history_tab.Click += new System.EventHandler(this.history_tab_Click);
            // 
            // alerts_tab
            // 
            this.alerts_tab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alerts_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alerts_tab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alerts_tab.ImageIndex = 3;
            this.alerts_tab.ImageList = this.imageList1;
            this.alerts_tab.Location = new System.Drawing.Point(15, 345);
            this.alerts_tab.Margin = new System.Windows.Forms.Padding(15, 10, 10, 10);
            this.alerts_tab.Name = "alerts_tab";
            this.alerts_tab.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.alerts_tab.Size = new System.Drawing.Size(125, 50);
            this.alerts_tab.TabIndex = 4;
            this.alerts_tab.Text = "  Alerts";
            this.alerts_tab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alerts_tab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.alerts_tab.UseVisualStyleBackColor = true;
            this.alerts_tab.Click += new System.EventHandler(this.alerts_tab_Click);
            // 
            // gps_tab
            // 
            this.gps_tab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gps_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gps_tab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gps_tab.ImageIndex = 9;
            this.gps_tab.ImageList = this.imageList1;
            this.gps_tab.Location = new System.Drawing.Point(15, 275);
            this.gps_tab.Margin = new System.Windows.Forms.Padding(15, 10, 10, 10);
            this.gps_tab.Name = "gps_tab";
            this.gps_tab.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.gps_tab.Size = new System.Drawing.Size(125, 50);
            this.gps_tab.TabIndex = 3;
            this.gps_tab.Text = "  GPS";
            this.gps_tab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gps_tab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.gps_tab.UseVisualStyleBackColor = true;
            this.gps_tab.Click += new System.EventHandler(this.gps_tab_Click);
            // 
            // vehicles_tab
            // 
            this.vehicles_tab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vehicles_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicles_tab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vehicles_tab.ImageIndex = 2;
            this.vehicles_tab.ImageList = this.imageList1;
            this.vehicles_tab.Location = new System.Drawing.Point(15, 205);
            this.vehicles_tab.Margin = new System.Windows.Forms.Padding(15, 10, 10, 10);
            this.vehicles_tab.Name = "vehicles_tab";
            this.vehicles_tab.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.vehicles_tab.Size = new System.Drawing.Size(125, 50);
            this.vehicles_tab.TabIndex = 2;
            this.vehicles_tab.Text = "  Vehicles";
            this.vehicles_tab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vehicles_tab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.vehicles_tab.UseVisualStyleBackColor = true;
            this.vehicles_tab.Click += new System.EventHandler(this.vehicles_tab_Click);
            // 
            // drivers_tab
            // 
            this.drivers_tab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.drivers_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drivers_tab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.drivers_tab.ImageIndex = 15;
            this.drivers_tab.ImageList = this.imageList1;
            this.drivers_tab.Location = new System.Drawing.Point(15, 135);
            this.drivers_tab.Margin = new System.Windows.Forms.Padding(15, 10, 10, 10);
            this.drivers_tab.Name = "drivers_tab";
            this.drivers_tab.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.drivers_tab.Size = new System.Drawing.Size(125, 50);
            this.drivers_tab.TabIndex = 1;
            this.drivers_tab.Text = "  Drivers";
            this.drivers_tab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.drivers_tab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.drivers_tab.UseVisualStyleBackColor = true;
            this.drivers_tab.Click += new System.EventHandler(this.drivers_tab_Click);
            // 
            // home_tab
            // 
            this.home_tab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.home_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_tab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_tab.ImageIndex = 6;
            this.home_tab.ImageList = this.imageList1;
            this.home_tab.Location = new System.Drawing.Point(15, 65);
            this.home_tab.Margin = new System.Windows.Forms.Padding(15, 10, 10, 10);
            this.home_tab.Name = "home_tab";
            this.home_tab.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.home_tab.Size = new System.Drawing.Size(125, 50);
            this.home_tab.TabIndex = 0;
            this.home_tab.Text = "  Home";
            this.home_tab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_tab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.home_tab.UseVisualStyleBackColor = true;
            this.home_tab.Click += new System.EventHandler(this.home_tab_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SidePanel.AutoSize = true;
            this.SidePanel.Controls.Add(this.home_tab);
            this.SidePanel.Controls.Add(this.drivers_tab);
            this.SidePanel.Controls.Add(this.vehicles_tab);
            this.SidePanel.Controls.Add(this.gps_tab);
            this.SidePanel.Controls.Add(this.alerts_tab);
            this.SidePanel.Controls.Add(this.history_tab);
            this.SidePanel.Controls.Add(this.settings_tab);
            this.SidePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Padding = new System.Windows.Forms.Padding(0, 55, 0, 0);
            this.SidePanel.Size = new System.Drawing.Size(150, 561);
            this.SidePanel.TabIndex = 0;
            this.SidePanel.WrapContents = false;
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
            // MainContent
            // 
            this.MainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContent.Location = new System.Drawing.Point(0, 0);
            this.MainContent.Name = "MainContent";
            this.MainContent.Size = new System.Drawing.Size(853, 457);
            this.MainContent.TabIndex = 0;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.HorizontalBar);
            this.TopPanel.Controls.Add(this.lblCurrentTime);
            this.TopPanel.Controls.Add(this.lblCurrentDate);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(853, 100);
            this.TopPanel.TabIndex = 0;
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDate.Location = new System.Drawing.Point(378, 9);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(101, 20);
            this.lblCurrentDate.TabIndex = 0;
            this.lblCurrentDate.Text = "Current Date";
            this.lblCurrentDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.Location = new System.Drawing.Point(377, 29);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(154, 29);
            this.lblCurrentTime.TabIndex = 1;
            this.lblCurrentTime.Text = "Current Time";
            this.lblCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HorizontalBar
            // 
            this.HorizontalBar.BackColor = System.Drawing.Color.Black;
            this.HorizontalBar.Location = new System.Drawing.Point(0, 97);
            this.HorizontalBar.Name = "HorizontalBar";
            this.HorizontalBar.Size = new System.Drawing.Size(853, 3);
            this.HorizontalBar.TabIndex = 2;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ImageList imageList1;
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
    }
}

