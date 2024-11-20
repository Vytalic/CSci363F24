using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteVehicleManager
{
    public partial class SettingsControl : UserControl
    {
        public SettingsControl()
        {
            InitializeComponent();

            // Variables to hold settings
            string fontSize = "Medium";
            string temperature = "Fahrenheit";
            string theme = "Dark";
            string timeFormat = "12-Hour";
            string updateFrequency = "Daily";
            string vibration = "Off";

            if (File.Exists("settingsData.txt"))
            {
                // Read all lines in the file
                // where the file structure is: fontsize,temperature,theme,timeformat,updatefrequency,vibrationfeedback
                foreach (var line in File.ReadAllLines("settingsData.txt"))
                {
                    var parts = line.Split(',');
                    
                    if (parts.Length == 6)
                    {
                        fontSize = parts[0];
                        temperature = parts[1];
                        theme = parts[2];
                        timeFormat = parts[3];
                        updateFrequency = parts[4];
                        vibration = parts[5];
                    }
                    
                }
            }
            else
            {
                // Initialize settings to default value if file does not exist
                InitializeSettings();
            }
                
        }

        private void InitializeSettings()
        {
            // Write the default values to a file
            var defaultSettings = "Medium,Fahrenheit,Dark,12-Hour,Daily,Off";
            File.WriteAllText("settingsData.txt", defaultSettings);

            cbFontSize.SelectedItem = "Medium";
            cbTemperature.SelectedItem = "Fahrenheit";
            cbTheme.SelectedItem = "Dark";
            cbTimeFormat.SelectedItem = "12-Hour";
            cbUpdateFrequency.SelectedItem = "Daily";
            cbVibration.SelectedItem = "Off";
        }
    }
}
