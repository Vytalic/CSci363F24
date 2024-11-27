using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RemoteVehicleManager
{
    public partial class TestForm : Form
    {
        // Keep reference to the main form
        private MainUIForm mainForm;

        public TestForm(MainUIForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

            
        private void button1_Click(object sender, EventArgs e)
        {
            string currentTime = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");

            string alertMessage = $"{currentTime},Break-in Detected! Doors opened,1";

            File.AppendAllText("alertsData.txt", Environment.NewLine + alertMessage);


            Button btnHome = mainForm.Controls.Find("Home_tab", true).FirstOrDefault() as Button;
            if (btnHome != null)
            {
                btnHome.PerformClick();
            }

            Panel alertPanel = mainForm.Controls.Find("panel3", true).FirstOrDefault() as Panel;
            if (alertPanel != null)
            {
                alertPanel.Visible = true;
                
            }

            Panel sidepanel = mainForm.Controls.Find("SidePanel", true).FirstOrDefault() as Panel;
            if (sidepanel != null)
            {
                sidepanel.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button alertsTab = mainForm.Controls.Find("alerts_tab", true).FirstOrDefault() as Button;

            string currentTime = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");

            string alertMessage = $"{currentTime},Fuel is less than 20%,0";

            File.AppendAllText("alertsData.txt", Environment.NewLine + alertMessage);
            if (alertsTab != null)
            {
                alertsTab.PerformClick();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button alertsTab = mainForm.Controls.Find("alerts_tab", true).FirstOrDefault() as Button;

            string currentTime = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");

            string alertMessage = $"{currentTime},Battery is less than 20%,0";

            File.AppendAllText("alertsData.txt", Environment.NewLine + alertMessage);
            if (alertsTab != null)
            {
                alertsTab.PerformClick();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Button alertsTab = mainForm.Controls.Find("alerts_tab", true).FirstOrDefault() as Button;

            string currentTime = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");

            string alertMessage = $"{currentTime},Vehicle is outside the Geofence,0";

            File.AppendAllText("alertsData.txt", Environment.NewLine + alertMessage);
            if (alertsTab != null)
            {
                alertsTab.PerformClick();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button alertsTab = mainForm.Controls.Find("alerts_tab", true).FirstOrDefault() as Button;

            string currentTime = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");

            string alertMessage = $"{currentTime},Windows are still open,0";

            File.AppendAllText("alertsData.txt", Environment.NewLine + alertMessage);
            if (alertsTab != null)
            {
                alertsTab.PerformClick();
            }
        }
    }
}
