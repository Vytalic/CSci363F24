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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace RemoteVehicleManager
{
    public partial class HistoryControl : UserControl
    {
        public HistoryControl()
        {
            InitializeComponent();
            InitializeComboBox();

            this.Load += HistoryControl_Load;
        }

        private void HistoryControl_Load(object sender, EventArgs e)
        {
            ApplySettings();
        }

        private void InitializeComboBox()
        {
            comboBoxShowFrom.SelectedItem = "Installation Date";
        }

        public void ApplySettings()
        {
            // Determine theme colors
            Color backgroundColor = SettingsManager.Theme == "Dark" ? Color.FromArgb(40, 40, 40) : Color.DarkGray;
            Color textColor = SettingsManager.Theme == "Dark" ? Color.White : Color.Black;

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
                else if (control is ComboBox)
                {
                    if (SettingsManager.Theme == "Dark")
                    {
                        control.BackColor = Color.Black;
                    }
                    else
                    {
                        control.BackColor = Color.White;
                    }

                }
                else
                {

                    control.BackColor = backgroundColor;
                }
                if (control.Name == "btnClearAlerts")
                {
                    control.BackColor = Color.LightCoral;
                    control.ForeColor = Color.Black;
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
                        if (innerControl is PictureBox pictureBox)
                        {
                            pictureBox.BackColor = backgroundColor;
                            innerControl.ForeColor = textColor;
                        }
                        else
                        {
                            innerControl.ForeColor = textColor;
                            if (SettingsManager.Theme == "Light")
                            {
                                innerControl.BackColor = Color.LightGray;
                            }
                            else
                            {
                                innerControl.BackColor = Color.LightGray;
                                innerControl.ForeColor = Color.Black;

                            }
                        }

                    }
                }
            }
        }

        public void DisplayAlerts(List<(DateTime DateTime, string Description)> alerts)
        {
            // Determine theme colors
            Color backgroundColor = SettingsManager.Theme == "Dark" ? Color.FromArgb(40, 40, 40) : Color.DarkGray;
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
                    Width = 350,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Margin = new Padding(5),
                    Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular),
                    BackColor = backgroundColor,
                    ForeColor = textColor,
                    BorderStyle = BorderStyle.FixedSingle
                };




                // Add controls to the row panel
                //rowPanel.Controls.Add(pictureBox);
                rowPanel.Controls.Add(dateTimeLabel);
                rowPanel.Controls.Add(descriptionLabel);

                // Adjust control positions within the row panel
                //pictureBox.Location = new Point(10, (rowPanel.Height - pictureBox.Height) / 2); // Center vertically
                dateTimeLabel.Location = new Point(10, (rowPanel.Height - dateTimeLabel.Height) / 2);
                descriptionLabel.Location = new Point(dateTimeLabel.Right + 10, (rowPanel.Height - descriptionLabel.Height) / 2);

                // Add the row panel to the FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(rowPanel);
            }

            foreach (Control control in this.Controls)
            {
                control.BackColor = backgroundColor;
                control.ForeColor = textColor;

                if (control is FlowLayoutPanel flp)
                {
                    flp.BackColor = backgroundColor;
                }
                else if (control is ComboBox)
                {
                    if (SettingsManager.Theme == "Dark")
                    {
                        control.BackColor = Color.Black;
                    }
                    else
                    {
                        control.BackColor = Color.White;
                    }

                }
                else
                {

                    control.BackColor = backgroundColor;
                }
                if (control.Name == "btnClearAlerts")
                {
                    control.BackColor = Color.LightCoral;
                    control.ForeColor = Color.Black;
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
                        if (innerControl is PictureBox pictureBox)
                        {
                            pictureBox.BackColor = backgroundColor;
                            innerControl.ForeColor = textColor;
                        }
                        else
                        {
                            innerControl.ForeColor = textColor;
                            if (SettingsManager.Theme == "Light")
                            {
                                innerControl.BackColor = Color.LightGray;
                            }
                            else
                            {
                                innerControl.BackColor = Color.LightGray;
                                innerControl.ForeColor = Color.Black;

                            }
                        }

                    }
                }
            }
        }

        private List<(DateTime DateTime, string Description)> LoadAlerts(string filePath)
        {
            var alerts = new List<(DateTime DateTime, string Description)>();


            if (File.Exists("historyData.txt"))
            {
                // Read all lines in the file
                foreach (var line in File.ReadAllLines("historyData.txt"))
                {
                    var parts = line.Split(',');

                    if (parts.Length == 2
                        && DateTime.TryParse(parts[0], out var dateTime))
                    {
                        alerts.Add((dateTime, parts[1]));
                    }
                }
            }
            else
            {
                File.WriteAllText("historyData.txt",
                    "11/26/2024 9:00 AM,Data reset\n" +
                    "11/26/2024 7:45 AM,Application updated to v2.3.1\n" +
                    "11/20/2024 5:30 PM,Alerts cleared\n" +
                    "11/18/2024 3:15 PM,User settings changed\n" +
                    "11/10/2024 2:00 PM,New geofence added\n" +
                    "10/25/2024 4:45 PM,Service schedule updated\n" +
                    "10/05/2024 10:30 AM,Application updated to v2.2.0\n" +
                    "06/30/2024 8:00 AM,Initial application setup completed\n" +
                    "06/15/2024 6:30 PM,First user login\n");

                // Read all lines in the file
                foreach (var line in File.ReadAllLines("historyData.txt"))
                {
                    var parts = line.Split(',');
                    if (parts.Length == 2
                        && DateTime.TryParse(parts[0], out var dateTime))
                    {
                        alerts.Add((dateTime, parts[1]));
                    }
                }
            }
          
            return alerts;
        }

        




        private void comboBoxShowFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            var alerts = LoadAlerts("historyData.txt");

            DateTime now = DateTime.Now;
            IEnumerable<(DateTime DateTime, string Description)> filteredAlerts = alerts;

            if (comboBoxShowFrom.SelectedItem.ToString() == "Today")
            {
                // Filter alerts for today
                filteredAlerts = alerts.Where(alert => alert.DateTime.Date == now.Date);
            }
            else if (comboBoxShowFrom.SelectedItem.ToString() == "Last Week")
            {
                // Filter alerts from the last 7 days
                DateTime oneWeekAgo = now.AddDays(-7);
                filteredAlerts = alerts.Where(alert => alert.DateTime.Date >= oneWeekAgo.Date && alert.DateTime.Date <= now.Date);
            }
            else if (comboBoxShowFrom.SelectedItem.ToString() == "Last Month")
            {
                // Filter alerts from the last 30 days
                DateTime oneMonthAgo = now.AddDays(-30);
                filteredAlerts = alerts.Where(alert => alert.DateTime.Date >= oneMonthAgo.Date && alert.DateTime.Date <= now.Date);
            }
            else if (comboBoxShowFrom.SelectedItem.ToString() == "Last Reset")
            {
                // You can replace this with a specific logic or a stored last reset date
                DateTime lastResetDate = GetLastResetDate();
                filteredAlerts = alerts.Where(alert => alert.DateTime.Date >= lastResetDate.Date);
            }
            else if (comboBoxShowFrom.SelectedItem.ToString() == "Installation Date")
            {
                // Use a predefined installation date
                DateTime installationDate = GetInstallationDate();
                filteredAlerts = alerts.Where(alert => alert.DateTime.Date >= installationDate.Date);
            }

            // Display the filtered alerts
            DisplayAlerts(filteredAlerts.ToList());
        }

        private DateTime GetLastResetDate()
        {
            return new DateTime(2024, 11, 20);
        }

        private DateTime GetInstallationDate()
        {
            return new DateTime(2024, 6, 1);
        }


    }
}
