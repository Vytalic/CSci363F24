using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using RemoteVehicleManager;
using static RemoteVehicleManager.VehiclesControl;
using System.Windows.Forms.VisualStyles;

namespace RemoteVehicleManager
{
    

    public partial class VehiclesControl : UserControl
    {

        private bool isEditMode = false;
        private List<string> originalState = new List<string>();
        private int unsavedChangesCount = 0;
        private bool saveChanges = false;
        private List<string> vehiclesData = new List<string>();

        public VehiclesControl()
        {
            InitializeComponent();
            this.Load += VehiclesControl_Load;
        }

        public class CheckBoxTag
        {
            public Panel ButtonPanel { get; set; }
            public bool IsChecked { get; set; }
        }

        private void VehiclesControl_Load(object sender, EventArgs e)
        {
            ApplySettings();
            ConfigureTableLayoutPanel();
            LoadVehiclesData("vehiclesData.txt");

            // Reset initial state
            btnEditVehicles.Text = "Edit Vehicles";
            isEditMode = false;
            btnSaveChanges.Visible = false;
            btnAddVehicle.Visible = false;
            lblUnsavedChanges.Visible = false;
            pictureBox1.Visible = false;

            this.AutoScroll = false; // Disable UserControl's scrollbars
            this.HorizontalScroll.Enabled = false;
            this.HorizontalScroll.Visible = false;

        }

