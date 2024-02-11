using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Lab_7_z_3
{
    public partial class Form1 : Form
    {
        private string[] lines;

        private int linesPrinted; // счетчик напечатанных строк
        private string fileName = "Untitled";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileName = "Untitled";
            textBoxEdit.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                fileName = dlgOpen.FileName;
                //новый код, открывает и читает файл
                try
                {
                    using (StreamReader reader = File.OpenText(fileName))
                    {
                        textBoxEdit.Clear();
                        textBoxEdit.Text = reader.ReadToEnd();
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Simple Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileName == "Untitled")

                saveAsToolStripMenuItem_Click(sender, e);
            else
            {
                try
                {
                    Stream stream = File.OpenWrite(fileName);
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        writer.Write(textBoxEdit.Text);
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Simple Editor",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                fileName = dlgSave.FileName;
                //новый код, запись в файл
                try
                {
                    Stream stream = File.OpenWrite(fileName);
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        writer.Write(textBoxEdit.Text);
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Simple Editor",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //int x = 20;

            //int y = 20;

            int x = e.MarginBounds.Left;

            int y = e.MarginBounds.Top;

            while (linesPrinted < lines.Length)
            {
                Brush brush = new SolidBrush(textBoxEdit.ForeColor);
                //if (.)//textBoxEdit.ForeColor
                e.Graphics.DrawString(lines[linesPrinted++], new Font(textBoxEdit.Font.FontFamily, textBoxEdit.Font.Height), brush, x, y);//Brushes

                y += 15;

                // if (y >= e.PageBounds.Height - 80)

                if (y >= e.MarginBounds.Bottom)

                {

                    e.HasMorePages = true;

                    linesPrinted = 0;

                    e.HasMorePages = false;

                }

            }
        }

        private void printDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            char[] param = { '\n' };

            lines = textBoxEdit.Text.Split(param);

            int i = 0;

            char[] trimParam = { '\r' };

            foreach (string s in lines)

            {

                lines[i++] = s.TrimEnd(trimParam);

            }
        }

        private void dlgPageSetup_HelpRequest(object sender, EventArgs e) {}

        private void pageSetuoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlgPageSetup.ShowDialog();
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            printDialog.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog.ShowDialog();
        }

        private void fontMenu_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
                textBoxEdit.Font = fontDialog.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                textBoxEdit.ForeColor = colorDialog.Color;
        }
    }
}
