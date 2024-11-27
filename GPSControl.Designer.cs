namespace RemoteVehicleManager
{
    partial class GPSControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GPSControl));
            this.lblGPS = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fuelProgressBar = new System.Windows.Forms.ProgressBar();
            this.lblOilpct = new System.Windows.Forms.Label();
            this.lblFuelpct = new System.Windows.Forms.Label();
            this.lblOil = new System.Windows.Forms.Label();
            this.lblFuel = new System.Windows.Forms.Label();
            this.oilProgressBar = new System.Windows.Forms.ProgressBar();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.lblMiles = new System.Windows.Forms.Label();
            this.lblOilMiles = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBatMiles = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.batProgressBar = new System.Windows.Forms.ProgressBar();
            this.lblBatpct = new System.Windows.Forms.Label();
            this.lblBat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGPS
            // 
            this.lblGPS.AutoSize = true;
            this.lblGPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPS.Location = new System.Drawing.Point(170, 0);
            this.lblGPS.Name = "lblGPS";
            this.lblGPS.Size = new System.Drawing.Size(128, 55);
            this.lblGPS.TabIndex = 0;
            this.lblGPS.Text = "GPS";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.lblGPS);
            this.splitContainer1.Size = new System.Drawing.Size(853, 457);
            this.splitContainer1.SplitterDistance = 551;
            this.splitContainer1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(499, 407);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblBatMiles);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.batProgressBar);
            this.panel1.Controls.Add(this.lblBatpct);
            this.panel1.Controls.Add(this.lblBat);
            this.panel1.Controls.Add(this.lblOilMiles);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblMiles);
            this.panel1.Controls.Add(this.lblRemaining);
            this.panel1.Controls.Add(this.oilProgressBar);
            this.panel1.Controls.Add(this.fuelProgressBar);
            this.panel1.Controls.Add(this.lblOilpct);
            this.panel1.Controls.Add(this.lblFuelpct);
            this.panel1.Controls.Add(this.lblOil);
            this.panel1.Controls.Add(this.lblFuel);
            this.panel1.Location = new System.Drawing.Point(18, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 346);
            this.panel1.TabIndex = 1;
            // 
            // fuelProgressBar
            // 
            this.fuelProgressBar.BackColor = System.Drawing.Color.White;
            this.fuelProgressBar.Location = new System.Drawing.Point(61, 47);
            this.fuelProgressBar.Name = "fuelProgressBar";
            this.fuelProgressBar.Size = new System.Drawing.Size(128, 23);
            this.fuelProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.fuelProgressBar.TabIndex = 4;
            this.fuelProgressBar.Visible = false;
            // 
            // lblOilpct
            // 
            this.lblOilpct.AutoSize = true;
            this.lblOilpct.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOilpct.Location = new System.Drawing.Point(195, 292);
            this.lblOilpct.Name = "lblOilpct";
            this.lblOilpct.Size = new System.Drawing.Size(37, 21);
            this.lblOilpct.TabIndex = 3;
            this.lblOilpct.Text = "0 %";
            // 
            // lblFuelpct
            // 
            this.lblFuelpct.AutoSize = true;
            this.lblFuelpct.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelpct.Location = new System.Drawing.Point(195, 49);
            this.lblFuelpct.Name = "lblFuelpct";
            this.lblFuelpct.Size = new System.Drawing.Size(37, 21);
            this.lblFuelpct.TabIndex = 2;
            this.lblFuelpct.Text = "0 %";
            this.lblFuelpct.Visible = false;
            // 
            // lblOil
            // 
            this.lblOil.AutoSize = true;
            this.lblOil.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOil.Location = new System.Drawing.Point(106, 255);
            this.lblOil.Name = "lblOil";
            this.lblOil.Size = new System.Drawing.Size(51, 34);
            this.lblOil.TabIndex = 1;
            this.lblOil.Text = "Oil";
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuel.Location = new System.Drawing.Point(98, 10);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(68, 34);
            this.lblFuel.TabIndex = 0;
            this.lblFuel.Text = "Fuel";
            this.lblFuel.Visible = false;
            // 
            // oilProgressBar
            // 
            this.oilProgressBar.BackColor = System.Drawing.Color.White;
            this.oilProgressBar.Location = new System.Drawing.Point(61, 292);
            this.oilProgressBar.Name = "oilProgressBar";
            this.oilProgressBar.Size = new System.Drawing.Size(128, 23);
            this.oilProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.oilProgressBar.TabIndex = 5;
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemaining.Location = new System.Drawing.Point(59, 76);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(80, 21);
            this.lblRemaining.TabIndex = 6;
            this.lblRemaining.Text = "Estimate:";
            this.lblRemaining.Visible = false;
            // 
            // lblMiles
            // 
            this.lblMiles.AutoSize = true;
            this.lblMiles.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiles.Location = new System.Drawing.Point(135, 76);
            this.lblMiles.Name = "lblMiles";
            this.lblMiles.Size = new System.Drawing.Size(41, 21);
            this.lblMiles.TabIndex = 7;
            this.lblMiles.Text = "0 mi";
            this.lblMiles.Visible = false;
            // 
            // lblOilMiles
            // 
            this.lblOilMiles.AutoSize = true;
            this.lblOilMiles.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOilMiles.Location = new System.Drawing.Point(146, 318);
            this.lblOilMiles.Name = "lblOilMiles";
            this.lblOilMiles.Size = new System.Drawing.Size(41, 21);
            this.lblOilMiles.TabIndex = 9;
            this.lblOilMiles.Text = "0 mi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Change In: ";
            // 
            // lblBatMiles
            // 
            this.lblBatMiles.AutoSize = true;
            this.lblBatMiles.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatMiles.Location = new System.Drawing.Point(135, 200);
            this.lblBatMiles.Name = "lblBatMiles";
            this.lblBatMiles.Size = new System.Drawing.Size(41, 21);
            this.lblBatMiles.TabIndex = 14;
            this.lblBatMiles.Text = "0 mi";
            this.lblBatMiles.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Estimate:";
            this.label3.Visible = false;
            // 
            // batProgressBar
            // 
            this.batProgressBar.BackColor = System.Drawing.Color.White;
            this.batProgressBar.Location = new System.Drawing.Point(61, 171);
            this.batProgressBar.Name = "batProgressBar";
            this.batProgressBar.Size = new System.Drawing.Size(128, 23);
            this.batProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.batProgressBar.TabIndex = 12;
            this.batProgressBar.Visible = false;
            // 
            // lblBatpct
            // 
            this.lblBatpct.AutoSize = true;
            this.lblBatpct.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatpct.Location = new System.Drawing.Point(195, 173);
            this.lblBatpct.Name = "lblBatpct";
            this.lblBatpct.Size = new System.Drawing.Size(37, 21);
            this.lblBatpct.TabIndex = 11;
            this.lblBatpct.Text = "0 %";
            this.lblBatpct.Visible = false;
            // 
            // lblBat
            // 
            this.lblBat.AutoSize = true;
            this.lblBat.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBat.Location = new System.Drawing.Point(79, 134);
            this.lblBat.Name = "lblBat";
            this.lblBat.Size = new System.Drawing.Size(110, 34);
            this.lblBat.TabIndex = 10;
            this.lblBat.Text = "Battery";
            this.lblBat.Visible = false;
            // 
            // GPSControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.splitContainer1);
            this.Name = "GPSControl";
            this.Size = new System.Drawing.Size(853, 457);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGPS;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblOil;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.Label lblFuelpct;
        private System.Windows.Forms.Label lblOilpct;
        private System.Windows.Forms.ProgressBar fuelProgressBar;
        private System.Windows.Forms.ProgressBar oilProgressBar;
        private System.Windows.Forms.Label lblMiles;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.Label lblOilMiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBatMiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar batProgressBar;
        private System.Windows.Forms.Label lblBatpct;
        private System.Windows.Forms.Label lblBat;
    }
}
