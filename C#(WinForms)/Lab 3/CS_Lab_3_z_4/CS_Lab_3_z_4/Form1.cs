using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Lab_3_z_4
{
    public partial class Form1 : Form
    {
        int red , blue, green;
        public Form1()
        {
            InitializeComponent();
            red = this.BackColor.R;
            blue = this.BackColor.B;
            green = this.BackColor.G;
            updateText();
            updateScroll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateText();
        }
        protected void updateBackground() {
            this.BackColor = Color.FromArgb(red, blue, green);
        }
        protected void updateText()
        {
            labelBlue.Text = "" + blue;
            labelRed.Text = "" + red;
            labelGreen.Text = "" + green;
        }
        protected void updateScroll() {
            hScrollBar2.Value = blue;
            hScrollBar1.Value = red;
            hScrollBar3.Value = green;
        }
        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            blue = hScrollBar2.Value;
            updateText();
            updateBackground();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            red = hScrollBar1.Value;
            updateText();
            updateBackground();
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            green = hScrollBar3.Value;
            updateText();
            updateBackground();
        }
    }
}
