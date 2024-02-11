using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Lab_3_z_1_punkt_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(textBox1.Text, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // получаем выделенный узел
            TreeNode node = treeView1.SelectedNode;
            // если выделенного узла нет
            if (node == null)
            {   // добавляем новый элемент
                // в корень основного дерева
                TreeNode newNode = new TreeNode();
                newNode.Text = textBox1.Text;
                newNode.ImageIndex = 1;
                treeView1.Nodes.Add(newNode);
            }
            // если имеется выделенный узел
            else
            {   // добавляем новый элемент
                // как вложенный в выделенный узел
                TreeNode newNode = new TreeNode();
                newNode.Text = textBox1.Text;
                newNode.ImageIndex = 0;
                node.Nodes.Add(newNode);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
