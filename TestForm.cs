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
    public partial class TestForm : Form
    {
        // Keep reference to the main form
        private MainUIForm mainForm;

        public TestForm(MainUIForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

            
        // Currently just sets the home button to a green background color
        private void button1_Click(object sender, EventArgs e)
        {
            Button homeButton = mainForm.Controls.Find("home_tab", true).FirstOrDefault() as Button;
            if (homeButton != null)
            {
                homeButton.BackColor = Color.Green;
            }
        }
    }
}
