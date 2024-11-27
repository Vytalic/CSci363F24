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
    public partial class GPSControl : UserControl
    {
        private Timer fuelTimer; // Timer to update the fuel percentage
        private Random random; // Random number generator

        public GPSControl()
        {
            InitializeComponent();
            this.Load += GPSControl_Load;
        }

        private void GPSControl_Load(object sender, EventArgs e)
        {
            ApplySettings();
            InitializeGPS();
            StartFuelUpdate();
            checkBattery();
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

        private void InitializeGPS()
        {
            panel1.BorderStyle = BorderStyle.FixedSingle;
        }



        private void StartFuelUpdate()
        {
            random = new Random(); // Initialize the random number generator

            // Call FuelTimer_Tick immediately once
            FuelTimer_Tick(this, EventArgs.Empty);

            // Configure the timer
            fuelTimer = new Timer
            {
                Interval = 3000 // 3 seconds
            };
            fuelTimer.Tick += FuelTimer_Tick; // Attach the Tick event
            fuelTimer.Start(); // Start the timer
        }


        private void FuelTimer_Tick(object sender, EventArgs e)
        {
            int fuelPercentage = random.Next(10, 101); // Generate a random number between 10 and 100
            int oilPercentage = random.Next(10, 101); // Generate a random number between 10 and 100
            int batPercentage = random.Next(10, 101); // Generate a random number between 10 and 100

            lblMiles.Text = $"{fuelPercentage * 4} miles";
            lblFuelpct.Text = $"{fuelPercentage} %"; // Update the label text
            
            lblOilpct.Text = $"{oilPercentage} %";
            lblOilMiles.Text = $"{oilPercentage * 25} miles";
            
            lblBatpct.Text = $"{batPercentage} %"; // Update the label text
            lblBatMiles.Text = $"{batPercentage * 4} miles";


            // Set the text color based on the value
            if (fuelPercentage <= 20)
            {
                lblFuelpct.ForeColor = Color.Red; // Red for below 20
            }
            else if (fuelPercentage <= 50)
            {
                lblFuelpct.ForeColor = Color.Yellow; // Yellow for below 50
            }
            else
            {
                if (SettingsManager.Theme == "Dark")
                {
                    lblFuelpct.ForeColor = Color.PaleGreen; // Green for 50 and above
                }
                else
                {
                    lblFuelpct.ForeColor = Color.Green; // Green for 50 and above

                }
            }

            // Set the text color based on the value
            if (oilPercentage <= 20)
            {
                lblOilpct.ForeColor = Color.Red;
            }
            else if (oilPercentage <= 50)
            {
                lblOilpct.ForeColor = Color.Yellow;
            }
            else
            {
                if (SettingsManager.Theme == "Dark")
                {
                    lblOilpct.ForeColor = Color.PaleGreen;
                }
                else
                {
                    lblOilpct.ForeColor = Color.Green;
                }
            }

            // Set the text color based on the value
            if (batPercentage <= 20)
            {
                lblBatpct.ForeColor = Color.Red;
            }
            else if (batPercentage <= 50)
            {
                lblBatpct.ForeColor = Color.Yellow;
            }
            else
            {
                if (SettingsManager.Theme == "Dark")
                {
                    lblBatpct.ForeColor = Color.PaleGreen;
                }
                else
                {
                    lblBatpct.ForeColor = Color.Green;
                }
            }


            // Update the ProgressBar value
            fuelProgressBar.Value = fuelPercentage;
            oilProgressBar.Value = oilPercentage;
            batProgressBar.Value = batPercentage;

           
        }

        private void checkBattery()
        {
            string fuelType = ReadFuelTypeFromFile();
            if (fuelType == "Hybrid")
            {
                // Make Fuel Visible
                lblFuel.Visible = true;
                fuelProgressBar.Visible = true;
                lblFuelpct.Visible = true;
                lblRemaining.Visible = true;
                lblMiles.Visible = true;

                // Make Battery Visible
                lblBat.Visible=true;
                batProgressBar.Visible=true;
                lblBatpct.Visible=true;
                label3.Visible=true;
                lblBatMiles.Visible=true;
            }
            else if (fuelType == "Petro-fuel")
            {
                // Make Fuel Visible
                lblFuel.Visible = true;
                fuelProgressBar.Visible = true;
                lblFuelpct.Visible = true;
                lblRemaining.Visible = true;
                lblMiles.Visible = true;

                // Hide Battery
                lblBat.Visible = false;
                batProgressBar.Visible = false;
                lblBatpct.Visible = false;
                label3.Visible = false;
                lblBatMiles.Visible = false;
            }
            else if (fuelType == "Electric")
            {
                // Make Battery Visible
                lblBat.Visible = true;
                batProgressBar.Visible = true;
                lblBatpct.Visible = true;
                label3.Visible = true;
                lblBatMiles.Visible = true;

                // Hide Fuel
                lblFuel.Visible = false;
                fuelProgressBar.Visible = false;
                lblFuelpct.Visible = false;
                lblRemaining.Visible = false;
                lblMiles.Visible = false;
            }
        }

        public static string ReadFuelTypeFromFile()
        {
            try
            {
                // Check if the file exists before attempting to read
                if (File.Exists("fuelType.txt"))
                {
                    string fuelType = File.ReadAllText("fuelType.txt");
                    return fuelType;
                }
                else
                {
                    MessageBox.Show($"The file {"fuelType.txt"} does not exist.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while reading the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

    }
}
