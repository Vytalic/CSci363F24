using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace RemoteVehicleManager
{
    public partial class AlertsControl : UserControl
    {
        public AlertsControl()
        {
            InitializeComponent();
            InitializeComboBox();

            this.Load += AlertsControl_Load;
        }

        private void AlertsControl_Load(object sender, EventArgs e)
        {
            ApplySettings();
        }

        private void InitializeComboBox()
        {
            comboBoxSortBy.SelectedItem = "Newest";
        }

        public void ApplySettings()
        {
            // Determine theme colors
            Color backgroundColor = SettingsManager.Theme == "Dark" ? Color.FromArgb(40, 40, 40) : Color.White;
            Color textColor = SettingsManager.Theme == "Dark" ? Color.White : Color.Black;
          

            // Apply font size (default is medium = 12)
            float fontSize = 12;
            switch (SettingsManager.FontSize.ToLower())
            {
                case "small":
                    fontSize = 10;
                    break;
                case "medium":
                    fontSize = 12;
                    break;
                case "large":
                    fontSize = 14;
                    break;
                default:
                    fontSize = 12;
                    break;
            }

            foreach (Control control in this.Controls)
            {
                if (control is Label label)
                {
                    if (label.Name == "lblAlerts")
                    {
                        label.Font = new Font(label.Font.FontFamily, (fontSize + 24));
                    }
                    else
                    {
                        label.Font = new Font(label.Font.FontFamily, fontSize);

                    }
                }
                else if (control is FlowLayoutPanel flp)
                {
                    // Apply font size to combobox
                    if (flp.Name == "flowLayoutPanel1")
                    {
                        flp.Font = new Font(flp.Font.FontFamily, fontSize);
                    }
                }
            }

            // Apply Dark or Light theme
            // Update UserControl background
            this.BackColor = backgroundColor;

            // Update all direct child controls
            foreach (Control control in this.Controls)
            {
                control.BackColor = backgroundColor;
                control.ForeColor = textColor;

                if (control is FlowLayoutPanel flp)
                {
                    flp.BackColor = backgroundColor;
                }
                else
                {
                    control.BackColor = backgroundColor;
                }
            }

            // Update dynamically created rows in FlowLayoutPanel
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Panel rowPanel)
                {
                    rowPanel.BackColor = backgroundColor;

                    foreach (Control innerControl in rowPanel.Controls)
                    {
                        innerControl.BackColor = backgroundColor;
                        innerControl.ForeColor = textColor;
                    }
                }
            }
        }

        public void DisplayAlerts(List<(DateTime DateTime, string Description, int Severity)> alerts)
        {
            // Determine theme colors
            Color backgroundColor = SettingsManager.Theme == "Dark" ? Color.FromArgb(40, 40, 40) : Color.White;
            Color textColor = SettingsManager.Theme == "Dark" ? Color.White : Color.Black;

            // Clear existing controls in the panel
            flowLayoutPanel1.Controls.Clear();

            foreach (var alert in alerts)
            {
                // Create a panel for each row
                var rowPanel = new Panel
                {
                    Height = 50,
                    Width = flowLayoutPanel1.Width - 20, // Adjust for padding/margin
                    //BorderStyle = BorderStyle.FixedSingle,
                    BackColor = backgroundColor,
                    Margin = new Padding(5),
                    Dock = DockStyle.Top,
                };

                // Create a PictureBox for the icon
                var pictureBox = new PictureBox
                {
                    Width = 40,
                    Height = 40,
                    Image = alert.Severity == 1 ? Properties.Resources.octagon_exclamation : Properties.Resources.triangle_warning,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Margin = new Padding(5)

                };

                // Create a Label for the time
                var dateTimeLabel = new Label
                {
                    Text = alert.DateTime.ToString("MM/dd/yyyy\nh:mm tt"),
                    Width = 150,
                    Height = 40,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Margin = new Padding(5),
                    Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular),
                    BackColor = backgroundColor,
                    ForeColor = textColor,
                    BorderStyle = BorderStyle.FixedSingle
                };

                // Create a Label for the description
                var descriptionLabel = new Label
                {
                    Text = alert.Description,
                    AutoSize = false,
                    Height = 40,
                    Width = 300,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Margin = new Padding(5),
                    Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular),
                    BackColor = backgroundColor,
                    ForeColor = textColor,
                    BorderStyle = BorderStyle.FixedSingle
                };

                // Add controls to the row panel
                rowPanel.Controls.Add(pictureBox);
                rowPanel.Controls.Add(dateTimeLabel);
                rowPanel.Controls.Add(descriptionLabel);

                // Adjust control positions within the row panel
                pictureBox.Location = new Point(10, (rowPanel.Height - pictureBox.Height) / 2); // Center vertically
                dateTimeLabel.Location = new Point(pictureBox.Right + 10, (rowPanel.Height - dateTimeLabel.Height) / 2);
                descriptionLabel.Location = new Point(dateTimeLabel.Right + 10, (rowPanel.Height - descriptionLabel.Height) / 2);

                // Add the row panel to the FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(rowPanel);
            }
        }

        private List<(DateTime DateTime, string Description, int Severity)> LoadAlerts(string filePath)
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

        private void comboBoxSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            var alerts = LoadAlerts("alertsData.txt");

            if (comboBoxSortBy.SelectedItem.ToString() == "Newest")
            {
                // Sort alerts by most recent
                alerts.Sort((a, b) => b.DateTime.CompareTo(a.DateTime));
            }
            else if (comboBoxSortBy.SelectedItem.ToString() == "Oldest")
            {
                // Sort alerts by oldest
                alerts.Sort((a, b) => a.DateTime.CompareTo(b.DateTime));
            }

            DisplayAlerts(alerts);
        }
    }
}
