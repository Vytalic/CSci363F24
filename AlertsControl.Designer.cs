namespace RemoteVehicleManager
{
    partial class AlertsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertsControl));
            this.lblAlerts = new System.Windows.Forms.Label();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
            this.lblWhen = new System.Windows.Forms.Label();
            this.lblWhat = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClearAlerts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAlerts
            // 
            this.lblAlerts.AutoSize = true;
            this.lblAlerts.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlerts.Location = new System.Drawing.Point(636, 0);
            this.lblAlerts.Name = "lblAlerts";
            this.lblAlerts.Size = new System.Drawing.Size(217, 55);
            this.lblAlerts.TabIndex = 0;
            this.lblAlerts.Text = "ALERTS";
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortBy.Location = new System.Drawing.Point(72, 22);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(68, 21);
            this.lblSortBy.TabIndex = 1;
            this.lblSortBy.Text = "Sort By:";
            // 
            // comboBoxSortBy
            // 
            this.comboBoxSortBy.AllowDrop = true;
            this.comboBoxSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSortBy.FormattingEnabled = true;
            this.comboBoxSortBy.Items.AddRange(new object[] {
            "Newest",
            "Oldest"});
            this.comboBoxSortBy.Location = new System.Drawing.Point(143, 21);
            this.comboBoxSortBy.Name = "comboBoxSortBy";
            this.comboBoxSortBy.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSortBy.TabIndex = 2;
            this.comboBoxSortBy.TabStop = false;
            this.comboBoxSortBy.SelectedIndexChanged += new System.EventHandler(this.comboBoxSortBy_SelectedIndexChanged);
            // 
            // lblWhen
            // 
            this.lblWhen.AutoSize = true;
            this.lblWhen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhen.Location = new System.Drawing.Point(172, 89);
            this.lblWhen.Name = "lblWhen";
            this.lblWhen.Size = new System.Drawing.Size(85, 25);
            this.lblWhen.TabIndex = 3;
            this.lblWhen.Text = "When?";
            // 
            // lblWhat
            // 
            this.lblWhat.AutoSize = true;
            this.lblWhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhat.Location = new System.Drawing.Point(407, 89);
            this.lblWhat.Name = "lblWhat";
            this.lblWhat.Size = new System.Drawing.Size(79, 25);
            this.lblWhat.TabIndex = 4;
            this.lblWhat.Text = "What?";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "triangle-warning.png");
            this.imageList1.Images.SetKeyName(1, "octagon-exclamation.png");
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(75, 128);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(651, 304);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // btnClearAlerts
            // 
            this.btnClearAlerts.BackColor = System.Drawing.Color.LightCoral;
            this.btnClearAlerts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAlerts.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAlerts.Location = new System.Drawing.Point(732, 409);
            this.btnClearAlerts.Name = "btnClearAlerts";
            this.btnClearAlerts.Size = new System.Drawing.Size(109, 35);
            this.btnClearAlerts.TabIndex = 10;
            this.btnClearAlerts.Text = "Clear Alerts";
            this.btnClearAlerts.UseVisualStyleBackColor = false;
            this.btnClearAlerts.Click += new System.EventHandler(this.btnClearAlerts_Click);
            // 
            // AlertsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.btnClearAlerts);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblWhat);
            this.Controls.Add(this.lblWhen);
            this.Controls.Add(this.comboBoxSortBy);
            this.Controls.Add(this.lblSortBy);
            this.Controls.Add(this.lblAlerts);
            this.Name = "AlertsControl";
            this.Size = new System.Drawing.Size(853, 457);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlerts;
        private System.Windows.Forms.Label lblSortBy;
        private System.Windows.Forms.ComboBox comboBoxSortBy;
        private System.Windows.Forms.Label lblWhen;
        private System.Windows.Forms.Label lblWhat;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnClearAlerts;
    }
}
