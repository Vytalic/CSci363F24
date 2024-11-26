namespace RemoteVehicleManager
{
    partial class DriversControl
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
            this.lblDrivers = new System.Windows.Forms.Label();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUnsavedChanges = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnEditDrivers = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDrivers
            // 
            this.lblDrivers.AutoSize = true;
            this.lblDrivers.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrivers.Location = new System.Drawing.Point(608, 0);
            this.lblDrivers.Name = "lblDrivers";
            this.lblDrivers.Size = new System.Drawing.Size(245, 55);
            this.lblDrivers.TabIndex = 0;
            this.lblDrivers.Text = "DRIVERS";
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.BackColor = System.Drawing.Color.LightGray;
            this.btnAddDriver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddDriver.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDriver.Location = new System.Drawing.Point(3, 3);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(115, 29);
            this.btnAddDriver.TabIndex = 16;
            this.btnAddDriver.Text = "Add Driver";
            this.btnAddDriver.UseVisualStyleBackColor = false;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(88, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 329);
            this.panel1.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(115, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(390, 179);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(225, 412);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 29);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // lblUnsavedChanges
            // 
            this.lblUnsavedChanges.AutoSize = true;
            this.lblUnsavedChanges.Location = new System.Drawing.Point(256, 410);
            this.lblUnsavedChanges.Name = "lblUnsavedChanges";
            this.lblUnsavedChanges.Size = new System.Drawing.Size(154, 13);
            this.lblUnsavedChanges.TabIndex = 19;
            this.lblUnsavedChanges.Text = "You have # unsaved changes!";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Location = new System.Drawing.Point(613, 400);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(105, 53);
            this.btnSaveChanges.TabIndex = 18;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Visible = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnEditDrivers
            // 
            this.btnEditDrivers.BackColor = System.Drawing.Color.LightCoral;
            this.btnEditDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditDrivers.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDrivers.Location = new System.Drawing.Point(724, 401);
            this.btnEditDrivers.Name = "btnEditDrivers";
            this.btnEditDrivers.Size = new System.Drawing.Size(115, 53);
            this.btnEditDrivers.TabIndex = 21;
            this.btnEditDrivers.Text = "Edit Drivers";
            this.btnEditDrivers.UseVisualStyleBackColor = false;
            this.btnEditDrivers.Click += new System.EventHandler(this.btnEditDrivers_Click);
            // 
            // DriversControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.btnEditDrivers);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblUnsavedChanges);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddDriver);
            this.Controls.Add(this.lblDrivers);
            this.Name = "DriversControl";
            this.Size = new System.Drawing.Size(853, 457);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDrivers;
        private System.Windows.Forms.Button btnAddDriver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUnsavedChanges;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnEditDrivers;
    }
}
