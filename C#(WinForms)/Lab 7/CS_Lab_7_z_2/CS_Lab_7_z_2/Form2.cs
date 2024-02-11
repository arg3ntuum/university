using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Lab_7_z_2
{
    public partial class Form2 : Form
    {
        
        public static Color thiscolor;
        public Form2()
        {
            InitializeComponent();
            checkFill();
            checkColor();
        }

        private void checkFill() {
            if (Form1.fill == true)
                fill.Checked = true;
            else fill.Checked = false;
        }
        private void checkColor()
        {
            if (Form1.color == Color.Black)
                butBlack.Checked = true;
            else if (Form1.color == Color.Green)
                butGreen.Checked = true;
            else if (Form1.color == Color.Red)
                butRed.Checked = true;
            else if (Form1.color == Color.Blue)
                butBlue.Checked = true;
            else if (Form1.color == Color.Yellow)
                butYellow.Checked = true;
            else if (Form1.color == Color.White)
                butWhite.Checked = true;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void OKBut_Click(object sender, EventArgs e)
        {
            Form1.color = thiscolor;
            Hide();
        }

        private void CancelBut_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void butBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (butBlack.Checked == true) {
                thiscolor = Color.Black;
            }
        }

        private void butGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (butGreen.Checked == true)
            {
                thiscolor = Color.Green;
            }
        }

        private void butRed_CheckedChanged(object sender, EventArgs e)
        {
            if (butRed.Checked == true)
            {
                thiscolor = Color.Red;
            }
        }

        private void butBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (butBlue.Checked == true)
            {
                thiscolor = Color.Blue;
            }
        }

        private void butYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (butYellow.Checked == true)
            {
                thiscolor = Color.Yellow;
            }
        }

        private void butWhite_CheckedChanged(object sender, EventArgs e)
        {
            if (butWhite.Checked == true)
            {
                thiscolor = Color.White;
            }
        }

        private void fill_CheckedChanged(object sender, EventArgs e)
        {
            if (fill.Checked == true)
                Form1.fill = true;
            else Form1.fill = false;
        }
    }
}
