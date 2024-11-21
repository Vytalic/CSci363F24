using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteVehicleManager
{
    public partial class HistoryControl : UserControl
    {
        public HistoryControl()
        {
            InitializeComponent();
            ApplySettings();
        }

        public void ApplySettings()
        {
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
                    if (label.Name == "lblHistory")
                    {
                        label.Font = new Font(label.Font.FontFamily, (fontSize + 24));
                    }
                    else
                    {
                        label.Font = new Font(label.Font.FontFamily, fontSize);

                    }
                }
                else if (control is ComboBox cb)
                {
                    // Apply font size to combobox
                    if (cb.Name == "comboBox1")
                    {
                        cb.Font = new Font(cb.Font.FontFamily, fontSize);
                    }
                }
            }

            // Apply Dark or Light theme
            if (SettingsManager.Theme == "Dark")
            {
                this.BackColor = Color.FromArgb(40, 40, 40);
                foreach (Control control in this.Controls)
                {
                    control.ForeColor = Color.White;

                    // Apply colors to combobox
                    if (control is ComboBox cb)
                    {
                        if (cb.Name == "comboBox1")
                        {
                            cb.BackColor = Color.Black;
                        }
                    }
                }
            }
            else
            {
                this.BackColor = Color.DarkGray;
                foreach (Control control in this.Controls)
                {
                    control.ForeColor = Color.Black;
                }
            }
        }
    }
}
