using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Lab_5_z_2
{
    public partial class Form1 : Form
    {
        string whiteText = "Выбран белый фон.", redText = "Выбран красный фон.", blueText = "Выбран синий фон.";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        protected void setChecked(byte choose, string text) {
            menuRed.Checked = false;
            menuBlue.Checked = false;
            menuWhite.Checked = false;

            instrumentRed.Checked = false;
            instrumentBlue.Checked = false;
            instrumentWhite.Checked = false;

            if (choose == 1) {
                menuRed.Checked = true;
                instrumentRed.Checked = true;
            }
            else if (choose == 2) {
                menuBlue.Checked = true;
                instrumentBlue.Checked = true;
            }
            else if (choose == 3) {
                menuWhite.Checked = true;
                instrumentWhite.Checked = true;
            }
            toolStripStatusLabel1.Text = text;
        }
        protected void setBackground(byte nomer) {
            if (nomer == 1)
            {
                statusStrip2.BackColor = Color.Red;
                this.BackColor = Color.Red;
                Costil();
            }
            else if (nomer == 2)
            {
                statusStrip2.BackColor = Color.Blue;
                this.BackColor = Color.Blue;
                Costil();
            }
            else if (nomer == 3) {
                statusStrip2.BackColor = Color.White;
                this.BackColor = Color.White;
                Costil();
            }
        }
        private void Costil() {
            statusStrip1.BackColor = Color.White;
        }
        private void menu_Click(object sender, EventArgs e)
        {

        }

        private void menuRed_Click(object sender, EventArgs e)
        {
            setChecked(1, redText);
            setBackground(1);
        }

        private void menuBlue_Click(object sender, EventArgs e)
        {
            setChecked(2, blueText);
            setBackground(2);
        }

        private void menuWhite_Click(object sender, EventArgs e)
        {
            setChecked(3, whiteText);
            setBackground(3);
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void instrumentRed_Click(object sender, EventArgs e)
        {
            setChecked(1, redText);
            setBackground(1);
        }

        private void instrumentBlue_Click(object sender, EventArgs e)
        {
            setChecked(2, blueText);
            setBackground(2);
        }

        private void instrumentWhite_Click(object sender, EventArgs e)
        {
            setChecked(3, whiteText);
            setBackground(3);
        }
    }
}
