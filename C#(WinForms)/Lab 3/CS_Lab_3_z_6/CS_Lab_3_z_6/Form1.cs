using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Lab_3_z_6
{
    public partial class Form1 : Form
    {
        string nameFile = "test.rtf";
        bool underline = false, bold = false, italic = false;
        public Form1()
        {
            InitializeComponent();
            updateSize();
        }

        protected void updateSize() {
            textSize.Text = richTextBox.SelectionFont.Size.ToString();
        }
        protected void setFontStyle(bool bool1, FontStyle font)
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, font);
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openBut_Click(object sender, EventArgs e)
        {
            richTextBox.LoadFile(nameFile);
            updateSize();
        }

        private void saveBut_Click(object sender, EventArgs e)
        {
            richTextBox.SaveFile(nameFile);
        }

        private void textSize_TextChanged(object sender, EventArgs e)
        {
            if (textSize.Text != "")
                Fignya();
        }

        private void Fignya()
        {
            try { 
                if (richTextBox.Text != "" && float.Parse(textSize.Text) > 1.0f)
                    richTextBox.Font = new Font(richTextBox.Font.Name, float.Parse(textSize.Text), richTextBox.Font.Style);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("ЕФРРРРррР");
            }
        }

        private void Podcherknutiy_Click(object sender, EventArgs e)
        {
            if (underline == false)
                setFontStyle(underline = true, FontStyle.Underline);
            else setFontStyle(underline = false, FontStyle.Regular);
        }

        private void Poluzhirniy_Click(object sender, EventArgs e)
        {
            if (bold == false)
                setFontStyle(bold = true, FontStyle.Bold);
            else setFontStyle(bold = false, FontStyle.Regular);
        }

        private void Naklonniy_Click(object sender, EventArgs e)
        {
            if (italic == false)
                setFontStyle(italic = true, FontStyle.Italic);
            else setFontStyle(italic = false, FontStyle.Regular);
        }

        private void center_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionAlignment == HorizontalAlignment.Left)
                richTextBox.SelectionAlignment = HorizontalAlignment.Center;
            else
                richTextBox.SelectionAlignment = HorizontalAlignment.Left;
        }
    }
}
