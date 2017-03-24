using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIFormsDemo
{
    public partial class ExamForm : Form
    {
        int s;
        int m;
        int h;



        public ExamForm()
        {
            InitializeComponent();
        }

        private void question1Savebtn_Click(object sender, EventArgs e)
        {
            GreenIcon1.Show();
        }

        private void question2Savebtn_Click(object sender, EventArgs e)
        {
            GreyIcon2.Hide();
            GreenIcon2.Show();
        }

        private void ExamForm_Load(object sender, EventArgs e)
        {
            label19.Text = DateTime.Now.ToLongDateString();

            Namelabel.Text = LogInForm.passingText;

            h = Convert.ToInt32(01);
            m = Convert.ToInt32(59);
            s = Convert.ToInt32(59);

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s = s - 1;
            if (s == -1)
            {
                m = m - 1;
                s = 59;
            }

            if (m == -1)
            {
                h = h - 1;
                m = 59;
            }
            if (h == 0 && m == 0 && s == 0)
            {
                timer1.Stop();
                MessageBox.Show("Time is UP");
            }

            string hh = Convert.ToString(h);
            string mm = Convert.ToString(m);
            string ss = Convert.ToString(s);

            label99.Text = hh;
            label88.Text = mm;
            label77.Text = ss;
        }

        private void Namelabel_Click(object sender, EventArgs e)
        {
            //Namelabel.Text= CurrentIDTextBox.Text;
        }

        private void question3Savebtn_Click(object sender, EventArgs e)
        {
            GreyIcon3.Hide();
            GreenIcon3.Show();
        }

        private void question4Savebtn_Click(object sender, EventArgs e)
        {
            GreyIcon4.Hide();
            GreenIcon4.Show();
        }

        private void question5Savebtn_Click(object sender, EventArgs e)
        {
            GreyIcon5.Hide();
            GreenIcon5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want To Submit Exam?", "SUBMIT EXAM?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                this.Hide();
                Results results = new Results();
                results.ShowDialog();
                

                //Application.Exit();
            }
        }

       
    }
}
