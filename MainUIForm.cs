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
    public partial class MainUIForm : Form
    {
        public MainUIForm()
        {
            InitializeComponent();
        }

        private void MainUIForm_Load(object sender, EventArgs e)
        {
            // Display current date
            lblCurrentDate.Text = DateTime.Now.ToString("MMMM dd, yyyy");

            // Set initial time
            lblCurrentTime.Text = DateTime.Now.ToString("h:mm:ss tt");

            // Start timer for updating time
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            // Update timer each second
            lblCurrentTime.Text = DateTime.Now.ToString("h:mm:ss tt");
        }

        private void LoadControl(UserControl control)
        {
            // Clear existing controls
            MainContent.Controls.Clear();

            // Set new controls
            control.Dock = DockStyle.Fill;

            // Add new control
            MainContent.Controls.Add(control);


        }

        private void home_tab_Click(object sender, EventArgs e)
        {
            LoadControl(new HomeControl());
        }

        private void drivers_tab_Click(object sender, EventArgs e)
        {
            LoadControl(new DriversControl());
        }

        private void vehicles_tab_Click(object sender, EventArgs e)
        {

        }

        private void gps_tab_Click(object sender, EventArgs e)
        {

        }

        private void alerts_tab_Click(object sender, EventArgs e)
        {

        }

        private void history_tab_Click(object sender, EventArgs e)
        {

        }

        private void settings_tab_Click(object sender, EventArgs e)
        {

        }
    }
}
