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
            LoadControl(new HomeControl());
            HighlightActiveButton(home_tab);
            ApplySettings();
        }

        private void MainUIForm_Load(object sender, EventArgs e)
        {
            // Load settings
            SettingsManager.LoadSettings("settingsData.txt");

            // Apply settings to MainUIForm
            ApplySettings();

            // Apply settings to initial UI controls
            foreach (Control control in MainContent.Controls)
            {
                if (control is HistoryControl historyControl)
                {
                    historyControl.ApplySettings();
                }
                else if (control is AlertsControl alertControl)
                {
                    alertControl.ApplySettings();
                }
                else if (control is DriversControl driverControl)
                {
                    driverControl.ApplySettings();
                }
                else if (control is HomeControl homeControl)
                {
                    homeControl.ApplySettings();
                }
                else if (control is SettingsControl settingsControl)
                {
                    settingsControl.ApplySettings();
                }
            }

            

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

        public void ApplySettings()
        {
            if (SettingsManager.Theme == "Dark")
            {
                
                SidePanel.ForeColor = Color.White;
                SidePanel.BackColor = Color.FromArgb(40, 40, 40);
                TopPanel.ForeColor = Color.White;
                TopPanel.BackColor = Color.FromArgb(40, 40, 40);

                HorizontalBar.BackColor = Color.White;
                VerticalBar.BackColor = Color.White;

                splitContainer1.BackColor = SidePanel.BackColor;

                panel1.BackColor = Color.White;
                panel2.BackColor = Color.White;

                foreach(Button button in SidePanel.Controls)
                {
                    button.BackColor = Color.MidnightBlue;
                    button.ForeColor = Color.White;
                    button.ImageList = drkIcons;
                }

            }
            else if (SettingsManager.Theme == "Light")
            {
                SidePanel.ForeColor = Color.Black;
                SidePanel.BackColor = Color.DarkGray;
                TopPanel.ForeColor = Color.Black;
                TopPanel.BackColor = Color.DarkGray;

                HorizontalBar.BackColor = Color.Black;
                VerticalBar.BackColor = Color.Black;

                splitContainer1.BackColor = SidePanel.BackColor;

                panel1.BackColor = Color.Black;
                panel2.BackColor = Color.Black;

                foreach (Button button in SidePanel.Controls)
                {
                    button.BackColor = Color.LightSkyBlue;
                    button.ForeColor = Color.Black;
                    button.ImageList = imageList2;
                }
            }
        }

        //public void ApplySettings()
        //{
        //    // Apply Dark Theme
        //    if (SettingsManager.Theme == "Dark")
        //    {
                
        //        foreach (Control control in this.Controls)
        //        {
        //            control.ForeColor = Color.White;
        //            this.BackColor = Color.FromArgb(40, 40, 40);
        //        }
        //    }
        //    else // Apply Light Theme
        //    {
                
        //        foreach (Control control in this.Controls)
        //        {
        //            control.ForeColor = Color.Black;
        //            this.BackColor = Color.DarkGray;
        //        }
        //    }

        //    // Apply fontsize to labels
        //    float fontSize = 12;
        //    switch (SettingsManager.FontSize.ToLower())
        //    {
        //        case "small":
        //            fontSize = 10;
        //            break;
        //        case "medium":
        //            fontSize = 12;
        //            break;
        //        case "large":
        //            fontSize = 14;
        //            break;
        //        default:
        //            fontSize = 12;
        //            break;
        //    }

        //    foreach (Control control in this.Controls)
        //    {
        //        if (control is Label label)
        //        {
        //            label.Font = new Font(label.Font.FontFamily, fontSize);
        //        }
        //    }

        //}

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
        public void home_tab_Click(object sender, EventArgs e)
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
            
            var settingsControl = new SettingsControl();
            settingsControl.SettingsUpdated += SettingsControl_SettingsUpdated;
            
            LoadControl(settingsControl);
        }

        // Handles events to apply updated settings
        private void SettingsControl_SettingsUpdated(object sender, EventArgs e)
        {
            // Apply settings to MainUIForm
            ApplySettings();

            // Apply settings to other active controls
            foreach (Control control in MainContent.Controls)
            {
                if (control is HistoryControl historyControl)
                {
                    historyControl.ApplySettings();
                }
                else if (control is AlertsControl alertControl)
                {
                    alertControl.ApplySettings();
                }
                else if (control is DriversControl driverControl)
                {
                    driverControl.ApplySettings();
                }
                else if (control is HomeControl homeControl)
                {
                    homeControl.ApplySettings();
                }
                else if (control is VehiclesControl vehiclesControl)
                {
                    vehiclesControl.ApplySettings();
                }
                else if (control is GPSControl gpsControl)
                {
                    gpsControl.ApplySettings();
                }
                else if (control is SettingsControl settingsControl)
                {
                    settingsControl.ApplySettings();
                }
            }
        }

        private void HighlightActiveButton(Button activeButton)
        {
            // Reset all buttons appearances
            foreach (Control control in SidePanel.Controls)
            {
                if (control is Button button && button.Name != "btnTest")
                {
                    if (SettingsManager.Theme == "Dark")
                    {
                        button.BackColor = Color.MidnightBlue;
                        button.ForeColor = Color.White;
                        button.FlatStyle = FlatStyle.Standard;

                        button.ImageList = drkIcons;
                    }
                    else if (SettingsManager.Theme == "Light")
                    {
                       button.BackColor = Color.LightSkyBlue;
                       button.ForeColor = Color.Black;
                       button.FlatStyle = FlatStyle.Flat;

                        button.ImageList = imageList2;
                    }
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

        private void btnTest_Click(object sender, EventArgs e)
        {
            // Create and show the simulation screen
            TestForm testForm = new TestForm(this);
            testForm.Show();
        }
    }
}