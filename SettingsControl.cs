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
        private Dictionary<ComboBox, PictureBox> comboBoxToPictureBoxMap;
        private Dictionary<ComboBox, string> originalSettings;
        private Dictionary<ComboBox, bool> unsavedStatus;
        private int unsavedChangesCount;



        public SettingsControl()
        {
            InitializeComponent();
            this.Load += SettingsControl_Load;

            // Construct the dictionary containing original settings
            originalSettings = new Dictionary<ComboBox, string>
            {
                { cbFontSize, string.Empty },
                { cbTemperature, string.Empty },
                { cbTheme, string.Empty },
                { cbTimeFormat, string.Empty },
                { cbUpdateFrequency, string.Empty },
                { cbVibration, string.Empty }
            };

            // Initialize change status in comboboxes
            unsavedStatus = new Dictionary<ComboBox, bool>
{
                { cbFontSize, false },
                { cbTemperature, false },
                { cbTheme, false },
                { cbTimeFormat, false },
                { cbUpdateFrequency, false },
                { cbVibration, false }
            };


            // Map ComboBoxes to their corresponding PictureBoxes
            comboBoxToPictureBoxMap = new Dictionary<ComboBox, PictureBox>
            {
                { cbFontSize, picChangeFont },
                { cbTemperature, picChangeTemp },
                { cbTheme, picChangeTheme },
                { cbTimeFormat, picChangeTime },
                { cbUpdateFrequency, picChangeUpdate },
                { cbVibration, picChangeVibration }
            };


            // Attach event handlers to ComboBoxes
            foreach (var comboBox in comboBoxToPictureBoxMap.Keys)
            {
                comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            }

            // Initialize settings
            InitializeSettings();
        }

        public event EventHandler SettingsUpdated;

        private void InitializeSettings()
        {
            // Default values
            var defaultSettings = "Medium,Fahrenheit,Dark,12-Hour,Daily,Off";

            // Write defaults if file doesn't exist
            if (!File.Exists("settingsData.txt"))
            {
                File.WriteAllText("settingsData.txt", defaultSettings);
            }

            // Load settings
            var settings = File.ReadAllLines("settingsData.txt")[0].Split(',');

            // Apply to ComboBoxes and store originals
            originalSettings[cbFontSize] = settings[0];
            cbFontSize.SelectedItem = settings[0];

            originalSettings[cbTemperature] = settings[1];
            cbTemperature.SelectedItem = settings[1];

            originalSettings[cbTheme] = settings[2];
            cbTheme.SelectedItem = settings[2];

            originalSettings[cbTimeFormat] = settings[3];
            cbTimeFormat.SelectedItem = settings[3];

            originalSettings[cbUpdateFrequency] = settings[4];
            cbUpdateFrequency.SelectedItem = settings[4];

            originalSettings[cbVibration] = settings[5];
            cbVibration.SelectedItem = settings[5];

            // Clear pictureboxes and reset unsaved changes
            foreach (var pictureBox in comboBoxToPictureBoxMap.Values)
            {
                pictureBox.Image = null;
            }

            // Reset unsaved changes count and hide buttons
            unsavedChangesCount = 0;
            btnSaveChanges.Visible = false;
            btnCancel.Visible = false;
            UpdateUnsavedChangesUI();
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox comboBox && comboBoxToPictureBoxMap.TryGetValue(comboBox, out PictureBox pictureBox))
            {
                // Check if the value matches the original
                bool isUnsaved = comboBox.SelectedItem.ToString() != originalSettings[comboBox];

                if (isUnsaved != unsavedStatus[comboBox])
                {
                    // Update the unsaved status and count
                    unsavedStatus[comboBox] = isUnsaved;
                    unsavedChangesCount += isUnsaved ? 1 : -1;

                    // Update the PictureBox image
                    pictureBox.Image = isUnsaved
                        ? (SettingsManager.Theme == "Dark" ? Properties.Resources.unsaved : Properties.Resources.unsaved)
                        : null;
                }

                // Update the UI for all comboboxes to reflect their individual states
                UpdateAllPictureBoxes();

                // Update the main UI for unsaved changes
                UpdateUnsavedChangesUI();
            }
        }

        private void UpdateAllPictureBoxes()
        {
            foreach (var comboBox in comboBoxToPictureBoxMap.Keys)
            {
                if (comboBoxToPictureBoxMap.TryGetValue(comboBox, out PictureBox pictureBox))
                {
                    pictureBox.Image = unsavedStatus[comboBox]
                        ? (SettingsManager.Theme == "Dark" ? Properties.Resources.unsaved : Properties.Resources.unsaved)
                        : null;
                }
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            // Save updated settings
            SettingsManager.FontSize = cbFontSize.SelectedItem.ToString();
            SettingsManager.Temperature = cbTemperature.SelectedItem.ToString();
            SettingsManager.Theme = cbTheme.SelectedItem.ToString();
            SettingsManager.TimeFormat = cbTimeFormat.SelectedItem.ToString();
            SettingsManager.UpdateFrequency = cbUpdateFrequency.SelectedItem.ToString();
            SettingsManager.Vibration = cbVibration.SelectedItem.ToString();

            // Save the settings to file
            SettingsManager.SaveSettings("settingsData.txt");

            // Raise the SettingsUpdated event
            SettingsUpdated?.Invoke(this, EventArgs.Empty);

            ApplySettings();

            // Update original settings and update only the PictureBoxes for unsaved changes
            foreach (var comboBox in originalSettings.Keys.ToList())
            {
                // Update the original setting to the current value
                originalSettings[comboBox] = comboBox.SelectedItem.ToString();

                // If this combobox had an unsaved change, show "saved.png"
                if (unsavedStatus[comboBox])
                {
                    comboBoxToPictureBoxMap[comboBox].Image = SettingsManager.Theme == "Dark"
                        ? Properties.Resources.saved
                        : Properties.Resources.saveddark; // Use appropriate saved image
                }

                // Reset the unsaved status for this combobox
                unsavedStatus[comboBox] = false;
            }

            // Show save confirmation
            lblChangesMade.Text = "Your changes have been saved";
            lblChangesMade.ForeColor = SettingsManager.Theme == "Dark" ? Color.LightGreen : Color.Green; // Adjust color based on theme
            lblChangesMade.Visible = true;

            picChangesMade.Image = SettingsManager.Theme == "Dark"
                ? Properties.Resources.saved
                : Properties.Resources.saveddark; // Show saved image
            picChangesMade.Visible = true;

            // Reset unsaved changes count
            unsavedChangesCount = 0;

            // Update the main UI
            UpdateUnsavedChangesUI();
        }



        private void SettingsControl_Load(object sender, EventArgs e)
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
                if (control.Name != "btnSaveChanges" && control.Name != "btnCancel")
                {
                    control.BackColor = backgroundColor;
                    control.ForeColor = textColor;
                    if (control is ComboBox && SettingsManager.Theme == "Dark")
                    {
                        control.BackColor = Color.Black;
                    }
                    else if (control is ComboBox && SettingsManager.Theme == "Light")
                    {
                        control.BackColor = Color.White;
                    }
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Reset ComboBox values to their original settings
            foreach (var comboBox in originalSettings.Keys)
            {
                comboBox.SelectedItem = originalSettings[comboBox];
            }

            // Clear all PictureBoxes and reset statuses
            foreach (var pictureBox in comboBoxToPictureBoxMap.Values)
            {
                pictureBox.Image = null;
            }

            // Create a copy of the keys before modifying the dictionary
            foreach (var comboBox in unsavedStatus.Keys.ToList())
            {
                unsavedStatus[comboBox] = false;
            }

            // Reset unsaved changes count
            unsavedChangesCount = 0;
            UpdateUnsavedChangesUI(); // This will hide buttons if no changes are present
        }



        private void UpdateUnsavedChangesUI()
        {
            // Show or hide buttons based on unsaved changes
            bool hasUnsavedChanges = unsavedChangesCount > 0;
            btnSaveChanges.Visible = hasUnsavedChanges;
            btnCancel.Visible = hasUnsavedChanges;

            if (hasUnsavedChanges)
            {
                lblChangesMade.Text = $"You have {unsavedChangesCount} unsaved change{(unsavedChangesCount > 1 ? "s!" : "!")}";
                lblChangesMade.ForeColor = SettingsManager.Theme == "Dark" ? Color.OrangeRed : Color.Red; // Adjust color based on theme
                lblChangesMade.Visible = true;

                picChangesMade.Image = SettingsManager.Theme == "Dark"
                    ? Properties.Resources.unsaved
                    : Properties.Resources.unsaved;
                picChangesMade.Visible = true;
            }
            else if (lblChangesMade.Text != "Your changes have been saved")
            {
                // Hide only if not showing "Your changes have been saved"
                lblChangesMade.Visible = false;
                picChangesMade.Image = null;
                picChangesMade.Visible = false;
            }
        }



    }
}
