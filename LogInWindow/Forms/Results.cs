using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XPS
{
    public partial class Results : Form
    {
        
            

        public Results()
        {
            InitializeComponent();

            //correctLabel.Parent = pictureBox1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuForm main = new MainMenuForm();
            main.ShowDialog();

            

        }
    }
}
