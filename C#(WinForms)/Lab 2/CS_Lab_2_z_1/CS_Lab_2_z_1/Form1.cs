using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Lab_2_z_1
{
    public partial class Form1 : Form {
        public decimal m = 0, s = 0, ms = 0, h = 0;
        public Form1() {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            stop.Enabled = false;
            start.Enabled = false;

            progressBar1.Step = -progressBar1.Step;
        }

        protected void changeNums() {
            if (comboBox1.SelectedIndex == 0) {
                numericUpDown1.Maximum = 86400;
                h = Decimal.Floor(numericUpDown1.Value / 3600.0M);
                m = Decimal.Floor(numericUpDown1.Value / 60.0M - h * 60.0M);
                s = Decimal.Floor(numericUpDown1.Value - m * 60.0M - h * 60.0M * 60.0M);
            }
            else if (comboBox1.SelectedIndex == 1) {
                numericUpDown1.Maximum = 1440;
                h = Decimal.Floor(numericUpDown1.Value / 60.0M);
                m = Decimal.Floor(numericUpDown1.Value - h * 60.0M);
                s = 0;
            }
            else if (comboBox1.SelectedIndex == 2) {
                numericUpDown1.Maximum = 24;
                h = Decimal.Floor(numericUpDown1.Value);
                m = 0;
                s = 0;
            }
        }
        protected void changeText() { 
            if (s < 10) timeZeroSecond.Text = "0" + s.ToString();
            else        timeZeroSecond.Text = "" + s.ToString();
            if (m < 10) timeZeroMinutes.Text = "0" + m.ToString();
            else        timeZeroMinutes.Text = "" + m.ToString();
            if (h < 10) timeZeroHours.Text = "0" + h.ToString();
            else        timeZeroHours.Text = "" + h.ToString();
            this.Text = timeZeroHours.Text + timeZeroPoints1.Text + timeZeroMinutes.Text + timeZeroPoints2.Text + timeZeroSecond.Text;
        }
        protected void updateTime() {
            if (s > 0)
                s--;
            else if (s == 0 && m > 0) { 
                m--;
                s = 59;
            }
            else if (s == 0 && m == 0 && h > 0)
            {
                h--;
                m = 59;
                s = 59;
            }
              
        }
        private void timeText_Click(object sender, EventArgs e){ }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            changeNums();
            changeText();
        }

        private void timeZeroHours_Click(object sender, EventArgs e) { }

        private void start_Click(object sender, EventArgs e)
        {
            timer1.Start();
            stop.Enabled = true;
            numericUpDown1.Enabled = false;
            comboBox1.Enabled = false;
            if (comboBox1.SelectedIndex == 0)
               progressBar1.Maximum = (int)numericUpDown1.Value;
            else if (comboBox1.SelectedIndex == 1)
                progressBar1.Maximum = (int)numericUpDown1.Value* 60;
            else if (comboBox1.SelectedIndex == 2)
                progressBar1.Maximum = (int)numericUpDown1.Value * 3600;
            
        }

        private void stop_Click(object sender, EventArgs e) 
        {
            stop.Enabled = false;
            timeZeroPoints1.Visible = true;
            timeZeroPoints2.Visible = true;
            timer1.Stop();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e) {
            updateTime();
            changeText();
            ProgressBarController();
            if (timeZeroPoints1.Visible == true) timeZeroPoints1.Visible = false;
            else                                 timeZeroPoints1.Visible = true;

            if (timeZeroPoints2.Visible == true) timeZeroPoints2.Visible = false;
            else                                 timeZeroPoints2.Visible = true;
            if (h == 0 && m == 0 && s == 0) {
                
                Application.Exit();
            }
        }



        private void ProgressBarController()
        {
            progressBar1.PerformStep() ;

        }
        private void Form1_Load(object sender, EventArgs e) { }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
            changeNums();
            changeText();
            if (h == 0 && m == 0 && s == 0)
                start.Enabled = false;
            else start.Enabled = true;
        }

    }
}
