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
            this.textboxVehicle1 = new System.Windows.Forms.TextBox();
            this.textboxVehicle2 = new System.Windows.Forms.TextBox();
            this.textboxVehicle3 = new System.Windows.Forms.TextBox();
            this.btnEditVehicles = new System.Windows.Forms.Button();
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
            // textboxVehicle1
            // 
            this.textboxVehicle1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxVehicle1.Location = new System.Drawing.Point(94, 106);
            this.textboxVehicle1.Multiline = true;
            this.textboxVehicle1.Name = "textboxVehicle1";
            this.textboxVehicle1.Size = new System.Drawing.Size(301, 75);
            this.textboxVehicle1.TabIndex = 1;
            this.textboxVehicle1.Text = "Vehicle 1";
            this.textboxVehicle1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textboxVehicle2
            // 
            this.textboxVehicle2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxVehicle2.Location = new System.Drawing.Point(94, 196);
            this.textboxVehicle2.Multiline = true;
            this.textboxVehicle2.Name = "textboxVehicle2";
            this.textboxVehicle2.Size = new System.Drawing.Size(301, 75);
            this.textboxVehicle2.TabIndex = 2;
            this.textboxVehicle2.Text = "Vehicle 2";
            this.textboxVehicle2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textboxVehicle3
            // 
            this.textboxVehicle3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxVehicle3.Location = new System.Drawing.Point(94, 288);
            this.textboxVehicle3.Multiline = true;
            this.textboxVehicle3.Name = "textboxVehicle3";
            this.textboxVehicle3.Size = new System.Drawing.Size(301, 75);
            this.textboxVehicle3.TabIndex = 3;
            this.textboxVehicle3.Text = "Vehicle 3";
            this.textboxVehicle3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEditVehicles
            // 
            this.btnEditVehicles.BackColor = System.Drawing.Color.LightCoral;
            this.btnEditVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditVehicles.Location = new System.Drawing.Point(708, 406);
            this.btnEditVehicles.Name = "btnEditVehicles";
            this.btnEditVehicles.Size = new System.Drawing.Size(129, 37);
            this.btnEditVehicles.TabIndex = 4;
            this.btnEditVehicles.Text = "Edit Vehicles";
            this.btnEditVehicles.UseVisualStyleBackColor = false;
            // 
            // VehiclesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.btnEditVehicles);
            this.Controls.Add(this.textboxVehicle3);
            this.Controls.Add(this.textboxVehicle2);
            this.Controls.Add(this.textboxVehicle1);
            this.Controls.Add(this.lblVehicles);
            this.Name = "VehiclesControl";
            this.Size = new System.Drawing.Size(853, 457);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVehicles;
        private System.Windows.Forms.TextBox textboxVehicle1;
        private System.Windows.Forms.TextBox textboxVehicle2;
        private System.Windows.Forms.TextBox textboxVehicle3;
        private System.Windows.Forms.Button btnEditVehicles;
    }
}
