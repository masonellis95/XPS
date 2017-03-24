using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInWindow.Resources
{
    public partial class XPSTestScreen : UserControl
    {
        public XPSTestScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
          
            ExamForm exam = new ExamForm();
            exam.ShowDialog();
        }
    }
}
