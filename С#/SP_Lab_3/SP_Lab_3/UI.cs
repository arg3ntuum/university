using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SP_Lab_3
{
    public partial class UI : Form
    {
        
        public UI()
        {
            InitializeComponent();
            Data.DownloadMagazines(ListMagazines, 4);
            UpdateCountMagazines();
            ListMagazines.DisplayMember = "Number";
            ListMagazines.ValueMember = "Count";
            ListMagazines.SelectedItem = ListMagazines.Items[0];

            ListLotOfToys.DisplayMember = "Name";

        }
        private void UpdateListBox(MagazineOfToys MagazineOfToys) { 
            ListLotOfToys.Items.Clear();
            if (MagazineOfToys != null)
                for(int i = 0; i < MagazineOfToys.list.Count; i++)
                    ListLotOfToys.Items.Add(MagazineOfToys[i]);
        }
        private void UpdateInfo() {
            ChangeColor((LotOfToys)ListLotOfToys?.SelectedItem);
            Info.Text = Data.GetInfo((LotOfToys)ListLotOfToys?.SelectedItem) ;
        }
        private void ChangeColor(LotOfToys lotOfToys) { 
            int num = new Random().Next(0, 200);
            if(num > 100)
                ColorPanel.BackColor = lotOfToys < num;
            else ColorPanel.BackColor = lotOfToys > num;
        }
        private void UpdateCountMagazines() =>
            CountMagazines_number.Text = MagazineOfToys.Count.ToString();
        private void CheckAllLotOfToys() {
            RestartWhile:
            for (int i = 0; i < ListLotOfToys.Items.Count; i++) {
                for (int j = 0; j < ListLotOfToys.Items.Count; j++)
                {
                    if (CheckItems((LotOfToys)ListLotOfToys.Items[i], (LotOfToys)ListLotOfToys.Items[j]) && i != j)
                    {
                        ListLotOfToys.Items[i] = 
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
            UpdateListBox((MagazineOfToys)ListMagazines.SelectedItem);
        }
        private LotOfToys JoinLotOfToys(LotOfToys lotOfToys1, LotOfToys lotOfToys2) {
            return lotOfToys1 + lotOfToys2;
        }
        private bool CheckItems(LotOfToys lotOfToys1, LotOfToys lotOfToys2) => 
            lotOfToys1 == lotOfToys2;
        private void ListMagazines_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBox((MagazineOfToys)ListMagazines.SelectedItem);
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
        private void СlearInfoBox() => Info.Text = string.Empty;
        private void Delete(MagazineOfToys magazine)
        {
            magazine.DeleteLotOfToys((LotOfToys)ListLotOfToys.SelectedItem);
            СlearInfoBox();
            UpdateCountMagazines();
            UpdateListBox(magazine);
        }
        private void DeleteButton_Click(object sender, EventArgs e) {

            Delete((MagazineOfToys)ListMagazines.SelectedItem);
        }

        private void addMagazineButton_Click(object sender, EventArgs e)
        {
            Data.DownloadMagazines(ListMagazines, 1);
            UpdateCountMagazines();
        }
    }
}