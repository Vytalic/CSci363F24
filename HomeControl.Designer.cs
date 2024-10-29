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
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.btnStopEngine = new System.Windows.Forms.Button();
            this.imageList4 = new System.Windows.Forms.ImageList(this.components);
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
            this.btnStartEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartEngine.ImageIndex = 5;
            this.btnStartEngine.ImageList = this.imageList3;
            this.btnStartEngine.Location = new System.Drawing.Point(126, 91);
            this.btnStartEngine.Name = "btnStartEngine";
            this.btnStartEngine.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnStartEngine.Size = new System.Drawing.Size(105, 99);
            this.btnStartEngine.TabIndex = 2;
            this.btnStartEngine.Text = "Start";
            this.btnStartEngine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStartEngine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStartEngine.UseVisualStyleBackColor = true;
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
            // btnStopEngine
            // 
            this.btnStopEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopEngine.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStopEngine.ImageIndex = 1;
            this.btnStopEngine.ImageList = this.imageList4;
            this.btnStopEngine.Location = new System.Drawing.Point(262, 91);
            this.btnStopEngine.Name = "btnStopEngine";
            this.btnStopEngine.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnStopEngine.Size = new System.Drawing.Size(105, 98);
            this.btnStopEngine.TabIndex = 3;
            this.btnStopEngine.Text = "Stop";
            this.btnStopEngine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStopEngine.UseVisualStyleBackColor = true;
            // 
            // imageList4
            // 
            this.imageList4.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList4.ImageStream")));
            this.imageList4.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList4.Images.SetKeyName(0, "cross-small.png");
            this.imageList4.Images.SetKeyName(1, "cross.png");
            // 
            // lblEngine
            // 
            this.lblEngine.AutoSize = true;
            this.lblEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEngine.Location = new System.Drawing.Point(186, 35);
            this.lblEngine.Name = "lblEngine";
            this.lblEngine.Size = new System.Drawing.Size(122, 37);
            this.lblEngine.TabIndex = 4;
            this.lblEngine.Text = "Engine";
            this.lblEngine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnActivateAlarm
            // 
            this.btnActivateAlarm.AutoSize = true;
            this.btnActivateAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivateAlarm.ImageIndex = 0;
            this.btnActivateAlarm.ImageList = this.imageList3;
            this.btnActivateAlarm.Location = new System.Drawing.Point(484, 91);
            this.btnActivateAlarm.Name = "btnActivateAlarm";
            this.btnActivateAlarm.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnActivateAlarm.Size = new System.Drawing.Size(105, 99);
            this.btnActivateAlarm.TabIndex = 5;
            this.btnActivateAlarm.Text = "Activate";
            this.btnActivateAlarm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActivateAlarm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnActivateAlarm.UseVisualStyleBackColor = true;
            // 
            // btnDeactivateAlarm
            // 
            this.btnDeactivateAlarm.AutoSize = true;
            this.btnDeactivateAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeactivateAlarm.ImageIndex = 1;
            this.btnDeactivateAlarm.ImageList = this.imageList3;
            this.btnDeactivateAlarm.Location = new System.Drawing.Point(620, 91);
            this.btnDeactivateAlarm.Name = "btnDeactivateAlarm";
            this.btnDeactivateAlarm.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnDeactivateAlarm.Size = new System.Drawing.Size(106, 99);
            this.btnDeactivateAlarm.TabIndex = 6;
            this.btnDeactivateAlarm.Text = "Deactivate";
            this.btnDeactivateAlarm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeactivateAlarm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeactivateAlarm.UseVisualStyleBackColor = true;
            // 
            // lblAlarm
            // 
            this.lblAlarm.AutoSize = true;
            this.lblAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlarm.Location = new System.Drawing.Point(551, 36);
            this.lblAlarm.Name = "lblAlarm";
            this.lblAlarm.Size = new System.Drawing.Size(107, 37);
            this.lblAlarm.TabIndex = 7;
            this.lblAlarm.Text = "Alarm";
            this.lblAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDoors
            // 
            this.lblDoors.AutoSize = true;
            this.lblDoors.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoors.Location = new System.Drawing.Point(186, 264);
            this.lblDoors.Name = "lblDoors";
            this.lblDoors.Size = new System.Drawing.Size(108, 37);
            this.lblDoors.TabIndex = 8;
            this.lblDoors.Text = "Doors";
            this.lblDoors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLockDoor
            // 
            this.btnLockDoor.AutoSize = true;
            this.btnLockDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLockDoor.ImageIndex = 3;
            this.btnLockDoor.ImageList = this.imageList3;
            this.btnLockDoor.Location = new System.Drawing.Point(126, 322);
            this.btnLockDoor.Name = "btnLockDoor";
            this.btnLockDoor.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnLockDoor.Size = new System.Drawing.Size(105, 99);
            this.btnLockDoor.TabIndex = 9;
            this.btnLockDoor.Text = "Lock";
            this.btnLockDoor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLockDoor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLockDoor.UseVisualStyleBackColor = true;
            // 
            // btnUnlockDoor
            // 
            this.btnUnlockDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnlockDoor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUnlockDoor.ImageIndex = 4;
            this.btnUnlockDoor.ImageList = this.imageList3;
            this.btnUnlockDoor.Location = new System.Drawing.Point(262, 322);
            this.btnUnlockDoor.Name = "btnUnlockDoor";
            this.btnUnlockDoor.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.btnUnlockDoor.Size = new System.Drawing.Size(105, 98);
            this.btnUnlockDoor.TabIndex = 10;
            this.btnUnlockDoor.Text = "Unlock";
            this.btnUnlockDoor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUnlockDoor.UseVisualStyleBackColor = true;
            // 
            // btnCloseWindows
            // 
            this.btnCloseWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseWindows.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCloseWindows.ImageIndex = 6;
            this.btnCloseWindows.ImageList = this.imageList3;
            this.btnCloseWindows.Location = new System.Drawing.Point(620, 322);
            this.btnCloseWindows.Name = "btnCloseWindows";
            this.btnCloseWindows.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.btnCloseWindows.Size = new System.Drawing.Size(105, 98);
            this.btnCloseWindows.TabIndex = 13;
            this.btnCloseWindows.Text = "Close";
            this.btnCloseWindows.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCloseWindows.UseVisualStyleBackColor = true;
            // 
            // btnOpenWindows
            // 
            this.btnOpenWindows.AutoSize = true;
            this.btnOpenWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenWindows.ImageIndex = 2;
            this.btnOpenWindows.ImageList = this.imageList3;
            this.btnOpenWindows.Location = new System.Drawing.Point(484, 322);
            this.btnOpenWindows.Name = "btnOpenWindows";
            this.btnOpenWindows.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnOpenWindows.Size = new System.Drawing.Size(105, 99);
            this.btnOpenWindows.TabIndex = 12;
            this.btnOpenWindows.Text = "Open";
            this.btnOpenWindows.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOpenWindows.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOpenWindows.UseVisualStyleBackColor = true;
            // 
            // lblWindows
            // 
            this.lblWindows.AutoSize = true;
            this.lblWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindows.Location = new System.Drawing.Point(530, 264);
            this.lblWindows.Name = "lblWindows";
            this.lblWindows.Size = new System.Drawing.Size(155, 37);
            this.lblWindows.TabIndex = 11;
            this.lblWindows.Text = "Windows";
            this.lblWindows.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStartEngine;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.Button btnStopEngine;
        private System.Windows.Forms.ImageList imageList4;
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
    }
}
