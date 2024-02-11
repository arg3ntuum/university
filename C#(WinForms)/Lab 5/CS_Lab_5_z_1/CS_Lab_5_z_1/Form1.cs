using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Lab_5_z_1
{
    public partial class Form1 : Form
    {
        public enum Tools
        {
            PEN = 1, TEXT, LINE, ELLIPSE, NULL = 0
        }
        Tools curentTool;
        public Form1()
        {
            InitializeComponent();
        }

        protected void instrumendsChecked(byte truue) { 
            menuItemPen.Checked = false;
            menuItemText.Checked = false;
            menuItemLine.Checked = false;
            menuItemEIIipse.Checked = false;

            if (truue == 1)
                menuItemPen.Checked = true;
            else if (truue == 2)
                menuItemText.Checked = true;
            else if (truue == 3)
                menuItemLine.Checked = true;
            else if (truue == 4)
                menuItemEIIipse.Checked = true;
        }

        protected void setStatus(string text) {
            statusStrip1.Items[0].Text = text;
        }
        protected void setStrip(byte choose)
        {
            toolStripButtonPen.Checked = false;
            toolStripButtonText.Checked = false;
            toolStripButtonLine.Checked = false;
            toolStripButtonEllipse.Checked = false;

            if (choose == 1)
                toolStripButtonPen.Checked = true;
            else if (choose == 2)
                toolStripButtonText.Checked = true;
            else if (choose == 3)
                toolStripButtonLine.Checked = true;
            else if (choose == 4)
                toolStripButtonEllipse.Checked = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void SetToolStripButtonsPushedState(ToolStripItem button)
        {
            foreach (ToolStripButton btnItem in toolStrip1.Items)
            {
                if (btnItem == button) { btnItem.Checked = true; }
                else { btnItem.Checked = false; }
            }
        }
        protected void takePen() {
            curentTool = Tools.PEN;
            setStatus("Выбран карандаш");
            instrumendsChecked(1);
        }
        protected void takeText()
        {
            curentTool = Tools.TEXT;
            setStatus("Создание надписей");
            instrumendsChecked(2);
        }
        protected void takeLine()
        {
            curentTool = Tools.LINE;
            setStatus("Рисование линий");
            instrumendsChecked(3);
        }
        protected void takeEllipse()
        {
            curentTool = Tools.ELLIPSE;
            setStatus("Рисование эллипса");
            instrumendsChecked(4);
        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "toolStripButtonPen":
                    takePen();
                    break;

                case "toolStripButtonText":
                    takeText();
                    break;

                case "toolStripButtonLine":
                    takeLine();
                    break;

                case "toolStripButtonEllipse":
                    takeEllipse();
                    break;
            }

            SetToolStripButtonsPushedState(e.ClickedItem);
        }

        private void menuItemPen_Click(object sender, EventArgs e) {
            takePen();
            setStrip(1);
        }

        private void menuItemText_Click(object sender, EventArgs e) {
            takeText();
            setStrip(2);
        }

        private void menuItemLine_Click(object sender, EventArgs e) {
            takeLine();
            setStrip(3);
        }

        private void menuItemEIIipse_Click(object sender, EventArgs e) {
            takeEllipse();
            setStrip(4);
        }
    }
}
