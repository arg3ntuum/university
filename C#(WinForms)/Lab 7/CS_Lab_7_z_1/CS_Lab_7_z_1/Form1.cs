using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace CS_Lab_7_z_1
{
    public partial class Form1 : Form
    {
        bool num1bool = false, num2bool = false, numupdate = false;
        bool pluss = false, minuss = false, multi = false, divs = false;
        Font defFont;  
        decimal num1, num2;
        public Form1()
        {
            InitializeComponent();
            defFont = window.Font;
        }
        protected void setNumber(byte num) {
            if(window.Text == "0")
                window.Text = "" + num;
            else window.Text += num;
            updateNum();
        }
        protected void deleteLastNumber() {
            if (window.Text.Length == 1)
                window.Text = "0";
            else window.Text = window.Text.Remove(window.Text.Length - 1);
        }
        protected void operation(byte choose) {
            if (divs == true)
            {
                if (num1bool == false)
                {
                    num1 = Convert.ToDecimal(window.Text);
                    window.Text = "0";
                    num1bool = true;
                }
                else if (num1bool == true)
                {
                    if (numupdate == true)
                        num2 = Convert.ToDecimal(window.Text);
                    operChooseAndTextUpdate(1);
                }
            }
            else if (multi == true)
            {
                if (num1bool == false)
                {
                    num1 = Convert.ToDecimal(window.Text);
                    window.Text = "0";
                    num1bool = true;
                }
                else if (num1bool == true)
                {
                    if (numupdate == true)
                        num2 = Convert.ToDecimal(window.Text);
                     operChooseAndTextUpdate(2);
                }
            }
            else if (minuss == true)
            {
                if (num1bool == false)
                {
                    num1 = Convert.ToDecimal(window.Text);
                    window.Text = "0";
                    num1bool = true;
                }
                else if (num1bool == true)
                {
                    if (numupdate == true)
                        num2 = Convert.ToDecimal(window.Text);
                    operChooseAndTextUpdate(3);
                }
            }
            else if (pluss == true)
            {
                if (num1bool == false)
                {
                    num1 = Convert.ToDecimal(window.Text);
                    window.Text = "0";
                    num1bool = true;
                }
                else if (num1bool == true)
                {
                    if (numupdate == true)
                        num2 = Convert.ToDecimal(window.Text);
                    operChooseAndTextUpdate(4);
                }
            }
            else { 
                num1 = Convert.ToDecimal(window.Text);
                window.Text = "0";
            }
            
        }
        protected void operChooseAndTextUpdate(byte choose) {
            bool error = false;
            switch (choose) {
                case 1: try { 
                        num1 = num1 / num2; 
                    } 
                    catch (System.DivideByZeroException) { 
                        
                        error = true; 
                    } 
                    break;
                case 2: num1 = num1 * num2; break;
                case 3: num1 = num1 - num2; break;
                case 4: num1 = num1 + num2; break;
            }
            if (error == false)
            {
                window.Text = "" + Math.Round(num1, 5);
            }
            else NullUpdate();

            numupdate = false;
        }
        private void NullUpdate() {
            window.Text = "Деление на ноль невозможно";
        }
        protected void UpdateTrueFalse(byte choose) {
            divs = false;
            multi = false;
            minuss = false;
            pluss = false;
            if (choose == 1) divs = true;
            else if (choose == 2) multi = true;
            else if (choose == 3) minuss = true;
            else if (choose == 4) pluss = true;
        }
        protected void updateNum() {
            if (window.Text != "0")
                numupdate = true;
            else numupdate = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void exit_MouseLeave(object sender, EventArgs e)
        { 
            byte defExit = 240;
            exit.BackColor = System.Drawing.Color.FromArgb(defExit, defExit, defExit);
            exit.ForeColor = System.Drawing.Color.Black;
            window.BackColor = System.Drawing.Color.FromArgb(defExit, defExit, defExit);
        }
        private void exit_MouseEnter(object sender, EventArgs e)
        {
            exit.BackColor = System.Drawing.Color.Red;
            exit.ForeColor = System.Drawing.Color.White;
        }
        Point lastpoint;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e) {
            lastpoint = new Point(e.X, e.Y);
        }

        

        private void CE_Click(object sender, EventArgs e)
        {
            if (num1bool == true)
            {
                window.Text = "0";
                num2bool = false;
            }
            else window.Text = "0";
            updateNum();
        }
        private void C_Click(object sender, EventArgs e)
        {
            window.Text = "0";
            num1bool = num2bool = false;
            num1 = num2 = 0;
            updateNum();
        }
        private void delete_Click(object sender, EventArgs e)
        {
            deleteLastNumber();
            updateNum();
        }
        private void zero_Click(object sender, EventArgs e)
        {
            setNumber(0);
        }
        private void one_Click(object sender, EventArgs e)
        {
            setNumber(1);
        }
        private void two_Click(object sender, EventArgs e)
        {
            setNumber(2);
        }
        private void three_Click(object sender, EventArgs e)
        {
            setNumber(3);
        }
        private void four_Click(object sender, EventArgs e)
        {
            setNumber(4);
        }
        private void five_Click(object sender, EventArgs e)
        {
            setNumber(5);
        }
        private void six_Click(object sender, EventArgs e)
        {
            setNumber(6);
        }
        private void seven_Click(object sender, EventArgs e)
        {
            setNumber(7);
        }
        private void eight_Click(object sender, EventArgs e)
        {
            setNumber(8);
        }
        private void nine_Click(object sender, EventArgs e)
        {
            setNumber(9);
        }
 
        private void div_Click(object sender, EventArgs e)
        {
            UpdateTrueFalse(1);
            if (num1bool == false)
            {
                num1 = Convert.ToDecimal(window.Text);
                window.Text = "0";
                num1bool = true;
            }
            else if (num1bool == true) {
                if (numupdate == true)
                    num2 = Convert.ToDecimal(window.Text);
                operChooseAndTextUpdate(1);
            }
        }
        private void mult_Click(object sender, EventArgs e)
        {
            UpdateTrueFalse(2);
            if (num1bool == false)
            {
                num1 = Convert.ToDecimal(window.Text);
                window.Text = "0";
                num1bool = true;
            }
            else if (num1bool == true)
            {
                if (numupdate == true)
                    num2 = Convert.ToDecimal(window.Text);
                operChooseAndTextUpdate(2);
            }

        }
        private void minus_Click(object sender, EventArgs e)
        {
            UpdateTrueFalse(3);
            if (num1bool == false)
            {
                num1 = Convert.ToDecimal(window.Text);
                window.Text = "0";
                num1bool = true;
            }
            else if (num1bool == true)
            {
                if (numupdate == true)
                    num2 = Convert.ToDecimal(window.Text);
                operChooseAndTextUpdate(3);
            }
        }
        private void plus_Click(object sender, EventArgs e)
        {
            UpdateTrueFalse(4);
            if (num1bool == false)
            {
                num1 = Convert.ToDecimal(window.Text);
                window.Text = "0";
                num1bool = true;
            }
            else if (num1bool == true)
            {
                if (numupdate == true)
                    num2 = Convert.ToDecimal(window.Text);
                operChooseAndTextUpdate(4);
            }
        }

        private void plusMinus_Click(object sender, EventArgs e)
        {
            if(window.Text != "0")
            if (window.Text.Contains("-") == false)
                window.Text = window.Text.Insert(0, "-");
            else window.Text = window.Text.Replace("-", "");
        }

        private void point_Click(object sender, EventArgs e)
        {
            if (window.Text.Contains(',') == false)
                window.Text += ',';
        }
        private void equals_Click(object sender, EventArgs e)
        {
            if (numupdate == true)
            {
                if (pluss == true)
                    operation(4);
                else if (minuss == true)
                    operation(3);
                else if (multi == true)
                    operation(2);
                else if (divs == true)
                    operation(1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 newForm = new Form2();
            newForm.Show();
        }
        private void equals_MouseEnter(object sender, EventArgs e)
        {
            int newColor = 100;
            equals.BackColor = System.Drawing.Color.FromArgb(newColor, newColor, newColor);

        }
        private void equals_MouseLeave(object sender, EventArgs e)
        {
            byte defravno = 171;
            equals.BackColor = System.Drawing.Color.FromArgb(defravno, defravno, defravno);
        }





        //мордор
        private void CE_MouseEnter(object sender, EventArgs e)
        {

        }
        private void CE_MouseLeave(object sender, EventArgs e)
        {

        }
        private void C_MouseEnter(object sender, EventArgs e)
        {

        }
        private void C_MouseLeave(object sender, EventArgs e)
        {

        }
        private void delete_MouseEnter(object sender, EventArgs e)
        {

        }
        private void delete_MouseLeave(object sender, EventArgs e)
        {

        }
        private void div_MouseEnter(object sender, EventArgs e)
        {

        }
        private void div_MouseLeave(object sender, EventArgs e)
        {

        }
        private void seven_MouseEnter(object sender, EventArgs e)
        {

        }
        private void seven_MouseLeave(object sender, EventArgs e)
        {

        }
        private void eight_MouseEnter(object sender, EventArgs e)
        {

        }
        private void eight_MouseLeave(object sender, EventArgs e)
        {

        }
        private void nine_MouseEnter(object sender, EventArgs e)
        {

        }
        private void nine_MouseLeave(object sender, EventArgs e)
        {

        }
        private void mult_MouseEnter(object sender, EventArgs e)
        {

        }
        private void mult_MouseLeave(object sender, EventArgs e)
        {

        }
        private void four_MouseEnter(object sender, EventArgs e)
        {

        }
        private void four_MouseLeave(object sender, EventArgs e)
        {

        }
        private void five_MouseEnter(object sender, EventArgs e)
        {

        }
        private void five_MouseLeave(object sender, EventArgs e)
        {

        }
        private void six_MouseEnter(object sender, EventArgs e)
        {

        }
        private void six_MouseLeave(object sender, EventArgs e)
        {

        }
        private void minus_MouseEnter(object sender, EventArgs e)
        {

        }
        private void minus_MouseLeave(object sender, EventArgs e)
        {

        }
        private void one_MouseEnter(object sender, EventArgs e)
        {

        }
        private void one_MouseLeave(object sender, EventArgs e)
        {

        }
        private void two_MouseEnter(object sender, EventArgs e)
        {

        }
        private void two_MouseLeave(object sender, EventArgs e)
        {

        }
        private void three_MouseEnter(object sender, EventArgs e)
        {

        }
        private void three_MouseLeave(object sender, EventArgs e)
        {

        }
        private void plus_MouseEnter(object sender, EventArgs e)
        {

        }
        private void plus_MouseLeave(object sender, EventArgs e)
        {

        }
        private void plusMinus_MouseEnter(object sender, EventArgs e)
        {

        }
        private void plusMinus_MouseLeave(object sender, EventArgs e)
        {

        }
        private void zero_MouseEnter(object sender, EventArgs e)
        {

        }
        private void zero_MouseLeave(object sender, EventArgs e)
        {

        }
        private void point_MouseEnter(object sender, EventArgs e)
        {

        }
        private void point_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
