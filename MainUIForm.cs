using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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
            var alerts = LoadAlerts("alertsData.txt");
            HighlightActiveButton((Button)sender);
            
            var alertsControl = new AlertsControl();
            alertsControl.DisplayAlerts(alerts);
            
            LoadControl(alertsControl);
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
                    button.BackColor = Color.LightSkyBlue;
                    button.ForeColor = SystemColors.ControlText;
                    button.FlatStyle = FlatStyle.Flat;
                }
            }

            // Highlight active button
            activeButton.BackColor = Color.Blue;
            activeButton.ForeColor = Color.White;
            activeButton.FlatStyle = FlatStyle.Standard;
        }

        private List<(DateTime DateTime, string Description, int Severity)>  LoadAlerts(string filePath)
        {
            var alerts = new List<(DateTime DateTime, string Description, int Severity)>();
            

            if (File.Exists(filePath))
            {
                // Read all lines in the file
                foreach (var line in File.ReadAllLines(filePath))
                {
                    var parts = line.Split(',');
                    
                    if (parts.Length == 3 
                        && DateTime.TryParse(parts[0], out var dateTime)
                        && int.TryParse(parts[2], out var severity))
                    {
                        alerts.Add((dateTime, parts[1], severity));
                    }
                }
            }
            else
            {
                File.WriteAllText("alertsData.txt",
                    "11/26/2024 8:30 PM,Fuel is less than 20%,0\n" +
                    "11/26/2024 2:43 AM,Break-in Detected!,1\n" +
                    "10/10/2024 6:31 PM,Low Oil Level,1\n" +
                    "10/02/2024 10:11 AM,Vehicle Outside of Geofence,0\n" +
                    "7/29/2024 1:58 PM,Windows left open,0");

                // Read all lines in the file
                foreach (var line in File.ReadAllLines(filePath))
                {
                    var parts = line.Split(',');
                    if (parts.Length == 3
                        && DateTime.TryParse(parts[0], out var dateTime)
                        && int.TryParse(parts[2], out var severity))
                    {
                        alerts.Add((dateTime, parts[1], severity));
                    }
                }
            }

            // Sort alerts by oldest
            //alerts.Sort((a, b) => a.DateTime.CompareTo(b.DateTime));

            // Sort alerts by most recent
            alerts.Sort((a, b) => b.DateTime.CompareTo(a.DateTime));

            return alerts;
        }


    }
}
