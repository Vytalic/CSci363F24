namespace RemoteVehicleManager
{
    partial class VehiclesControl
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
            this.lblVehicles = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditVehicles = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVehicles
            // 
            this.lblVehicles.AutoSize = true;
            this.lblVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicles.Location = new System.Drawing.Point(583, 0);
            this.lblVehicles.Name = "lblVehicles";
            this.lblVehicles.Size = new System.Drawing.Size(270, 55);
            this.lblVehicles.TabIndex = 0;
            this.lblVehicles.Text = "VEHICLES";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(104, 121);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(596, 245);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 457);
            this.panel1.TabIndex = 6;
            // 
            // btnEditVehicles
            // 
            this.btnEditVehicles.BackColor = System.Drawing.Color.LightCoral;
            this.btnEditVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditVehicles.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditVehicles.Location = new System.Drawing.Point(725, 401);
            this.btnEditVehicles.Name = "btnEditVehicles";
            this.btnEditVehicles.Size = new System.Drawing.Size(115, 53);
            this.btnEditVehicles.TabIndex = 4;
            this.btnEditVehicles.Text = "Edit Vehicles";
            this.btnEditVehicles.UseVisualStyleBackColor = false;
            this.btnEditVehicles.Click += new System.EventHandler(this.btnEditVehicles_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Location = new System.Drawing.Point(614, 401);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(105, 53);
            this.btnSaveChanges.TabIndex = 14;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Visible = false;
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.BackColor = System.Drawing.Color.LightGray;
            this.btnAddVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddVehicle.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVehicle.Location = new System.Drawing.Point(17, 26);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(115, 29);
            this.btnAddVehicle.TabIndex = 15;
            this.btnAddVehicle.Text = "Add Vehicle";
            this.btnAddVehicle.UseVisualStyleBackColor = false;
            // 
            // VehiclesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.btnAddVehicle);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnEditVehicles);
            this.Controls.Add(this.lblVehicles);
            this.Controls.Add(this.panel1);
            this.Name = "VehiclesControl";
            this.Size = new System.Drawing.Size(853, 457);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVehicles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEditVehicles;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnAddVehicle;
    }
}
