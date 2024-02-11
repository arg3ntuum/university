using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Lab_6
{
    public partial class frmChild : Form
    {
        public frmChild(CS_Lab_6.frmContainer parent, string caption)
        {

            InitializeComponent();

            // Присваивание контейнеру родителя данной формы

            this.MdiParent = parent;

            //Задание заголовка

            this.Text = caption;

        }

        private void frmChild_Load(object sender, EventArgs e)
        {

        }

        protected void bold() { 
        Font newFont = new Font(rtfText.SelectionFont, //1
             (rtfText.SelectionFont.Bold ? //2
            rtfText.SelectionFont.Style & ~FontStyle.Bold : //3
            rtfText.SelectionFont.Style | FontStyle.Bold)); //4
            rtfText.SelectionFont = newFont; //5
        }
        protected void italic()
        {
           Font newFont = new Font(rtfText.SelectionFont, //1
           (rtfText.SelectionFont.Italic ? //2
           rtfText.SelectionFont.Style & ~FontStyle.Italic : //3
           rtfText.SelectionFont.Style | FontStyle.Italic)); //4
           rtfText.SelectionFont = newFont; //5
        }
        protected void underline()
        {
           Font newFont = new Font(rtfText.SelectionFont, //1
           (rtfText.SelectionFont.Underline ? //2
           rtfText.SelectionFont.Style & ~FontStyle.Underline : //3
           rtfText.SelectionFont.Style | FontStyle.Underline)); //4
           rtfText.SelectionFont = newFont; //5
        }
        protected void check() {
            this.menuCut.Enabled = rtfText.SelectedText.Length > 0 ? true : false;
            this.menuCopy.Enabled = rtfText.SelectedText.Length > 0 ? true : false;
            this.menuPaste.Enabled = Clipboard.ContainsText() ? true : false;
        }
        private void MenuItemBold_Click(object sender, EventArgs e)
        {
            bold();
        }

        private void MenuItemItalic_Click(object sender, EventArgs e)
        {
            italic();
        }

        private void MenuItemUnderline_Click(object sender, EventArgs e)
        {
            underline();
        }

        private void MenuItemFile_Click(object sender, EventArgs e)
        {

        }

        private void MenuItemNew_Click(object sender, EventArgs e)
        {
            this.rtfText.Clear();
        }

        private void MenuItemOpen_Click(object sender, EventArgs e)
        {
            this.rtfText.LoadFile("test.rtf");
        }

        private void MenuItemSave_Click(object sender, EventArgs e)
        {
            rtfText.SaveFile("test.rtf");
        }

        private void toolBold_Click(object sender, EventArgs e)
        {
            bold();
        }

        private void toolKursive_Click(object sender, EventArgs e)
        {
            italic();

        }

        private void toolUnderline_Click(object sender, EventArgs e)
        {
            underline();
            
        }

        private void menuUndo_Click(object sender, EventArgs e)
        {
            rtfText.Undo();
            
        }

        private void menuRedo_Click(object sender, EventArgs e)
        {
            rtfText.Redo();
            
        }

        private void menuCopy_Click(object sender, EventArgs e)
        {
            rtfText.Copy();
            
        }

        private void menuCut_Click(object sender, EventArgs e)
        {
            rtfText.Cut();
            
        }

        private void menuPaste_Click(object sender, EventArgs e)
        {
            rtfText.Paste();
            
        }

        private void rtfText_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void toolPravka_Click(object sender, EventArgs e)
        {
            check();
        }
    }
}
