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

        // Loads Home tab on click
        private void home_tab_Click(object sender, EventArgs e)
        {
            HighlightActiveButton((Button)sender);
            LoadControl(new HomeControl());
        }

        // Loads Drivers tab on click
        private void drivers_tab_Click(object sender, EventArgs e)
        {
            HighlightActiveButton((Button)sender); 
            LoadControl(new DriversControl());
        }

        // Loads Vehicles tab on click
        private void vehicles_tab_Click(object sender, EventArgs e)
        {
            HighlightActiveButton((Button)sender); 
            LoadControl(new VehiclesControl());
        }

        // Loads GPS tab on click
        private void gps_tab_Click(object sender, EventArgs e)
        {
            HighlightActiveButton((Button)sender); 
            LoadControl(new GPSControl());
        }

        // Loads Alerts tab on click
        private void alerts_tab_Click(object sender, EventArgs e)
        {
            HighlightActiveButton((Button)sender); 
            LoadControl(new AlertsControl());
        }

        // Loads History tab on click
        private void history_tab_Click(object sender, EventArgs e)
        {
            HighlightActiveButton((Button)sender); 
            LoadControl(new HistoryControl());
        }

        // Loads Settings tab on click
        private void settings_tab_Click(object sender, EventArgs e)
        {
            HighlightActiveButton((Button)sender); 
            LoadControl(new SettingsControl());
        }

        private void HighlightActiveButton(Button activeButton)
        {
            // Reset all buttons appearances
            foreach (Control control in SidePanel.Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = SystemColors.Control;
                    button.ForeColor = SystemColors.ControlText;
                    button.FlatStyle = FlatStyle.Flat;
                }
            }

            // Highlight active button
            activeButton.BackColor = Color.DarkCyan;
            activeButton.ForeColor = Color.White;
            activeButton.FlatStyle = FlatStyle.Standard;
        }
    }
}
