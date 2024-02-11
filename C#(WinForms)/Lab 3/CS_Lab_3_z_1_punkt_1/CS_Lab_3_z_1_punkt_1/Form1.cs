using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Lab_3_z_1_punkt_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addList_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(textBox1.Text);
        }

        private void addTree_Click(object sender, EventArgs e)
        {   // получаем выделенный узел
            TreeNode node = treeView1.SelectedNode;
            // если выделенного узла нет
            if (node == null)
            {   // добавляем новый элемент
                // в корень основного дерева
                treeView1.Nodes.Add(textBox1.Text);
            }
            // если имеется выделенный узел
            else
            {   // добавляем новый элемент
                // как вложенный в выделенный узел
                node.Nodes.Add(textBox1.Text);
            }
        }
    }
}
