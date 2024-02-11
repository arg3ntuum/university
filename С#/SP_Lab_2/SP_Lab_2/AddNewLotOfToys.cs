using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP_Lab_2
{
    public partial class AddNewLotOfToys : Form
    {
        public LotOfToys lotOfToys = null;
        private UI _ui = null;
        public AddNewLotOfToys(UI ui)
        {
            Random random = new Random();
            InitializeComponent();
            this._ui = ui;

            NameLotOfParty.Value = random.Next(1, 100000);
            CountLotOfToys.Value = random.Next(1, 1000);
            ClassificationChoose.SelectedIndex = 0;
        }

        private void AddNewLotOfToys_Load(object sender, EventArgs e) {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CountPartyBox_TextChanged(object sender, EventArgs e)
        {

        }
        private bool Check() {
            if (NameLotOfParty.Value != 0 && CountLotOfToys.Value != 0 &&
                NameOfCompanyProduct.Text != string.Empty)
                return true;
            return false;
        }
        private void submit_Click(object sender, EventArgs e)
        {
            if (Check()) { 
                lotOfToys = new LotOfToys(Convert.ToInt32(NameLotOfParty.Value),
                    Convert.ToInt32(CountLotOfToys.Value), 
                    new Date(), 
                    NameOfProduct.Text, NameOfCompanyProduct.Text,
                    (Classification)ClassificationChoose.SelectedIndex);
                _ui.AddElement(lotOfToys);
                this.Hide();
                _ui.Show();
            }
        }
    }
}
