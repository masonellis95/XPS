using LogInWindow.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInWindow
{
    public partial class MainMenuForm : Form
    {
        Control testScreen = new Resources.XPSTestScreen();
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sideMenu.Panel2.Controls.Add(testScreen);
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
        }
    }
}
