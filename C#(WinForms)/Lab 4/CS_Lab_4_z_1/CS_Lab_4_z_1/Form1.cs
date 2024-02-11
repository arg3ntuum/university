using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* **************************************/
/*          Странный баг с переключением*/
/* **************************************/
namespace CS_Lab_4_z_1
{
    public partial class Form1 : Form
    {
        bool vertical = true, horizontal = false;
        public Form1()
        {
            InitializeComponent();
        }

        protected void check() {
            if (horizontal == true)
                trackBar1.Orientation = Orientation.Horizontal;
            else if (vertical == true) 
                trackBar1.Orientation = Orientation.Vertical;
        }

        private void menuItemCommand_Click(object sender, EventArgs e)
        {

        }

        private void menuItemAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Добавление");
        }

        private void menuItemDelі_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Удаление");
        }

        private void menuItemMove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Перемещение");
        }

        private void уведомитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            string message = item.Text;
            MessageBox.Show(message);
        }

        private void menuItemNone_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            string text = item.Text;
            switch (text)
            {
                case "Пусто":
                    check();
                    trackBar1.TickStyle = TickStyle.None;
                    check();
                    break;
                case "Сверху-слева":
                    check();
                    trackBar1.TickStyle = TickStyle.TopLeft;
                    check();
                    break;
                case "Снизу-справа":
                    check();
                    trackBar1.TickStyle = TickStyle.BottomRight;
                    check();
                    break;
                case "С обеих сторон":
                    check();
                    trackBar1.TickStyle = TickStyle.Both;
                    check();
                    break;
            }
            // проходим по всем подпунктам изменяющим стиль бегунка
            // расположенным в основном меню программы
            foreach (ToolStripMenuItem item1 in menuItemTrackBar.DropDownItems)
            {
                // если текст меню совпадает с переданным параметром,
                // то помечаем пункт меню
                if (item1.Text == text)
                    item1.Checked = true;
                // если текст меню не совпадает с переданным параметром,
                // то снимаем пометку с пункта меню
                else item1.Checked = false;
            }
            // проходим по всем подпунктам, изменяющим стиль бегунка и
            // расположенных в контекстном меню программы
            foreach (ToolStripMenuItem item1 in contextMenuStrip2.Items)
            {
                // если текст меню совпадает с переданным параметром,
                // то помечаем пункт меню
                if (item1.Text == text)
                    item1.Checked = true;
                // если текст меню не совпадает с переданным параметром,
                // то снимаем пометку с пункта меню
                else
                    item1.Checked = false;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void horizontalOrin_Click(object sender, EventArgs e)
        {
            horizontal = true;
            vertical = false;
            trackBar1.Orientation = Orientation.Horizontal;
        }

        private void verticalOrin_Click(object sender, EventArgs e)
        {
            horizontal = false;
            vertical = true;
            trackBar1.Orientation = Orientation.Vertical;
        }
    }
}
