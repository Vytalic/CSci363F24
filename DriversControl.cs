using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteVehicleManager
{
    public partial class DriversControl : UserControl
    {

        private List<string> driversData = new List<string>();
        private List<string> originalState = new List<string>();
        private bool isEditMode = false;
        private int unsavedChangesCount = 0;


        public DriversControl()
        {
            InitializeComponent();
            this.Load += DriversControl_Load;
        }

        private void DriversControl_Load(object sender, EventArgs e)
        {
            ApplySettings();
            ConfigureTableLayoutPanel();
            LoadDriversData("driversData.txt");

            btnAddDriver.Visible = false; // Initially hidden
            lblUnsavedChanges.Visible = false;
        }

        public void ApplySettings()
        {
            // Determine theme colors
            Color backgroundColor = SettingsManager.Theme == "Dark" ? Color.FromArgb(40, 40, 40) : Color.DarkGray;
            Color textColor = SettingsManager.Theme == "Dark" ? Color.White : Color.Black;

            this.BackColor = backgroundColor;

            foreach (Control control in this.Controls)
            {
                if (control.Name != "btnEditDrivers" && control.Name != "btnAddDriver" && control.Name != "btnSaveChanges")
                {
                    control.BackColor = backgroundColor;
                    control.ForeColor = textColor;
                }
            }

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is Label label)
                {
                    label.ForeColor = textColor;
                }
                else if (control is PictureBox pictureBox)
                {
                    pictureBox.BackColor = backgroundColor;
                }
            }
        }

        private void ConfigureTableLayoutPanel()
        {
            tableLayoutPanel1.ColumnCount = 4; // Add column for dynamically created buttons
            tableLayoutPanel1.RowCount = 0;
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70));  // First column: PictureBox
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75));  // Second column: Label
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70)); // Third column: Unsaved indicator
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));      // Fourth column: Buttons
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.Padding = new Padding(10); // Add padding around the table
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.None; // Remove borders
        }



        private void LoadDriversData(string filePath)
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.RowCount = 0;
            driversData.Clear();
            originalState.Clear();

            if (!File.Exists(filePath))
            {
                // Create a file with default data if it doesn't exist
                File.WriteAllText(filePath, "John, Doe\nJane, Smith\nMichael, Johnson");
            }

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    driversData.Add(line);
                    originalState.Add(line);

                    var parts = line.Split(',');
                    if (parts.Length == 2)
                    {
                        string firstName = parts[0].Trim();
                        string lastName = parts[1].Trim();
                        AddDriverRow(firstName, lastName);
                    }
                }
            }
        }

        private void AddDriverRow(string firstName, string lastName)
        {
            // PictureBox for the first column (checkbox)
            var checkBox = new PictureBox
            {
                Width = 50,
                Height = 50,
                Image = Properties.Resources.unchecked_dark,
                Tag = false, // Initially unchecked
                Cursor = Cursors.Hand,
                Margin = new Padding(10),
                Visible = false // Ensure it is hidden initially
            };

            // Label for the second column (driver name)
            var label = new Label
            {
                Text = $"{firstName} {lastName}",
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("Arial", 14, FontStyle.Bold),
                BackColor = Color.LightGray,
                ForeColor = Color.Black,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(5),
                Width = 200,
                Height = 40
            };

            // PictureBox for the third column (unsaved indicator)
            var unsavedIndicator = new PictureBox
            {
                Width = 50,
                Height = 50,
                Image = Properties.Resources.unsaved,
                Visible = false,
                Margin = new Padding(10)
            };

            // Add controls to the TableLayoutPanel
            int rowIndex = tableLayoutPanel1.RowCount++;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60));
            tableLayoutPanel1.Controls.Add(checkBox, 0, rowIndex);
            tableLayoutPanel1.Controls.Add(label, 1, rowIndex);
            tableLayoutPanel1.Controls.Add(unsavedIndicator, 2, rowIndex);

            // Click event for the checkbox
            checkBox.Click += (s, e) => ToggleCheckBoxAndButtons(checkBox, rowIndex);
        }


        private void ToggleCheckBoxAndButtons(PictureBox checkBox, int rowIndex)
        {
            // Use the Tag property to determine the current state
            bool isChecked = (bool)checkBox.Tag;

            if (!isChecked)
            {
                // Update to checked state
                checkBox.Image = Properties.Resources.check_dark;
                checkBox.Tag = true;

                // Create dynamic buttons when checked
                CreateDynamicButtons(rowIndex);
            }
            else
            {
                // Update to unchecked state
                checkBox.Image = Properties.Resources.unchecked_dark;
                checkBox.Tag = false;

                // Remove dynamic buttons when unchecked
                RemoveDynamicButtons(rowIndex);
            }
        }

        private void CreateDynamicButtons(int rowIndex)
        {
            // Remove any existing button panel for this row
            RemoveDynamicButtons(rowIndex);

            // Create a new FlowLayoutPanel for Modify and Delete buttons
            var buttonPanel = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Margin = new Padding(10)
            };

            var modifyButton = new Button
            {
                Text = "Modify",
                BackColor = Color.LightGray,
                AutoSize = true,
                FlatStyle = FlatStyle.Flat
            };

            var deleteButton = new Button
            {
                Text = "Delete",
                BackColor = Color.Red,
                ForeColor = Color.White,
                AutoSize = true,
                FlatStyle = FlatStyle.Flat
            };

            // Modify button functionality: Hide btnEditDrivers
            modifyButton.Click += (s, e) =>
            {
                btnEditDrivers.Visible = false; // Hide the Edit Drivers button
                TransformButtonsToEditMode(rowIndex, modifyButton, deleteButton); // Enter modify mode
            };

            deleteButton.Click += (s, e) => DeleteDriver(rowIndex);

            buttonPanel.Controls.Add(modifyButton);
            buttonPanel.Controls.Add(deleteButton);

            tableLayoutPanel1.Controls.Add(buttonPanel, 3, rowIndex);

            UpdateRowHeights();
        }


        private void RemoveDynamicButtons(int rowIndex)
        {
            // Find and remove the FlowLayoutPanel for this row
            var buttonPanel = tableLayoutPanel1.Controls.Cast<Control>()
                .FirstOrDefault(c => tableLayoutPanel1.GetRow(c) == rowIndex && c is FlowLayoutPanel) as FlowLayoutPanel;

            if (buttonPanel != null)
            {
                tableLayoutPanel1.Controls.Remove(buttonPanel);
            }
        }


        private void TransformButtonsToEditMode(int rowIndex, Button modifyButton, Button deleteButton)
        {
            // Find the Label in the row and replace it with a TextBox
            var label = tableLayoutPanel1.Controls.Cast<Control>()
                .FirstOrDefault(c => tableLayoutPanel1.GetRow(c) == rowIndex && c is Label) as Label;

            if (label == null) return;

            var originalText = label.Text; // Store original text

            // Create TextBox for editing
            var textBox = new TextBox
            {
                Text = label.Text,
                Width = label.Width,
                Height = label.Height,
                Font = label.Font,
                BackColor = Color.LightYellow,
                BorderStyle = BorderStyle.FixedSingle
            };

            // Replace Label with TextBox in the table
            tableLayoutPanel1.Controls.Remove(label);
            tableLayoutPanel1.Controls.Add(textBox, 1, rowIndex);
            textBox.Focus(); // Focus on the TextBox for immediate editing

            // Destroy the old buttons (Modify and Delete)
            var buttonPanel = tableLayoutPanel1.Controls.Cast<Control>()
                .FirstOrDefault(c => tableLayoutPanel1.GetRow(c) == rowIndex && c is FlowLayoutPanel) as FlowLayoutPanel;

            if (buttonPanel != null)
            {
                tableLayoutPanel1.Controls.Remove(buttonPanel);
            }

            // Create a new FlowLayoutPanel for Apply and Cancel buttons
            var newButtonPanel = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Margin = new Padding(10)
            };

            var applyButton = new Button
            {
                Text = "Apply",
                BackColor = Color.LightGreen,
                AutoSize = true,
                FlatStyle = FlatStyle.Flat
            };

            var cancelButton = new Button
            {
                Text = "Cancel",
                BackColor = Color.Red,
                ForeColor = Color.White,
                AutoSize = true,
                FlatStyle = FlatStyle.Flat
            };

            // Apply button functionality
            applyButton.Click += (s, e) =>
            {
                if (!string.IsNullOrWhiteSpace(textBox.Text))
                {
                    // Update the label text
                    label.Text = textBox.Text;
                    driversData[rowIndex] = textBox.Text; // Update the data source

                    // Update unsaved changes count
                    unsavedChangesCount++;
                    UpdateUnsavedChangesLabel($"You have {unsavedChangesCount} unsaved changes!", Color.Red);

                    // Find the PictureBox in column 3 (Unsaved Indicator) and update its image and tag
                    var unsavedIndicator = tableLayoutPanel1.Controls.Cast<Control>()
                        .FirstOrDefault(c => tableLayoutPanel1.GetRow(c) == rowIndex && c is PictureBox && tableLayoutPanel1.GetColumn(c) == 2) as PictureBox;

                    if (unsavedIndicator != null)
                    {
                        unsavedIndicator.Image = Properties.Resources.unsaved; // Set to "unsaved.png"
                        unsavedIndicator.Tag = "unsaved"; // Set the tag
                        unsavedIndicator.Visible = true; // Ensure it's visible
                    }
                }

                // Restore the row's controls and reset the PictureBox
                RestoreRowControls(rowIndex, textBox, label);

                // Destroy the Apply/Cancel button panel
                tableLayoutPanel1.Controls.Remove(newButtonPanel);

                // Make btnEditDrivers visible again
                btnEditDrivers.Visible = true;
            };





            // Cancel button functionality
            cancelButton.Click += (s, e) =>
            {
                // Restore the original text in the label
                label.Text = originalText;

                // Restore the row's controls and reset the PictureBox
                RestoreRowControls(rowIndex, textBox, label);

                // Destroy the Apply/Cancel button panel
                tableLayoutPanel1.Controls.Remove(newButtonPanel);

                // Make btnEditDrivers visible again
                btnEditDrivers.Visible = true;
            };

            newButtonPanel.Controls.Add(applyButton);
            newButtonPanel.Controls.Add(cancelButton);

            tableLayoutPanel1.Controls.Add(newButtonPanel, 3, rowIndex);

            UpdateRowHeights();
        }


        private void RestoreRowControls(int rowIndex, TextBox textBox, Label label)
        {
            // Replace the TextBox with the Label
            tableLayoutPanel1.Controls.Remove(textBox);
            tableLayoutPanel1.Controls.Add(label, 1, rowIndex);

            // Reset the PictureBox in column 1 to "unchecked_dark.png"
            var pictureBox = tableLayoutPanel1.Controls.Cast<Control>()
                .FirstOrDefault(c => tableLayoutPanel1.GetRow(c) == rowIndex && c is PictureBox && tableLayoutPanel1.GetColumn(c) == 0) as PictureBox;

            if (pictureBox != null)
            {
                pictureBox.Image = Properties.Resources.unchecked_dark;
                pictureBox.Tag = false; // Reset the state to unchecked
            }

            // Make the existing Modify and Delete buttons visible again
            var existingButtonPanel = tableLayoutPanel1.Controls.Cast<Control>()
                .FirstOrDefault(c => tableLayoutPanel1.GetRow(c) == rowIndex && c is FlowLayoutPanel) as FlowLayoutPanel;

            if (existingButtonPanel != null)
            {
                existingButtonPanel.Visible = true;
            }
        }


        private void UpdateRowHeights()
        {
            int maxHeight = tableLayoutPanel1.Controls.Cast<Control>()
                .Where(c => c is FlowLayoutPanel && c.Visible)
                .Select(c => c.Height + 20) // Add padding
                .DefaultIfEmpty(60) // Default height
                .Max();

            foreach (RowStyle rowStyle in tableLayoutPanel1.RowStyles)
            {
                rowStyle.Height = maxHeight; // Set uniform height for all rows
            }

            foreach (var control in tableLayoutPanel1.Controls.Cast<Control>())
            {
                if (control is Label || control is PictureBox || control is FlowLayoutPanel)
                {
                    control.Anchor = AnchorStyles.None; // Center within the cell
                }
            }
        }



        private void DeleteDriver(int rowIndex)
        {
            var dialogResult = MessageBox.Show("Are you sure you want to delete this driver?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                // Find and remove all controls in the specified row
                var controlsToRemove = tableLayoutPanel1.Controls.Cast<Control>()
                    .Where(c => tableLayoutPanel1.GetRow(c) == rowIndex)
                    .ToList();

                foreach (var control in controlsToRemove)
                {
                    tableLayoutPanel1.Controls.Remove(control);
                }

                // Remove the driver data associated with the row
                var label = controlsToRemove.OfType<Label>().FirstOrDefault();
                if (label != null)
                {
                    driversData.Remove(label.Text);
                }

                unsavedChangesCount++;
                UpdateUnsavedChangesLabel($"You have {unsavedChangesCount} unsaved changes!", Color.Red);

                // Reorganize rows to account for the removed row
                for (int i = rowIndex + 1; i < tableLayoutPanel1.RowCount; i++)
                {
                    foreach (Control control in tableLayoutPanel1.Controls.Cast<Control>()
                        .Where(c => tableLayoutPanel1.GetRow(c) == i))
                    {
                        tableLayoutPanel1.SetRow(control, i - 1);
                    }
                }

                tableLayoutPanel1.RowCount--;
            }
        }


        private void btnEditDrivers_Click(object sender, EventArgs e)
        {
            isEditMode = !isEditMode;

            if (isEditMode)
            {
                // Enter edit mode
                originalState = new List<string>(driversData); // Backup original data
                btnEditDrivers.Text = "Cancel";
                btnSaveChanges.Visible = true;

                lblUnsavedChanges.Visible = false; // Hide lblUnsavedChanges in edit mode
            }
            else
            {
                // Exit edit mode (cancel changes)
                driversData = new List<string>(originalState); // Revert to original state
                ReloadDriversData(); // Refresh UI with original data
                btnEditDrivers.Text = "Edit Drivers";
                btnSaveChanges.Visible = false;

                // Reset unsaved changes count
                unsavedChangesCount = 0;
                UpdateUnsavedChangesLabel("", Color.Black); // Clear the label text
            }

            // Update the visibility of checkboxes, button panels, and column 3 images
            foreach (Control control in tableLayoutPanel1.Controls.Cast<Control>().ToList())
            {
                if (control is PictureBox pictureBox)
                {
                    int column = tableLayoutPanel1.GetColumn(control);

                    if (column == 0)
                    {
                        // Toggle visibility of checkboxes in column 0
                        pictureBox.Visible = isEditMode;
                    }
                    else if (column == 2)
                    {
                        // Hide images in column 3
                        pictureBox.Visible = !isEditMode;
                    }
                }

                if (control is FlowLayoutPanel buttonPanel)
                {
                    // Toggle visibility of button panels
                    buttonPanel.Visible = isEditMode;
                }
            }

            btnAddDriver.Visible = isEditMode;
        }


        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            var formattedData = driversData.Select(data =>
            {
                if (!data.Contains(","))
                {
                    var parts = data.Split(' ');
                    if (parts.Length == 2)
                    {
                        return $"{parts[0]},{parts[1]}";
                    }
                }
                return data;
            }).ToList();

            try
            {
                // Write formatted data to the file
                File.WriteAllLines("driversData.txt", formattedData);

                // Update any PictureBox in column 3 with "unsaved.png" to "saved.png"
                foreach (var control in tableLayoutPanel1.Controls.Cast<Control>())
                {
                    if (control is PictureBox pictureBox && tableLayoutPanel1.GetColumn(pictureBox) == 2)
                    {
                        if (pictureBox.Tag != null && pictureBox.Tag.ToString() == "unsaved")
                        {
                            pictureBox.Image = Properties.Resources.saved; // Change to "saved.png"
                            pictureBox.Tag = "saved"; // Update the tag
                            pictureBox.Visible = true; // Ensure visibility
                        }
                    }
                }

                // Display success message in lblUnsavedChanges
                UpdateUnsavedChangesLabel("Your changes were saved successfully!", Color.Green);

                // Reset unsaved changes count
                unsavedChangesCount = 0;

                // Exit edit mode
                isEditMode = false;
                btnEditDrivers.Text = "Edit Drivers";
                btnSaveChanges.Visible = false;

                // Reload updated data from the saved file
                LoadDriversData("driversData.txt");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving changes: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ReloadDriversData()
        {
            tableLayoutPanel1.Controls.Clear(); // Clear existing rows
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.RowCount = 0;

            foreach (var line in driversData)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    var parts = line.Split(',');
                    if (parts.Length == 2)
                    {
                        string firstName = parts[0].Trim();
                        string lastName = parts[1].Trim();
                        AddDriverRow(firstName, lastName);
                    }
                }
            }
        }


        private void UpdateUnsavedChangesLabel(string text, Color color)
        {
            lblUnsavedChanges.Visible = true; // Ensure the label is visible
            lblUnsavedChanges.Text = text;
            lblUnsavedChanges.ForeColor = color;
            lblUnsavedChanges.Font = new Font(lblUnsavedChanges.Font.FontFamily, 14, FontStyle.Bold);
        }




    }
}
