using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SP_Lab_1
{
    public partial class UI : Form
    {
        
        public UI()
        {
            InitializeComponent();
            Data.DownloadMagazines(ListMagazines);
            UpdateCountMagazines();
            ListMagazines.DisplayMember = "Number";
            ListMagazines.ValueMember = "Count";
            ListMagazines.SelectedItem = ListMagazines.Items[0];

            ListLotOfToys.DisplayMember = "Name";

        }
        private void UpdateListBox() { 
            ListLotOfToys.Items.Clear();
            MagazineOfToys MagazineOfToys = (MagazineOfToys)ListMagazines.SelectedItem;
            if (MagazineOfToys != null)
                for(int i = 0; i < MagazineOfToys.list.Count; i++)
                    ListLotOfToys.Items.Add(MagazineOfToys.list.ElementAt(i));
            
            ListMagazines.SelectedItem = MagazineOfToys;
        }
        private void UpdateInfo() => 
            Info.Text = Data.GetInfo((LotOfToys)ListLotOfToys?.SelectedItem) ;
        
        private void UpdateCountMagazines() =>
            CountMagazines_number.Text = MagazineOfToys.Count.ToString();
        private void CheckAllLotOfToys() {
            RestartWhile:
            for (int i = 0; i < ListLotOfToys.Items.Count; i++) {
                for (int j = 0; j < ListLotOfToys.Items.Count; j++)
                {
                    if (CheckItems((LotOfToys)ListLotOfToys.Items[i], (LotOfToys)ListLotOfToys.Items[j]) && i != j)
                    {
                        JoinLotOfToys((LotOfToys)ListLotOfToys.Items[i], (LotOfToys)ListLotOfToys.Items[j]);
                        ListLotOfToys.Items.RemoveAt(j);
                        goto RestartWhile;
                    }
                }
            }
        }
        public void AddElement(LotOfToys lotOfToys) =>
            AddElement_(lotOfToys, (MagazineOfToys)ListMagazines.Items[ListMagazines.SelectedIndex]);   
        private void AddElement_(LotOfToys lotOfToys, MagazineOfToys magazineOfToys) {
            magazineOfToys.AddElement(lotOfToys);
            UpdateListBox();
        }
        private void JoinLotOfToys(LotOfToys lotOfToys1, LotOfToys lotOfToys2) {
            lotOfToys1.AddCounts(lotOfToys2.Count);
        }
        private bool CheckItems(LotOfToys lotOfToys1, LotOfToys lotOfToys2) => 
            lotOfToys1.ToyType.NameProduct == lotOfToys2.ToyType.NameProduct &&
            lotOfToys1.ToyType.NameOfCompany == lotOfToys2.ToyType.NameOfCompany &&
            lotOfToys1.ToyType.Classification == lotOfToys2.ToyType.Classification
            ? true : false;
        private void ListMagazines_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBox();
            CheckAllLotOfToys();
        }
        private void ListLotOfToys_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        private void MagazineInfoButton_click(object sender, EventArgs e)
        {
            MessageBox.Show(Data.GetInfoMagazine((MagazineOfToys)ListMagazines.SelectedItem));
        }
        private void label1_Click(object sender, EventArgs e) { }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void UI_Load(object sender, EventArgs e) {}
        private void Info_TextChanged(object sender, EventArgs e) {  }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewLotOfToys addNewLotOfToys = new AddNewLotOfToys(this);
            addNewLotOfToys.Show();
            this.Hide();
        }
        private void Delete(MagazineOfToys magazine)
        {
            magazine.DeleteLotOfToys((LotOfToys)ListLotOfToys.SelectedItem);
            UpdateListBox();
            UpdateCountMagazines();
        }
        private void DeleteButton_Click(object sender, EventArgs e) {

            Delete((MagazineOfToys)ListMagazines.SelectedItem);
        }
    }
}