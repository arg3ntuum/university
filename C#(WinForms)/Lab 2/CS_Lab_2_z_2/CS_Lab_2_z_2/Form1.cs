using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Lab_2_z_2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            this.Text = comboBox1.Text;
            
            listBox1.SelectedIndex = 2;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        protected void changeFont(string font) {
            label1.Font = new System.Drawing.Font(font, 18F);
            winter.Font = new System.Drawing.Font(font, 16F);
            sunset.Font = new System.Drawing.Font(font, 16F);
            lilia.Font = new System.Drawing.Font(font, 16F);
            hill.Font = new System.Drawing.Font(font, 16F);
            height.Font = new System.Drawing.Font(font, 15F);
            width.Font = new System.Drawing.Font(font, 15F);
            numHeight.Font = new System.Drawing.Font(font, 15F);
            numWidth.Font = new System.Drawing.Font(font, 15F);
            comboBox1.Font = new System.Drawing.Font(font, 16F);
            label2.Font = new System.Drawing.Font(font, 18F);
            listBox1.Font = new System.Drawing.Font(font, 16F);
        }
       

        private void numHeight_ValueChanged(object sender, EventArgs e) {
            this.Size = new Size(this.Size.Width, (int)numHeight.Value);
            
        }
        private void numWidth_ValueChanged(object sender, EventArgs e) { 
            this.Size = new Size((int)numWidth.Value, this.Size.Height);
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            this.Text = comboBox1.Text;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
                changeFont("Times New Roman");
            else if (listBox1.SelectedIndex == 1)
                changeFont("Arial");
            else if (listBox1.SelectedIndex == 2)
                changeFont("Ms Sans Serif");
        }

        private void winter_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.winter;
        }

        private void sunset_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.sunset;
        }

        private void lilia_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.lilia;
        }

        private void hill_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.hills;
        }
    }
}
