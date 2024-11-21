using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteVehicleManager
{
    public partial class GPSControl : UserControl
    {
        public GPSControl()
        {
            InitializeComponent();
            this.Load += GPSControl_Load;
        }

        private void GPSControl_Load(object sender, EventArgs e)
        {
            ApplySettings();
        }

        public void ApplySettings()
        {
            // Determine theme colors
            Color backgroundColor = SettingsManager.Theme == "Dark" ? Color.FromArgb(40, 40, 40) : Color.DarkGray;
            Color textColor = SettingsManager.Theme == "Dark" ? Color.White : Color.Black;

            this.BackColor = backgroundColor;

            // Apply to all other controls
            foreach (Control control in this.Controls)
            {
                if (control.Name != "placeholder")
                {
                    control.BackColor = backgroundColor;
                    control.ForeColor = textColor;
                }

            }
        }
    }
}
