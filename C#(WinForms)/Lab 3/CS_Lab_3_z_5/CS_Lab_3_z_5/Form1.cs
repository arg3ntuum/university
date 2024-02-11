using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Lab_3_z_5
{
    public partial class Form1 : Form
    {
        bool name = false, address = false, woman = false, man = false, years = false, jobs = false;

        protected void updateButton() {
            if (name == true && address == true && (woman == true || man == true) && years == true)
                ButOk.Enabled = true;
            else ButOk.Enabled = false;

        }

        private void butWomen_CheckedChanged(object sender, EventArgs e)
        {
            if (man == true)
                man = false;
            woman = true;
            updateButton();
        }

        private void butMan_CheckedChanged(object sender, EventArgs e)
        {
            if (woman == true)
                woman = false;
            man = true;
            updateButton();
        }

        private void ButOk_Click(object sender, EventArgs e)
        {
            OutList.Items.Clear();
            OutList.Items.Add("Имя: " + nameText.Text);
            OutList.Items.Add("Адрес: " + adressText.Text);
            if (butWomen.Checked)
                OutList.Items.Add("Пол: Женский");
            else OutList.Items.Add("Пол: Мужской");
            OutList.Items.Add("Возраст: " + yearsNUD.Text);
            OutList.Items.Add("Род занятий: ");
            if (jobs == true)
                foreach (string test in ListJobs.CheckedItems)
                    OutList.Items.Add("- " + test);
            else OutList.Items.Add("Отсутвует.");
        }

        private void ButHelp_Click(object sender, EventArgs e)
        {
            OutList.Items.Clear();
            OutList.Items.Add("Имя: ваше имя");
            OutList.Items.Add("Адрес: ваш адрес");
            OutList.Items.Add("Пол: выберите ваш пол");
            OutList.Items.Add("Возраст: введите ваш возраст");
            OutList.Items.Add("Род занятий: отмечайте ваш род занятий");
        }

        private void ListJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListJobs.CheckedItems.Count >= 1)
                jobs = true;
            else jobs = false;
            updateButton();
        }

        private void yearsNUD_ValueChanged(object sender, EventArgs e)
        {
            if (yearsNUD.Value != 0)
                years = true;
            else years = false;
            updateButton();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {
            if (nameText.Text != "")
                name = true;
            else name = false;
            updateButton();
        }

        private void adressText_TextChanged(object sender, EventArgs e)
        {
            if (adressText.Text != "")
                address = true;
            else address = false;
            updateButton();
        }
    }
}
