//Log in Form
//...
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
    public partial class LogInForm : Form
    {
        public static string passingText;

        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            passingText = CurrentIDTextBox.Text;
            ExamForm exam = new ExamForm();
            this.Hide();
            MainMenuForm main = new MainMenuForm();
            main.ShowDialog();
            
        }

        private void LogInForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        
       
    }
}
