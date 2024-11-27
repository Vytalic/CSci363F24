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
        // Class variables
        private int currentTemperature; // Store the current temperature
        private int tickCounter = 0;    // Counter to track Timer1 ticks
        private Random random = new Random(); // Random object for generating random values
        private HomeControl homeControl;

        public MainUIForm()
        {
            InitializeComponent();
            homeControl = new HomeControl();
            LoadControl (homeControl);
            HighlightActiveButton(home_tab);
            ApplySettings();
            InitializeTemperature();
            ReadFirstVehicle();
        }

        private void MainUIForm_Load(object sender, EventArgs e)
        {
            // Load settings
            SettingsManager.LoadSettings("settingsData.txt");

            // Disable until user selects a vehicle
            MainContent.Enabled = true;
            SidePanel.Enabled = true;

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
            if (SettingsManager.TimeFormat == "12-Hour")
            {
                lblCurrentTime.Text = DateTime.Now.ToString("h:mm tt");
            }
            else if (SettingsManager.TimeFormat == "24-Hour")
            {
                lblCurrentTime.Text = DateTime.Now.ToString("HH:mm");
            }


            // Start timer for updating time
            timer1.Tick += Timer1_Tick;
            timer1.Start();

            // Ensure alertsData is created
            var alerts = new List<(DateTime DateTime, string Description, int Severity)>();
            if (File.Exists("alertsData.txt"))
            {
                // Read all lines in the file
                foreach (var line in File.ReadAllLines("alertsData.txt"))
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
                foreach (var line in File.ReadAllLines("alertsData.txt"))
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

        }

        public string AVName
        {
            get => lblAVName.Text; // Get the text of lblAVName
            set => lblAVName.Text = value; // Set the text of lblAVName
        }

        public string AVType
        {
            get => lblAVType.Text; // Get the text of lblAVType
            set => lblAVType.Text = value; // Set the text of lblAVType
        }

        private void InitializeTemperature()
        {
            // Generate a random temperature between 32 and 105
            currentTemperature = random.Next(32, 106);

            if (SettingsManager.Temperature == "Fahrenheit")
            {
                lblInsideT.Text = $"{currentTemperature}° F";
                lblOutsideT.Text = $"{currentTemperature - 5}° F";
            }
            else
            {
                int celsiusTemperature = (int)((currentTemperature - 32) * (5.0 / 9.0)); // Convert to Celsius
                lblInsideT.Text = $"{celsiusTemperature}° C";
                lblOutsideT.Text = $"{celsiusTemperature - 3}° C";
            }
        }





        private void Timer1_Tick(object sender, EventArgs e)
        {
            // Update time each second
            if (SettingsManager.TimeFormat == "12-Hour")
            {
                lblCurrentTime.Text = DateTime.Now.ToString("h:mm tt");
            }
            else if (SettingsManager.TimeFormat == "24-Hour")
            {
                lblCurrentTime.Text = DateTime.Now.ToString("HH:mm");
            }

            // Increment the tick counter
            tickCounter++;

            // Check if the counter has reached 3
            if (tickCounter >= 3)
            {
                // Randomly decide to increase or decrease the temperature
                int temperatureChange = random.Next(0, 2) == 0 ? -5 : 5;
                currentTemperature += temperatureChange; // Update the temperature in Fahrenheit

                // Update the label based on the temperature unit
                if (SettingsManager.Temperature == "Fahrenheit")
                {
                    lblInsideT.Text = $"{currentTemperature}° F";
                    lblOutsideT.Text = $"{currentTemperature - 5}° F";
                }
                else
                {
                    int celsiusTemperature = (int)((currentTemperature - 32) * (5.0 / 9.0)); // Convert to Celsius
                    lblInsideT.Text = $"{celsiusTemperature}° C";
                    lblOutsideT.Text = $"{celsiusTemperature - 3}° C";
                }

                // Reset the counter
                tickCounter = 0;
            }
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

        public void ReadFirstVehicle()
        {
            try
            {
                // Check if the file exists before attempting to read
                if (File.Exists("vehiclesData.txt"))
                {
                    // Only write from first line
                    foreach (var line in File.ReadLines("vehiclesData.txt"))
                    {
                        string[] parts = line.Split(',');

                        // Remove  spaces from last part
                        string part0 = parts[0];
                        string part1 = parts[1];
                        string part2 = parts[2].Trim().Replace(" ", "");

                        
                        lblAVName.Text = part0;
                        lblAVType.Text = part1;

                        File.WriteAllText("fuelType.txt", part2);

                        break;
                    }
                    
                }
                else
                {
                    
                    // Create the file with default data if it doesn't exist
                    File.WriteAllText("vehiclesData.txt",
                        "Vehicle 1, 2023 Toyota Corolla, Hybrid\n" +
                        "Vehicle 2, 2019 Ford F-150, Petro-fuel\n" +
                        "Vehicle 3, 2022 Tesla Model 3, Electric");

                    // Only write from first line
                    foreach (var line in File.ReadLines("vehiclesData.txt"))
                    {
                        string[] parts = line.Split(',');

                        // Remove  spaces from last part
                        string part0 = parts[0];
                        string part1 = parts[1];
                        string part2 = parts[2].Trim().Replace(" ", "");


                        lblAVName.Text = part0;
                        lblAVType.Text = part1;

                        File.WriteAllText("fuelType.txt", part2);

                        break;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while reading the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadControl(UserControl control)
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
            LoadControl(new VehiclesControl(this));
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (homeControl != null)
            {
                
                //homeControl.DestroyDisabledPanel();
                SidePanel.Enabled = true;
                MainContent.Enabled = true;
                vehicles_tab.PerformClick();
                //SidePanel.Enabled = false;
            }
        }

        public void sidepanelActivate()
        {
            SidePanel.Enabled = true;
            MainContent.Enabled = true;
        }

        public void disableButton1()
        {
            button1.Visible = false;
            button1.Enabled = false;
        }
    }
}