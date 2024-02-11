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
    public partial class frmContainer : Form
    {
        private int nextFormNumber = 2;
        public frmContainer()

        {

            InitializeComponent();

            // Создание нового экземпляра дочерней формы

            CS_Lab_6.frmChild child = new CS_Lab_6.frmChild(this, "Редактор 1");

            // Вывод созданной формы

            child.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MenuItemNewWindow_Click(object sender, EventArgs e)
        {
            // Создание нового экземпляра дочерней формы

            frmChild newChild = new frmChild(this, "Редактор" + nextFormNumber++);

            // Вывод созданной формы

            newChild.Show();
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuItemTile_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void MenuItemCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void MenuItemClose_Click(object sender, EventArgs e)
        {
            // Определение активного дочернего MDI-окна

            frmChild frm = (frmChild)this.ActiveMdiChild;

            if (frm != null) // Перед тем как использовать потолок,

            // необходимо убедиться в том, что он доступен

            {// Закрытие окна

                frm.Close();

            }
        }
    }
}