        public void ApplySettings()
        {
            // Determine theme colors
            Color backgroundColor = SettingsManager.Theme == "Dark" ? Color.FromArgb(40, 40, 40) : Color.DarkGray;
            Color textColor = SettingsManager.Theme == "Dark" ? Color.White : Color.Black;

            // Determine theme-specific images
            Image checkedImage = SettingsManager.Theme == "Dark"
                ? Properties.Resources.checked_white
                : Properties.Resources.check_dark;
            Image uncheckedImage = SettingsManager.Theme == "Dark"
                ? Properties.Resources.unchecked_white
                : Properties.Resources.unchecked_dark;

            // Apply background and text color to the main control
            this.BackColor = backgroundColor;

            foreach (Control control in this.Controls)
            {
                if (control.Name != "btnEditVehicles" && control.Name != "btnSaveChanges" && control.Name != "btnAddVehicle")
                {
                    control.BackColor = backgroundColor;
                    control.ForeColor = textColor;
                }
                

            }

            // Update dynamically created controls in the TableLayoutPanel
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is RichTextBox richTextBox)
                {
                    // Set the background color of the RichTextBox
                    richTextBox.BackColor = backgroundColor;

                    // Set the text color for the entire content
                    richTextBox.SelectAll();
                    richTextBox.SelectionColor = textColor;
                    richTextBox.SelectionAlignment = HorizontalAlignment.Center;
                    richTextBox.DeselectAll();
                }
                else if (control is PictureBox pictureBox)
                {
                    // Update the image based on the tag
                    if (pictureBox.Tag?.ToString() == "checked")
                    {
                        pictureBox.Image = checkedImage;
                    }
                    else
                    {
                        pictureBox.Image = uncheckedImage;
                    }
                }
            }
        }





        private void ConfigureTableLayoutPanel()
        {
            // Create a scrollable panel for tableLayoutPanel1
            var scrollablePanel = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true, // Enable vertical scrolling
                HorizontalScroll = { Enabled = false, Visible = false }, // Disable horizontal scrolling
                BackColor = Color.Transparent // Optional: match the background color
            };

            // Add tableLayoutPanel1 to the scrollable panel
            scrollablePanel.Controls.Add(tableLayoutPanel1);

            // Clear and add the scrollable panel to panel1
            panel1.Controls.Clear();
            panel1.Controls.Add(scrollablePanel);

            // Configure tableLayoutPanel1 inside the scrollable panel
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.Dock = DockStyle.Top; // Align at the top of the scrollable area
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.RowCount = 0; // Will be dynamically updated
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50));  // Fixed width for PictureBox
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300)); // Fixed width for RichTextBox
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100)); // Fixed width for Buttons
        }






        private void CenterTableLayoutPanel()
        {
            if (tableLayoutPanel1.Parent != null)
            {
                var parent = tableLayoutPanel1.Parent;

                // Keep the fixed width of 400 and center it in the parent panel
                tableLayoutPanel1.Size = new Size(
                    850,
                    tableLayoutPanel1.PreferredSize.Height
                );

                // Center the TableLayoutPanel
                tableLayoutPanel1.Location = new Point(
                    (parent.ClientSize.Width - tableLayoutPanel1.Width) / 2,
                    (parent.ClientSize.Height - tableLayoutPanel1.Height) / 2
                );
            }
        }


        private void LoadVehiclesData(string filePath)
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.RowCount = 0;
            vehiclesData.Clear();
            originalState.Clear();

            if (!File.Exists(filePath))
            {
                // Create the file with default data if it doesn't exist
                File.WriteAllText(filePath,
                    "Vehicle 1, 2023 Toyota Corolla, Hybrid\n" +
                    "Vehicle 2, 2019 Ford F-150, Petro-fuel\n" +
                    "Vehicle 3, 2022 Tesla Model 3, Electric");
            }

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {

                if (!string.IsNullOrWhiteSpace(line))
                {
                    vehiclesData.Add(line); // Add to list
                    originalState.Add(line);
                    
                    var parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        string vehicleName = parts[0].Trim();
                        string vehicleDetails = parts[1].Trim();
                        string fuelType = parts[2].Trim();


                        AddVehicleRow(vehicleName, vehicleDetails, fuelType);

                        
                    }
                }
            }
            // Center the table
            CenterTableLayoutPanel();
        }

        private void ToggleCheckBoxState(PictureBox checkBox)
        {
            if (checkBox.Tag is CheckBoxTag tag)
            {
                // Determine the theme-specific images
                Image checkedImage = SettingsManager.Theme == "Dark"
                    ? Properties.Resources.checked_white
                    : Properties.Resources.check_dark;
                Image uncheckedImage = SettingsManager.Theme == "Dark"
                    ? Properties.Resources.unchecked_white
                    : Properties.Resources.unchecked_dark;

                // Toggle the checkbox state
                tag.IsChecked = !tag.IsChecked;
                checkBox.Image = tag.IsChecked ? checkedImage : uncheckedImage;

                // Update button panel visibility
                tag.ButtonPanel.Visible = tag.IsChecked;
            }
        }


        private RichTextBox CreateMultiLineRichTextBox(string vehicleName, string vehicleDetails, string fuelType)
        {
            var richTextBox = new RichTextBox
            {
                Multiline = true,
                ReadOnly = true,
                BackColor = Color.LightGray,
                BorderStyle = BorderStyle.None,
                Width = 400, // Match the fixed width of Column 2
                Height = 80, // Ensure consistent height
                ScrollBars = RichTextBoxScrollBars.None,
                Padding = new Padding(10)
            };

            // Combine the text with line breaks
            richTextBox.Text = $"{vehicleName}\n{vehicleDetails}\n{fuelType}";

            // Center-align the text
            richTextBox.SelectAll();
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;

            // Customize the first line (vehicle name)
            int firstLineEnd = vehicleName.Length;
            richTextBox.Select(0, firstLineEnd);
            richTextBox.SelectionFont = new Font(richTextBox.Font.FontFamily, 14, FontStyle.Bold);

            // Customize the remaining lines (details and fuel type)
            int detailsStart = firstLineEnd + 1;
            int detailsLength = richTextBox.Text.Length - detailsStart;
            richTextBox.Select(detailsStart, detailsLength);
            richTextBox.SelectionFont = new Font(richTextBox.Font.FontFamily, 12, FontStyle.Regular);

            // Clear selection
            richTextBox.DeselectAll();

            return richTextBox;
        }

        private void btnEditVehicles_Click(object sender, EventArgs e)
        {
            // Toggle the edit mode state
            isEditMode = !isEditMode;

            // Update the button text
            btnEditVehicles.Text = isEditMode ? "Cancel" : "Edit Vehicles";

            if (isEditMode)
            {
                // Entering edit mode
                btnSaveChanges.Visible = true;
                btnAddVehicle.Visible = true;
                lblUnsavedChanges.Visible = false;
                pictureBox1.Visible = false;

                foreach (Control control in tableLayoutPanel1.Controls)
                {
                    if (control is PictureBox pictureBox)
                    {
                        pictureBox.Visible = true; // Show the PictureBox controls in edit mode
                    }
                }

                // Show unsaved changes label and picture if there are unsaved changes
                if (unsavedChangesCount > 0)
                {
                    lblUnsavedChanges.Visible = true;
                    lblUnsavedChanges.Text = $"You have {unsavedChangesCount} unsaved change{(unsavedChangesCount > 1 ? "s!" : "!")}";
                    lblUnsavedChanges.ForeColor = Color.Red;
                    lblUnsavedChanges.Font = new Font(lblUnsavedChanges.Font.FontFamily, 14);
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.unsaved; // Set to unsaved image
                }

                
            }
            else
            {
                // Exiting edit mode
                btnSaveChanges.Visible = false;
                btnAddVehicle.Visible = false;

                // Hide all PictureBox controls in column 1
                foreach (Control control in tableLayoutPanel1.Controls)
                {
                    if (control is PictureBox pictureBox)
                    {
                        pictureBox.Visible = false; // Hide PictureBox controls
                    }
                }

                // Remove the add vehicle panel if it exists
                if (addVehiclePanel != null)
                {
                    tableLayoutPanel1.Controls.Remove(addVehiclePanel);
                    addVehiclePanel.Dispose();
                    addVehiclePanel = null; // Reset the reference
                }

                if (saveChanges)
                {
                    // Saved changes state
                    lblUnsavedChanges.Text = "Your changes have been saved!";
                    lblUnsavedChanges.ForeColor = Color.Green;
                    lblUnsavedChanges.Font = new Font(lblUnsavedChanges.Font.FontFamily, 14);
                    lblUnsavedChanges.Visible = true;

                    if (SettingsManager.Theme == "Dark")
                    {
                        pictureBox1.Image = Properties.Resources.saved;
                    }
                    else if (SettingsManager.Theme == "Light")
                    {
                        pictureBox1.Image = Properties.Resources.saveddark;
                    }
                   
                    pictureBox1.Visible = true;

                    // Reset saveChanges flag
                    saveChanges = false; // This prevents the green label from appearing when clicking "Cancel" next time.
                }
                else
                {
                    // Cancel state (unsaved changes discarded)
                    unsavedChangesCount = 0;
                    lblUnsavedChanges.Visible = false;
                    pictureBox1.Visible = false;
                    refreshTable(); // Reload the original state
                }
            }
        }




        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            saveChanges = true;

            // Rebuild vehiclesData from the table's current state
            vehiclesData.Clear();
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is RichTextBox richTextBox)
                {
                    var lines = richTextBox.Text.Split('\n');
                    if (lines.Length >= 3)
                    {
                        string vehicleName = lines[0].Trim();
                        string vehicleDetails = lines[1].Trim();
                        string fuelType = lines[2].Trim();
                        vehiclesData.Add($"{vehicleName}, {vehicleDetails}, {fuelType}");
                    }
                }
            }

            // Write to file
            File.WriteAllLines("vehiclesData.txt", vehiclesData);

            // Refresh UI with updated data
            LoadVehiclesData("vehiclesData.txt");

            // Reset counter
            unsavedChangesCount = 0;
            

            // Update saved state
            lblUnsavedChanges.Text = "Your changes have been saved!";
            lblUnsavedChanges.ForeColor = Color.Green;
            lblUnsavedChanges.Font = new Font(lblUnsavedChanges.Font.FontFamily, 14);
            lblUnsavedChanges.Visible = true;

            pictureBox1.Image = SettingsManager.Theme == "Dark"
                ? Properties.Resources.saved
                : Properties.Resources.saveddark;
            pictureBox1.Visible = true;

            // Exit edit mode
            isEditMode = false;
            btnEditVehicles.Text = "Edit Vehicles";
            btnSaveChanges.Visible = false;
            btnAddVehicle.Visible = false;

        }






        private void refreshTable()
        {
            // Revert to original state
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.RowCount = 0;

            foreach (var line in originalState)
            {
                var parts = line.Split(',');
                if (parts.Length == 3)
                {
                    string vehicleName = parts[0].Trim();
                    string vehicleDetails = parts[1].Trim();
                    string fuelType = parts[2].Trim();

                    AddVehicleRow(vehicleName, vehicleDetails, fuelType);
                }
            }
        }

        // Field to track the dynamically added input panel
        private FlowLayoutPanel addVehiclePanel;

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            // Check if the panel already exists, if so, bring focus to it
            if (addVehiclePanel != null)
            {
                addVehiclePanel.BringToFront();
                return;
            }

            // Create a new panel for adding a vehicle
            addVehiclePanel = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.LeftToRight,
                AutoSize = true,
                Padding = new Padding(10),
                Margin = new Padding(10),
                BackColor = Color.LightGray // Optional: distinguish the panel visually
            };

            // Helper function to create titled input fields
            void AddLabeledInput(string labelText, Control inputControl)
            {
                var container = new FlowLayoutPanel
                {
                    FlowDirection = FlowDirection.TopDown,
                    AutoSize = true,
                    Margin = new Padding(5)
                };

                var label = new Label
                {
                    Text = labelText,
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Bold)
                };

                container.Controls.Add(label);
                container.Controls.Add(inputControl);
                addVehiclePanel.Controls.Add(container);
            }

            // Create input fields for the new vehicle
            var txtVehicleName = new TextBox
            {
                Text = "Enter vehicle name",
                Width = 150,
                ForeColor = Color.Gray
            };
            txtVehicleName.Enter += (s, ev) =>
            {
                if (txtVehicleName.Text == "Enter vehicle name")
                {
                    txtVehicleName.Text = "";
                    txtVehicleName.ForeColor = Color.Black;
                }
            };
            txtVehicleName.Leave += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(txtVehicleName.Text))
                {
                    txtVehicleName.Text = "Enter vehicle name";
                    txtVehicleName.ForeColor = Color.Gray;
                }
            };

            var cmbYear = new ComboBox
            {
                Width = 80,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            for (int year = 2000; year <= DateTime.Now.Year; year++)
            {
                cmbYear.Items.Add(year.ToString());
            }
            cmbYear.SelectedIndex = cmbYear.Items.Count - 1;

            var cmbMake = new ComboBox
            {
                Width = 150,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbMake.Items.AddRange(new string[] { "Toyota", "Ford", "Tesla", "Honda", "Chevrolet" });
            cmbMake.SelectedIndex = 0;

            var cmbModel = new ComboBox
            {
                Width = 150,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbModel.Items.AddRange(new string[] { "Model A", "Model B", "Model C" });
            cmbModel.SelectedIndex = 0;

            var cmbFuelType = new ComboBox
            {
                Width = 100,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbFuelType.Items.AddRange(new string[] { "Gas", "Diesel", "Electric" });
            cmbFuelType.SelectedIndex = 0;

            // Add labeled input fields to the panel
            AddLabeledInput("Name", txtVehicleName);
            AddLabeledInput("Year", cmbYear);
            AddLabeledInput("Make", cmbMake);
            AddLabeledInput("Model", cmbModel);
            AddLabeledInput("Engine Type", cmbFuelType);

            // Create a Save button
            var btnSave = new Button
            {
                Text = "Apply",
                BackColor = Color.LightGreen,
                Height = 30,
                Width = 80
            };

            btnSave.Click += (saveSender, saveArgs) =>
            {
                // Validate the input fields
                if (string.IsNullOrWhiteSpace(txtVehicleName.Text) ||
                    cmbYear.SelectedItem == null ||
                    cmbMake.SelectedItem == null ||
                    cmbModel.SelectedItem == null ||
                    cmbFuelType.SelectedItem == null)
                {
                    MessageBox.Show("Please fill out all fields before saving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Collect the entered data
                string newVehicle = $"{txtVehicleName.Text}, {cmbYear.SelectedItem} {cmbMake.SelectedItem} {cmbModel.SelectedItem}, {cmbFuelType.SelectedItem}";

                // Add the new vehicle to the data structure
                vehiclesData.Add(newVehicle);

                // Save the new vehicle to the file
                File.WriteAllLines("vehiclesData.txt", vehiclesData);

                // Reload vehicles to update UI
                LoadVehiclesData("vehiclesData.txt");

                // Remove the add vehicle panel after saving
                tableLayoutPanel1.Controls.Remove(addVehiclePanel);
                addVehiclePanel.Dispose();
                addVehiclePanel = null;

                // Mark as an unsaved change
                unsavedChangesCount++;
                lblUnsavedChanges.Visible = true;
                lblUnsavedChanges.Text = $"You have {unsavedChangesCount} unsaved change{(unsavedChangesCount > 1 ? "s!" : "!")}";
                lblUnsavedChanges.ForeColor = Color.Red;
                lblUnsavedChanges.Font = new Font(lblUnsavedChanges.Font.FontFamily, 14);
            };

            addVehiclePanel.Controls.Add(btnSave);

            // Add the panel to the top of the table
            tableLayoutPanel1.RowCount++;
            tableLayoutPanel1.RowStyles.Insert(0, new RowStyle(SizeType.AutoSize));
            tableLayoutPanel1.Controls.Add(addVehiclePanel, 0, 0);
            tableLayoutPanel1.SetColumnSpan(addVehiclePanel, tableLayoutPanel1.ColumnCount);

            // Move existing rows down
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (tableLayoutPanel1.GetRow(control) != 0)
                {
                    int currentRow = tableLayoutPanel1.GetRow(control);
                    tableLayoutPanel1.SetRow(control, currentRow + 1);
                }
            }

        }





        private void AddVehicleRow(string vehicleName, string vehicleDetails, string fuelType)
        {
            // Create the PictureBox
            var checkBox = new PictureBox
            {
                Width = 25,
                Height = 25,
                Image = Properties.Resources.unchecked_dark,
                Cursor = Cursors.Hand,
                Margin = new Padding(10, 30, 0, 0),
                Visible = false
            };

            // Set the initial image based on the theme
            if (SettingsManager.Theme == "Dark")
            {
                checkBox.Image = Properties.Resources.unchecked_white;
            }
            else
            {
                checkBox.Image = Properties.Resources.unchecked_dark;
            }

            // Create the RichTextBox
            var richTextBox = CreateMultiLineRichTextBox(vehicleName, vehicleDetails, fuelType);

            // Create a panel for the buttons (stacked vertically)
            var buttonPanel = new Panel
            {
                Width = 100,
                Height = richTextBox.Height,
                Visible = false // Initially hidden
            };

            var modifyButton = new Button
            {
                Text = "Modify",
                Dock = DockStyle.Top,
                Height = 30,
                FlatStyle = FlatStyle.Flat, // Change FlatStyle
                BackColor = Color.LightGray, // Set background color
                ForeColor = Color.Black // Set foreground color
            };
            modifyButton.FlatAppearance.BorderSize = 0; // Remove border
            modifyButton.Click += (s, e) =>
            {
                // Identify the row to modify
                int rowToModify = tableLayoutPanel1.GetRow(buttonPanel);

                // Get the controls in the row
                var controlsInRow = tableLayoutPanel1.Controls.Cast<Control>()
                    .Where(c => tableLayoutPanel1.GetRow(c) == rowToModify)
                    .ToList();

                // Extract existing values
                string vname = "";
                string vdetails = "";
                string vfuel = "";

                foreach (var control in controlsInRow)
                {
                    if (control is RichTextBox rtb)
                    {
                        var vlines = rtb.Text.Split('\n');
                        vname = vlines.Length > 0 ? vlines[0].Trim() : string.Empty;
                        vdetails = vlines.Length > 1 ? vlines[1].Trim() : string.Empty;
                        vfuel = vlines.Length > 2 ? vlines[2].Trim() : string.Empty;
                    }
                }

                // Remove existing controls in the row
                foreach (var control in tableLayoutPanel1.Controls.Cast<Control>()
                    .Where(c => tableLayoutPanel1.GetRow(c) == rowToModify))
                {
                    tableLayoutPanel1.Controls.Remove(control);
                }

                // Ensure row style is AutoSize
                tableLayoutPanel1.RowStyles[rowToModify] = new RowStyle(SizeType.AutoSize);

                var detailsParts = vdetails.Split(' ');

                // Remove existing controls in the row
                foreach (var control in controlsInRow)
                {
                    tableLayoutPanel1.Controls.Remove(control);
                }

                // Create the dynamic input panel (similar to AddVehicle)
                var modifyPanel = new FlowLayoutPanel
                {
                    FlowDirection = FlowDirection.LeftToRight,
                    AutoSize = true, // Allow the panel to grow with content
                    AutoSizeMode = AutoSizeMode.GrowAndShrink, // Ensure proper growth behavior
                    Padding = new Padding(10),
                    Margin = new Padding(10),
                    BackColor = Color.LightGray, // Optional: distinguish visually
                    WrapContents = true // Enable wrapping of controls
                };

                // Helper function to create titled input fields
                void AddLabeledInput(string labelText, Control inputControl)
                {
                    var container = new FlowLayoutPanel
                    {
                        FlowDirection = FlowDirection.TopDown,
                        AutoSize = true,
                        Margin = new Padding(5)
                    };

                    var label = new Label
                    {
                        Text = labelText,
                        AutoSize = true,
                        Font = new Font("Arial", 10, FontStyle.Bold)
                    };

                    container.Controls.Add(label);
                    container.Controls.Add(inputControl);
                    modifyPanel.Controls.Add(container);
                }

                // Create input fields with labels
                var txtVehicleName = new TextBox
                {
                    Text = vname,
                    Width = 150,
                    ForeColor = Color.Black
                };

                var cmbYear = new ComboBox
                {
                    Width = 80,
                    DropDownStyle = ComboBoxStyle.DropDownList
                };
                for (int year = 2000; year <= DateTime.Now.Year; year++)
                {
                    cmbYear.Items.Add(year.ToString());
                }
                cmbYear.SelectedItem = detailsParts.Length > 0 ? detailsParts[0] : string.Empty;

                var cmbMake = new ComboBox
                {
                    Width = 150,
                    DropDownStyle = ComboBoxStyle.DropDownList
                };
                cmbMake.Items.AddRange(new string[] { "Toyota", "Ford", "Tesla", "Honda", "Chevrolet" });
                cmbMake.SelectedItem = detailsParts.Length > 1 ? detailsParts[1] : string.Empty;

                var cmbModel = new ComboBox
                {
                    Width = 150,
                    DropDownStyle = ComboBoxStyle.DropDownList
                };
                cmbModel.Items.AddRange(new string[] { "Model A", "Model B", "Model C" });
                cmbModel.SelectedItem = detailsParts.Length > 2 ? detailsParts[2] : string.Empty;

                var cmbFuelType = new ComboBox
                {
                    Width = 100,
                    DropDownStyle = ComboBoxStyle.DropDownList
                };
                cmbFuelType.Items.AddRange(new string[] { "Petro-fuel", "Hybrid", "Electric" });
                cmbFuelType.SelectedItem = vfuel;

                // Add labeled input fields to the modify panel
                AddLabeledInput("Name", txtVehicleName);
                AddLabeledInput("Year", cmbYear);
                AddLabeledInput("Make", cmbMake);
                AddLabeledInput("Model", cmbModel);
                AddLabeledInput("Engine Type", cmbFuelType);


                // Add a container for positioning the Apply button
                var buttonContainer = new Panel
                {
                    Dock = DockStyle.Bottom, // Place at the bottom of the modifyPanel
                    Height = 50, // Adjust height as needed
                    Padding = new Padding(0),
                    Margin = new Padding(0),
                    BackColor = modifyPanel.BackColor // Match the parent panel's background
                };



                // Add a "Save" button to apply changes
                var btnSave = new Button
                {
                    Text = "Apply",
                    BackColor = Color.LightGreen,
                    Height = 30,
                    Width = 80,
                    Anchor = AnchorStyles.Bottom, //| AnchorStyles.Right,
                    Margin = new Padding(5)
                };

                btnSave.Click += (saveSender, saveArgs) =>
                {
                    // Check if controls are properly populated
                    if (string.IsNullOrWhiteSpace(txtVehicleName.Text))
                    {
                        MessageBox.Show("Vehicle name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (cmbYear.SelectedItem == null || cmbMake.SelectedItem == null || cmbModel.SelectedItem == null || cmbFuelType.SelectedItem == null)
                    {
                        MessageBox.Show("Please select a valid year, make, model, and fuel type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Collect updated data
                    string updatedVehicle = $"{txtVehicleName.Text}, {cmbYear.SelectedItem} {cmbMake.SelectedItem} {cmbModel.SelectedItem}, {cmbFuelType.SelectedItem}";

                    // Replace the modify panel with updated text
                    tableLayoutPanel1.Controls.Remove(modifyPanel);
                    tableLayoutPanel1.Controls.Remove(btnSave);

                    var updatedRichTextBox = CreateMultiLineRichTextBox(
                        txtVehicleName.Text,
                        $"{cmbYear.SelectedItem} {cmbMake.SelectedItem} {cmbModel.SelectedItem}",
                        cmbFuelType.SelectedItem.ToString()
                    );

                    tableLayoutPanel1.Controls.Add(updatedRichTextBox, 1, rowToModify);

                    // Mark changes as unsaved
                    unsavedChangesCount++;
                    lblUnsavedChanges.Text = $"You have {unsavedChangesCount} unsaved change{(unsavedChangesCount > 1 ? "s!" : "!")}";
                    lblUnsavedChanges.Font = new Font(lblUnsavedChanges.Font.FontFamily, 14);
                    lblUnsavedChanges.ForeColor = Color.Red;
                    lblUnsavedChanges.Visible = true;

                    //change based on theme
                    pictureBox1.Image = Properties.Resources.unsaved;
                    pictureBox1.Visible = true;
                };


                modifyPanel.Controls.Add(btnSave);
                tableLayoutPanel1.Controls.Add(modifyPanel, 0, rowToModify);
                tableLayoutPanel1.SetColumnSpan(modifyPanel, tableLayoutPanel1.ColumnCount);

                tableLayoutPanel1.PerformLayout();
                RefreshAllRowStyles();
            };







            var deleteButton = new Button
            {
                Text = "Delete",
                Dock = DockStyle.Top,
                Height = 30,
                FlatStyle = FlatStyle.Flat, // Change FlatStyle
                BackColor = Color.Red, // Set background color for delete
                ForeColor = Color.White // Set foreground color
            };
            deleteButton.FlatAppearance.BorderSize = 0; // Remove border
            deleteButton.Click += (s, e) =>
            {
                var dialogResult = MessageBox.Show(
                    $"Are you sure you want to delete {vehicleName}?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    // Identify the row to be deleted
                    int rowToDelete = tableLayoutPanel1.GetRow(buttonPanel);

                    // Collect controls in the row
                    var controlsToRemove = new List<Control>();
                    foreach (Control control in tableLayoutPanel1.Controls)
                    {
                        if (tableLayoutPanel1.GetRow(control) == rowToDelete)
                        {
                            controlsToRemove.Add(control);
                        }
                    }

                    // Remove controls from the table
                    foreach (var control in controlsToRemove)
                    {
                        tableLayoutPanel1.Controls.Remove(control);
                    }

                    // Remove the row style
                    if (rowToDelete < tableLayoutPanel1.RowStyles.Count)
                    {
                        tableLayoutPanel1.RowStyles.RemoveAt(rowToDelete);
                    }

                    // Adjust row indices for remaining controls
                    foreach (Control control in tableLayoutPanel1.Controls)
                    {
                        int currentRow = tableLayoutPanel1.GetRow(control);
                        if (currentRow > rowToDelete)
                        {
                            tableLayoutPanel1.SetRow(control, currentRow - 1);
                        }
                    }

                    // Update the table layout
                    tableLayoutPanel1.RowCount--;
                    tableLayoutPanel1.PerformLayout();

                    // Update unsvedChanges counter
                    unsavedChangesCount++;
                    lblUnsavedChanges.Visible = true;
                    lblUnsavedChanges.Text = $"You have {unsavedChangesCount} unsaved change{(unsavedChangesCount > 1 ? "s!" : "!")}";
                    lblUnsavedChanges.ForeColor = Color.Red;
                    lblUnsavedChanges.Font = new Font(lblUnsavedChanges.Font.FontFamily, 14);

                    //change based on theme
                    pictureBox1.Image = Properties.Resources.unsaved;
                    pictureBox1.Visible = true;
                }
            };


            buttonPanel.Controls.Add(deleteButton);
            buttonPanel.Controls.Add(modifyButton);

            // Assign the Tag with a new CheckBoxTag object
            checkBox.Tag = new CheckBoxTag
            {
                ButtonPanel = buttonPanel,
                IsChecked = false
            };

            // Attach Click event to toggle visibility
            checkBox.Click += (s, e) =>
            {
                ToggleCheckBoxState(checkBox);
            };

            // Add controls to the TableLayoutPanel
            tableLayoutPanel1.RowCount++;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, richTextBox.Height + 20));
            tableLayoutPanel1.Controls.Add(checkBox, 0, tableLayoutPanel1.RowCount - 1);
            tableLayoutPanel1.Controls.Add(richTextBox, 1, tableLayoutPanel1.RowCount - 1);
            tableLayoutPanel1.Controls.Add(buttonPanel, 2, tableLayoutPanel1.RowCount - 1);
        }

        private void RefreshAllRowStyles()
        {
            for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
            {
                tableLayoutPanel1.RowStyles[i] = new RowStyle(SizeType.AutoSize);
            }
            tableLayoutPanel1.PerformLayout();
        }

    }
}