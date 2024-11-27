namespace RemoteVehicleManager
{
    partial class HistoryControl
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
            this.lblHistory = new System.Windows.Forms.Label();
            this.lblShowFrom = new System.Windows.Forms.Label();
            this.comboBoxShowFrom = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistory.Location = new System.Drawing.Point(496, 0);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(357, 55);
            this.lblHistory.TabIndex = 0;
            this.lblHistory.Text = "APP HISTORY";
            // 
            // lblShowFrom
            // 
            this.lblShowFrom.AutoSize = true;
            this.lblShowFrom.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowFrom.Location = new System.Drawing.Point(47, 22);
            this.lblShowFrom.Name = "lblShowFrom";
            this.lblShowFrom.Size = new System.Drawing.Size(99, 21);
            this.lblShowFrom.TabIndex = 1;
            this.lblShowFrom.Text = "Show From:";
            // 
            // comboBoxShowFrom
            // 
            this.comboBoxShowFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShowFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxShowFrom.FormattingEnabled = true;
            this.comboBoxShowFrom.Items.AddRange(new object[] {
            "Today",
            "Last Week",
            "Last Month",
            "Last Reset",
            "Installation Date"});
            this.comboBoxShowFrom.Location = new System.Drawing.Point(147, 19);
            this.comboBoxShowFrom.Name = "comboBoxShowFrom";
            this.comboBoxShowFrom.Size = new System.Drawing.Size(149, 28);
            this.comboBoxShowFrom.TabIndex = 2;
            this.comboBoxShowFrom.SelectedIndexChanged += new System.EventHandler(this.comboBoxShowFrom_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(82, 99);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(651, 336);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // HistoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.comboBoxShowFrom);
            this.Controls.Add(this.lblShowFrom);
            this.Controls.Add(this.lblHistory);
            this.Name = "HistoryControl";
            this.Size = new System.Drawing.Size(853, 457);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.Label lblShowFrom;
        private System.Windows.Forms.ComboBox comboBoxShowFrom;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
