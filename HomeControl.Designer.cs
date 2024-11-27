namespace RemoteVehicleManager
{
    partial class HomeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStartEngine = new System.Windows.Forms.Button();
            this.imageList5 = new System.Windows.Forms.ImageList(this.components);
            this.btnStopEngine = new System.Windows.Forms.Button();
            this.imageList6 = new System.Windows.Forms.ImageList(this.components);
            this.lblEngine = new System.Windows.Forms.Label();
            this.btnActivateAlarm = new System.Windows.Forms.Button();
            this.btnDeactivateAlarm = new System.Windows.Forms.Button();
            this.lblAlarm = new System.Windows.Forms.Label();
            this.lblDoors = new System.Windows.Forms.Label();
            this.btnLockDoor = new System.Windows.Forms.Button();
            this.btnUnlockDoor = new System.Windows.Forms.Button();
            this.btnCloseWindows = new System.Windows.Forms.Button();
            this.btnOpenWindows = new System.Windows.Forms.Button();
            this.lblWindows = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList4 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.lblWindowsStatus = new System.Windows.Forms.Label();
            this.lblDoorsStatus = new System.Windows.Forms.Label();
            this.lblAlarmStatus = new System.Windows.Forms.Label();
            this.lblEngineStatus = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(426, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 385);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(126, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 3);
            this.panel2.TabIndex = 1;
            // 
            // btnStartEngine
            // 
            this.btnStartEngine.AutoSize = true;
            this.btnStartEngine.BackColor = System.Drawing.Color.PaleGreen;
            this.btnStartEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartEngine.ImageIndex = 5;
            this.btnStartEngine.ImageList = this.imageList5;
            this.btnStartEngine.Location = new System.Drawing.Point(126, 91);
            this.btnStartEngine.Name = "btnStartEngine";
            this.btnStartEngine.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnStartEngine.Size = new System.Drawing.Size(105, 99);
            this.btnStartEngine.TabIndex = 2;
            this.btnStartEngine.Text = "Start";
            this.btnStartEngine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStartEngine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStartEngine.UseVisualStyleBackColor = false;
            this.btnStartEngine.Click += new System.EventHandler(this.btnStartEngine_Click);
            // 
            // imageList5
            // 
            this.imageList5.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList5.ImageStream")));
            this.imageList5.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList5.Images.SetKeyName(0, "bell-ring.png");
            this.imageList5.Images.SetKeyName(1, "bell-slash.png");
            this.imageList5.Images.SetKeyName(2, "down.png");
            this.imageList5.Images.SetKeyName(3, "lock.png");
            this.imageList5.Images.SetKeyName(4, "lock-open-alt.png");
            this.imageList5.Images.SetKeyName(5, "power.png");
            this.imageList5.Images.SetKeyName(6, "up.png");
            // 
            // btnStopEngine
            // 
            this.btnStopEngine.BackColor = System.Drawing.Color.LightCoral;
            this.btnStopEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopEngine.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStopEngine.ImageIndex = 0;
            this.btnStopEngine.ImageList = this.imageList6;
            this.btnStopEngine.Location = new System.Drawing.Point(262, 91);
            this.btnStopEngine.Name = "btnStopEngine";
            this.btnStopEngine.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnStopEngine.Size = new System.Drawing.Size(105, 98);
            this.btnStopEngine.TabIndex = 3;
            this.btnStopEngine.Text = "Stop";
            this.btnStopEngine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStopEngine.UseVisualStyleBackColor = false;
            this.btnStopEngine.Click += new System.EventHandler(this.btnStopEngine_Click);
            // 
            // imageList6
            // 
            this.imageList6.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList6.ImageStream")));
            this.imageList6.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList6.Images.SetKeyName(0, "cross.png");
            // 
            // lblEngine
            // 
            this.lblEngine.AutoSize = true;
            this.lblEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEngine.Location = new System.Drawing.Point(116, 24);
            this.lblEngine.Name = "lblEngine";
            this.lblEngine.Size = new System.Drawing.Size(180, 55);
            this.lblEngine.TabIndex = 4;
            this.lblEngine.Text = "Engine";
            this.lblEngine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnActivateAlarm
            // 
            this.btnActivateAlarm.AutoSize = true;
            this.btnActivateAlarm.BackColor = System.Drawing.Color.PaleGreen;
            this.btnActivateAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivateAlarm.ImageIndex = 0;
            this.btnActivateAlarm.ImageList = this.imageList5;
            this.btnActivateAlarm.Location = new System.Drawing.Point(484, 91);
            this.btnActivateAlarm.Name = "btnActivateAlarm";
            this.btnActivateAlarm.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnActivateAlarm.Size = new System.Drawing.Size(105, 99);
            this.btnActivateAlarm.TabIndex = 5;
            this.btnActivateAlarm.Text = "Activate";
            this.btnActivateAlarm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActivateAlarm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnActivateAlarm.UseVisualStyleBackColor = false;
            this.btnActivateAlarm.Click += new System.EventHandler(this.btnActivateAlarm_Click);
            // 
            // btnDeactivateAlarm
            // 
            this.btnDeactivateAlarm.AutoSize = true;
            this.btnDeactivateAlarm.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeactivateAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeactivateAlarm.ImageIndex = 1;
            this.btnDeactivateAlarm.ImageList = this.imageList5;
            this.btnDeactivateAlarm.Location = new System.Drawing.Point(610, 91);
            this.btnDeactivateAlarm.Name = "btnDeactivateAlarm";
            this.btnDeactivateAlarm.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnDeactivateAlarm.Size = new System.Drawing.Size(116, 99);
            this.btnDeactivateAlarm.TabIndex = 6;
            this.btnDeactivateAlarm.Text = "Deactivate";
            this.btnDeactivateAlarm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeactivateAlarm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeactivateAlarm.UseVisualStyleBackColor = false;
            this.btnDeactivateAlarm.Click += new System.EventHandler(this.btnDeactivateAlarm_Click);
            // 
            // lblAlarm
            // 
            this.lblAlarm.AutoSize = true;
            this.lblAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlarm.Location = new System.Drawing.Point(474, 24);
            this.lblAlarm.Name = "lblAlarm";
            this.lblAlarm.Size = new System.Drawing.Size(154, 55);
            this.lblAlarm.TabIndex = 7;
            this.lblAlarm.Text = "Alarm";
            this.lblAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDoors
            // 
            this.lblDoors.AutoSize = true;
            this.lblDoors.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoors.Location = new System.Drawing.Point(116, 264);
            this.lblDoors.Name = "lblDoors";
            this.lblDoors.Size = new System.Drawing.Size(158, 55);
            this.lblDoors.TabIndex = 8;
            this.lblDoors.Text = "Doors";
            this.lblDoors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLockDoor
            // 
            this.btnLockDoor.AutoSize = true;
            this.btnLockDoor.BackColor = System.Drawing.Color.PaleGreen;
            this.btnLockDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLockDoor.ImageIndex = 3;
            this.btnLockDoor.ImageList = this.imageList5;
            this.btnLockDoor.Location = new System.Drawing.Point(126, 322);
            this.btnLockDoor.Name = "btnLockDoor";
            this.btnLockDoor.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnLockDoor.Size = new System.Drawing.Size(105, 99);
            this.btnLockDoor.TabIndex = 9;
            this.btnLockDoor.Text = "Lock";
            this.btnLockDoor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLockDoor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLockDoor.UseVisualStyleBackColor = false;
            this.btnLockDoor.Click += new System.EventHandler(this.btnLockDoor_Click);
            // 
            // btnUnlockDoor
            // 
            this.btnUnlockDoor.BackColor = System.Drawing.Color.LightCoral;
            this.btnUnlockDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnlockDoor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUnlockDoor.ImageIndex = 4;
            this.btnUnlockDoor.ImageList = this.imageList5;
            this.btnUnlockDoor.Location = new System.Drawing.Point(262, 322);
            this.btnUnlockDoor.Name = "btnUnlockDoor";
            this.btnUnlockDoor.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.btnUnlockDoor.Size = new System.Drawing.Size(105, 98);
            this.btnUnlockDoor.TabIndex = 10;
            this.btnUnlockDoor.Text = "Unlock";
            this.btnUnlockDoor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUnlockDoor.UseVisualStyleBackColor = false;
            this.btnUnlockDoor.Click += new System.EventHandler(this.btnUnlockDoor_Click);
            // 
            // btnCloseWindows
            // 
            this.btnCloseWindows.BackColor = System.Drawing.Color.LightCoral;
            this.btnCloseWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseWindows.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCloseWindows.ImageIndex = 6;
            this.btnCloseWindows.ImageList = this.imageList5;
            this.btnCloseWindows.Location = new System.Drawing.Point(620, 322);
            this.btnCloseWindows.Name = "btnCloseWindows";
            this.btnCloseWindows.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.btnCloseWindows.Size = new System.Drawing.Size(105, 98);
            this.btnCloseWindows.TabIndex = 13;
            this.btnCloseWindows.Text = "Close";
            this.btnCloseWindows.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCloseWindows.UseVisualStyleBackColor = false;
            this.btnCloseWindows.Click += new System.EventHandler(this.btnCloseWindows_Click);
            // 
            // btnOpenWindows
            // 
            this.btnOpenWindows.AutoSize = true;
            this.btnOpenWindows.BackColor = System.Drawing.Color.PaleGreen;
            this.btnOpenWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenWindows.ImageIndex = 2;
            this.btnOpenWindows.ImageList = this.imageList5;
            this.btnOpenWindows.Location = new System.Drawing.Point(484, 322);
            this.btnOpenWindows.Name = "btnOpenWindows";
            this.btnOpenWindows.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnOpenWindows.Size = new System.Drawing.Size(105, 99);
            this.btnOpenWindows.TabIndex = 12;
            this.btnOpenWindows.Text = "Open";
            this.btnOpenWindows.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOpenWindows.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOpenWindows.UseVisualStyleBackColor = false;
            this.btnOpenWindows.Click += new System.EventHandler(this.btnOpenWindows_Click);
            // 
            // lblWindows
            // 
            this.lblWindows.AutoSize = true;
            this.lblWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindows.Location = new System.Drawing.Point(474, 264);
            this.lblWindows.Name = "lblWindows";
            this.lblWindows.Size = new System.Drawing.Size(226, 55);
            this.lblWindows.TabIndex = 11;
            this.lblWindows.Text = "Windows";
            this.lblWindows.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cross.png");
            // 
            // imageList4
            // 
            this.imageList4.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList4.ImageStream")));
            this.imageList4.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList4.Images.SetKeyName(0, "cross-small.png");
            this.imageList4.Images.SetKeyName(1, "cross.png");
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "bell-ring.png");
            this.imageList3.Images.SetKeyName(1, "bell-slash.png");
            this.imageList3.Images.SetKeyName(2, "down.png");
            this.imageList3.Images.SetKeyName(3, "lock.png");
            this.imageList3.Images.SetKeyName(4, "lock-open-alt.png");
            this.imageList3.Images.SetKeyName(5, "power.png");
            this.imageList3.Images.SetKeyName(6, "up.png");
            this.imageList3.Images.SetKeyName(7, "cross-small.png");
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
            // lblWindowsStatus
            // 
            this.lblWindowsStatus.AutoSize = true;
            this.lblWindowsStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindowsStatus.Location = new System.Drawing.Point(689, 283);
            this.lblWindowsStatus.Name = "lblWindowsStatus";
            this.lblWindowsStatus.Size = new System.Drawing.Size(66, 20);
            this.lblWindowsStatus.TabIndex = 35;
            this.lblWindowsStatus.Text = "(Status)";
            this.lblWindowsStatus.Visible = false;
            // 
            // lblDoorsStatus
            // 
            this.lblDoorsStatus.AutoSize = true;
            this.lblDoorsStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoorsStatus.Location = new System.Drawing.Point(261, 283);
            this.lblDoorsStatus.Name = "lblDoorsStatus";
            this.lblDoorsStatus.Size = new System.Drawing.Size(66, 20);
            this.lblDoorsStatus.TabIndex = 34;
            this.lblDoorsStatus.Text = "(Status)";
            this.lblDoorsStatus.Visible = false;
            // 
            // lblAlarmStatus
            // 
            this.lblAlarmStatus.AutoSize = true;
            this.lblAlarmStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlarmStatus.Location = new System.Drawing.Point(619, 43);
            this.lblAlarmStatus.Name = "lblAlarmStatus";
            this.lblAlarmStatus.Size = new System.Drawing.Size(66, 20);
            this.lblAlarmStatus.TabIndex = 33;
            this.lblAlarmStatus.Text = "(Status)";
            this.lblAlarmStatus.Visible = false;
            // 
            // lblEngineStatus
            // 
            this.lblEngineStatus.AutoSize = true;
            this.lblEngineStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEngineStatus.Location = new System.Drawing.Point(284, 43);
            this.lblEngineStatus.Name = "lblEngineStatus";
            this.lblEngineStatus.Size = new System.Drawing.Size(66, 20);
            this.lblEngineStatus.TabIndex = 32;
            this.lblEngineStatus.Text = "(Status)";
            this.lblEngineStatus.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCoral;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(60, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(745, 410);
            this.panel3.TabIndex = 36;
            this.panel3.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(723, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "/////////////// Alert! \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(427, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vehicle Break-in Detected!";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(432, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Dismiss Alert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(203, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Check Alerts";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblWindowsStatus);
            this.Controls.Add(this.lblDoorsStatus);
            this.Controls.Add(this.lblAlarmStatus);
            this.Controls.Add(this.lblEngineStatus);
            this.Controls.Add(this.btnCloseWindows);
            this.Controls.Add(this.btnOpenWindows);
            this.Controls.Add(this.lblWindows);
            this.Controls.Add(this.btnUnlockDoor);
            this.Controls.Add(this.btnLockDoor);
            this.Controls.Add(this.lblDoors);
            this.Controls.Add(this.lblAlarm);
            this.Controls.Add(this.btnDeactivateAlarm);
            this.Controls.Add(this.btnActivateAlarm);
            this.Controls.Add(this.lblEngine);
            this.Controls.Add(this.btnStopEngine);
            this.Controls.Add(this.btnStartEngine);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HomeControl";
            this.Size = new System.Drawing.Size(853, 457);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStartEngine;
        private System.Windows.Forms.Button btnStopEngine;
        private System.Windows.Forms.Label lblEngine;
        private System.Windows.Forms.Button btnActivateAlarm;
        private System.Windows.Forms.Button btnDeactivateAlarm;
        private System.Windows.Forms.Label lblAlarm;
        private System.Windows.Forms.Label lblDoors;
        private System.Windows.Forms.Button btnLockDoor;
        private System.Windows.Forms.Button btnUnlockDoor;
        private System.Windows.Forms.Button btnCloseWindows;
        private System.Windows.Forms.Button btnOpenWindows;
        private System.Windows.Forms.Label lblWindows;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.ImageList imageList4;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList5;
        private System.Windows.Forms.ImageList imageList6;
        private System.Windows.Forms.Label lblWindowsStatus;
        private System.Windows.Forms.Label lblDoorsStatus;
        private System.Windows.Forms.Label lblAlarmStatus;
        private System.Windows.Forms.Label lblEngineStatus;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
