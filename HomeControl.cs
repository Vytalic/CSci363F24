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

            btnActivateAlarm.Click += btnActivateAlarm_Click;
            btnActivateAlarm.Click -= btnActivateAlarm_Click;

            btnDeactivateAlarm.Click += BtnDeactivateAlarm_Click;
            btnDeactivateAlarm.Click -= BtnDeactivateAlarm_Click;

            btnLockDoor.Click += BtnLockDoor_Click;
            btnLockDoor.Click -= BtnLockDoor_Click;

            btnUnlockDoor.Click += BtnUnlockDoor_Click;
            btnUnlockDoor.Click -= BtnUnlockDoor_Click;

            btnOpenWindows.Click += BtnOpenWindows_Click;
            btnOpenWindows.Click -= BtnOpenWindows_Click;

            btnCloseWindows.Click += BtnCloseWindows_Click;
            btnCloseWindows.Click -= BtnCloseWindows_Click;
        }

        private void BtnCloseWindows_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnOpenWindows_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnUnlockDoor_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnLockDoor_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnDeactivateAlarm_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
                else if (control.Name != "panel3" && control.Name != "panel4")
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
            lblEngineStatus.Visible = true;
            lblEngineStatus.Text = "(Started)";
            lblEngineStatus.ForeColor = Color.Green;
            lblEngineStatus.Font = new Font(lblEngineStatus.Font.FontFamily, 16, lblEngineStatus.Font.Style);

            // Show popup message
            MessageBox.Show("Engine started successfully!", "Engine Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        

        private void btnStopEngine_Click(object sender, EventArgs e)
        {
            // Update lblEngineStatus for engine stop
            lblEngineStatus.Visible = true;
            lblEngineStatus.Text = "(Stopped)";
            lblEngineStatus.ForeColor = Color.Red;
            lblEngineStatus.Font = new Font(lblEngineStatus.Font.FontFamily, 16, lblEngineStatus.Font.Style);



            // Show popup message
            MessageBox.Show("Engine stopped successfully!", "Engine Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnActivateAlarm_Click(object sender, EventArgs e)
        {
            // Update lblEngineStatus for engine start
            lblAlarmStatus.Visible = true;
            lblAlarmStatus.Text = "(Activated)";
            lblAlarmStatus.ForeColor = Color.Green;
            lblAlarmStatus.Font = new Font(lblAlarmStatus.Font.FontFamily, 16, lblAlarmStatus.Font.Style);


            // Show popup message
            MessageBox.Show("Alarm activated successfully!", "Alarm Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeactivateAlarm_Click(object sender, EventArgs e)
        {
            // Update lblEngineStatus for engine start
            lblAlarmStatus.Visible = true;
            lblAlarmStatus.Text = "(Deactivated)";
            lblAlarmStatus.ForeColor = Color.Red;
            lblAlarmStatus.Font = new Font(lblAlarmStatus.Font.FontFamily, 16, lblAlarmStatus.Font.Style);


            // Show popup message
            MessageBox.Show("Alarm deactivated successfully!", "Alarm Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLockDoor_Click(object sender, EventArgs e)
        {
            lblDoorsStatus.Visible = true;
            lblDoorsStatus.Text = "(Locked)";
            lblDoorsStatus.ForeColor = Color.Green;
            lblDoorsStatus.Font = new Font(lblDoorsStatus.Font.FontFamily, 16, lblDoorsStatus.Font.Style);


            // Show popup message
            MessageBox.Show("Doors locked successfully!", "Door Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUnlockDoor_Click(object sender, EventArgs e)
        {
            lblDoorsStatus.Visible = true;
            lblDoorsStatus.Text = "(Unlocked)";
            lblDoorsStatus.ForeColor = Color.Red;
            lblDoorsStatus.Font = new Font(lblDoorsStatus.Font.FontFamily, 16, lblDoorsStatus.Font.Style);


            // Show popup message
            MessageBox.Show("Doors unlocked successfully!", "Door Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOpenWindows_Click(object sender, EventArgs e)
        {
            lblWindowsStatus.Visible = true;
            lblWindowsStatus.Text = "(Open)";
            lblWindowsStatus.ForeColor = Color.Green;
            lblWindowsStatus.Font = new Font(lblWindowsStatus.Font.FontFamily, 16, lblWindowsStatus.Font.Style);


            // Show popup message
            MessageBox.Show("Windows opened successfully!", "Windows Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCloseWindows_Click(object sender, EventArgs e)
        {
            lblWindowsStatus.Visible = true;
            lblWindowsStatus.Text = "(Closed)";
            lblWindowsStatus.ForeColor = Color.Red;
            lblWindowsStatus.Font = new Font(lblWindowsStatus.Font.FontFamily, 16, lblWindowsStatus.Font.Style);


            // Show popup message
            MessageBox.Show("Windows closed successfully!", "Windows Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel sidepanel = ParentForm.Controls.Find("SidePanel", true).FirstOrDefault() as Panel;
            if (sidepanel != null)
            {
                sidepanel.Enabled = true;
            }
            panel3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Panel sidepanel = ParentForm.Controls.Find("SidePanel", true).FirstOrDefault() as Panel;
            if (sidepanel != null)
            {
                sidepanel.Enabled = true;
            }

            Button btnAlerts = ParentForm.Controls.Find("Alerts_tab", true).FirstOrDefault() as Button;
            if (btnAlerts != null)
            {
                btnAlerts.PerformClick();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Panel sidepanel = ParentForm.Controls.Find("SidePanel", true).FirstOrDefault() as Panel;
            if (sidepanel != null)
            {
                sidepanel.Enabled = true;
            }

            Button btnAlerts = ParentForm.Controls.Find("Alerts_tab", true).FirstOrDefault() as Button;
            if (btnAlerts != null)
            {
                btnAlerts.PerformClick();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Panel sidepanel = ParentForm.Controls.Find("SidePanel", true).FirstOrDefault() as Panel;
            if (sidepanel != null)
            {
                sidepanel.Enabled = true;
            }
            panel4.Visible = false;
        }
    }
}
