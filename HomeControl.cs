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
    public partial class HomeControl : UserControl
    {
        public HomeControl()
        {
            InitializeComponent();
            this.Load += HomeControl_Load;

            // Attach click events to buttons
            btnStartEngine.Click += btnStartEngine_Click;
            btnStopEngine.Click += btnStopEngine_Click;

            btnStartEngine.Click -= btnStartEngine_Click;
            btnStopEngine.Click -= btnStopEngine_Click;
        }

        private void HomeControl_Load(object sender, EventArgs e)
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
                if (control is Button)
                {
                    control.ForeColor = Color.Black;
                }
                else
                {
                    control.BackColor = backgroundColor;
                    control.ForeColor = textColor;  
                }

            }

            if (SettingsManager.Theme == "Dark")
            {
                panel1.BackColor = Color.White;
                panel2.BackColor = Color.White;
            }
            else if (SettingsManager.Theme == "Light")
            {
                panel1.BackColor = Color.Black;
                panel2.BackColor = Color.Black;
            }
        }

        private void btnStartEngine_Click(object sender, EventArgs e)
        {
            // Update lblEngineStatus for engine start
            lblEngineStatus.Text = "(Started)";
            lblEngineStatus.ForeColor = Color.Green;

            // Show popup message
            MessageBox.Show("Engine started successfully!", "Engine Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        

        private void btnStopEngine_Click(object sender, EventArgs e)
        {
            // Update lblEngineStatus for engine stop
            lblEngineStatus.Text = "(Stopped)";
            lblEngineStatus.ForeColor = Color.Red;

            // Show popup message
            MessageBox.Show("Engine stopped successfully!", "Engine Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
