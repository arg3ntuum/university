using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static SP_Lab_5.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SP_Lab_5
{
    public partial class UI : Form
    {
        public const string FileName = "MagazineOfToys.xml";

        public UI()
        {
            InitializeComponent();
            Data.DownloadMagazines(ListMagazines, 4);
            UpdateCountMagazines();
            UpdateClassification();
            
            ListMagazines.DropDownStyle = ComboBoxStyle.DropDownList;
            ListMagazines.DisplayMember = "Number";
            ListMagazines.ValueMember = "Count";
            ListMagazines.SelectedItem = ListMagazines.Items[0];
            SortListAndMagazine();

            ListLotOfToys.DisplayMember = "Name";

            ClassificationComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ClassificationComboBox.SelectedIndex = 0;

            NameProductTextBox.Text = "None";
            CompanyNameTextBox.Text = "None";
        }
        public void SortListAndMagazine()
        {
            SortMagazines();
        }

        private void SortMagazines()
        {
            List<MagazineOfToys> magazines = new List<MagazineOfToys>();
            foreach (var item in ListMagazines.Items)
                magazines.Add((MagazineOfToys)item);

            magazines.Sort((a, b) => a.Number.CompareTo(b.Number));

            ListMagazines.Items.Clear();

            foreach (var item in magazines)
                ListMagazines.Items.Add(item);
        }

        private void SortLotOfToys()
        {
            List<LotOfToys> LotOfToys_list = new List<LotOfToys>();
            foreach (var item in ListLotOfToys.Items)
                LotOfToys_list.Add((LotOfToys)item);

            LotOfToys_list.Sort((a, b) => a.Name.CompareTo(b.Name));

            ListLotOfToys.Items.Clear();

            foreach (var item in LotOfToys_list)
                ListLotOfToys.Items.Add(item);
        }
        public void UpdateGroupInfo() {
            ChangeColor((LotOfToys)ListLotOfToys.SelectedItem);
            LotOfToys lotOfToys = ListLotOfToys.SelectedItem as LotOfToys;
            NameNumericUpDown.Value = lotOfToys.Name;
            CountNumericUpDown.Value = lotOfToys.Count;
            DayNum.Value = lotOfToys.Date.Day;
            MonthNum.Value = lotOfToys.Date.Month;
            YearNum.Value = lotOfToys.Date.Year;
            NameProductTextBox.Text = lotOfToys.NameProduct;
            CompanyNameTextBox.Text = lotOfToys.NameOfCompany;
            ClassificationComboBox.SelectedItem = lotOfToys.Classification;

        }
        public void UpdateClassification() {
            ClassificationComboBox.Items.Clear();
            foreach (Classification classification in (Classification[])Enum.GetValues(typeof(Classification)))
                ClassificationComboBox.Items.Add(classification);
        }
        private void UpdateListBox(MagazineOfToys MagazineOfToys) { 
            ListLotOfToys.Items.Clear();
            if (Checkers<MagazineOfToys>.CheckForNull(MagazineOfToys))
                for(int i = 0; i < MagazineOfToys.list.Count; i++)
                    ListLotOfToys.Items.Add(MagazineOfToys.list.ElementAt(i));
            SortLotOfToys();
        }
        private void ChangeColor(LotOfToys lotOfToys)
        {
            int num = new Random().Next(0, 200);
            if (num > 100)
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
                        ListLotOfToys.Items[i] = ((LotOfToys)ListLotOfToys.Items[i]) + ((LotOfToys)ListLotOfToys.Items[j]);
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
        private void JoinLotOfToys(LotOfToys lotOfToys1, LotOfToys lotOfToys2) {
            lotOfToys1.AddCounts(lotOfToys2.Count);
        }
        private bool CheckItems(LotOfToys lotOfToys1, LotOfToys lotOfToys2) => 
            lotOfToys1.NameProduct == lotOfToys2.NameProduct &&
            lotOfToys1.NameOfCompany == lotOfToys2.NameOfCompany &&
            lotOfToys1.Classification == lotOfToys2.Classification
            ? true : false;
        private void ListMagazines_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBox((MagazineOfToys)ListMagazines.SelectedItem);
            CheckAllLotOfToys();
        }
        private void ListLotOfToys_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGroupInfo();

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

        private void SerializeButton_Click(object sender, EventArgs e)
        {
            Magazines magazines = new Magazines(new List<MagazineOfToys>());

            for (int i = 0; ListMagazines.Items.Count > i; i++)
            {
                magazines.list.Add((MagazineOfToys)ListMagazines.Items[i]);
            }

            XmlSerializer xml = new XmlSerializer(typeof(Magazines));

            using (FileStream fs = new FileStream(FileName, FileMode.Create)) {
                //BinaryFormatter bf = new BinaryFormatter();
                //bf.Serialize(fs, magazines);
                xml.Serialize(fs, magazines);
            }

            MessageBox.Show($"У файл {FileName} було вигружено дані масиву.");

            
        }

        private void DeserializeButton_Click(object sender, EventArgs e)
        {
            Magazines magazines = new Magazines(new List<MagazineOfToys>());

            XmlRootAttribute xRoot = new XmlRootAttribute();
            xRoot.ElementName = "Magazines";
            xRoot.IsNullable = true;

            XmlSerializer xml = new XmlSerializer(typeof(Magazines), xRoot);

            using (FileStream fs = new FileStream(FileName, FileMode.Open))
            {
                try { magazines = (Magazines)xml.Deserialize(fs); }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("InvalidOperationException");
                    return;
                }
            }

            //Upload to Magazine
            foreach (var item in magazines.list)
                ListMagazines.Items.Add(item);
            
            UpdateCountMagazines();
        }

        private void GetInfo_Click(object sender, EventArgs e)
        {
            if (ListLotOfToys.SelectedItem != null) { 
                LotOfToys lotOfToys = (LotOfToys)ListLotOfToys.SelectedItem;
                MessageBox.Show(lotOfToys.ToString());
            }
        }

        private void UpdateLotOfToys_Click(object sender, EventArgs e)
        {
            ((LotOfToys)ListLotOfToys.Items[ListLotOfToys.SelectedIndex]).Name 
                = Convert.ToInt32(NameNumericUpDown.Value);

            ((LotOfToys)ListLotOfToys.Items[ListLotOfToys.SelectedIndex]).Count
                = Convert.ToInt32(CountNumericUpDown.Value);

            ((LotOfToys)ListLotOfToys.Items[ListLotOfToys.SelectedIndex]).Date
                = new Date(Convert.ToInt32(DayNum.Value), Convert.ToInt32(MonthNum.Value), Convert.ToInt32(YearNum.Value));

            ((LotOfToys)ListLotOfToys.Items[ListLotOfToys.SelectedIndex]).NameProduct
                = NameProductTextBox.Text;

            ((LotOfToys)ListLotOfToys.Items[ListLotOfToys.SelectedIndex]).NameOfCompany
                = CompanyNameTextBox.Text;

            ((LotOfToys)ListLotOfToys.Items[ListLotOfToys.SelectedIndex]).Classification
                = (Classification)ClassificationComboBox.SelectedIndex;
            //ListLotOfToys.Items[ListLotOfToys.SelectedIndex] = 
            //    new LotOfToys(
            //        Convert.ToInt32(NameNumericUpDown.Value),
            //        Convert.ToInt32(CountNumericUpDown.Value),
            //        new Date(), 
            //        NameProductTextBox.Text,
            //        CompanyNameTextBox.Text,
            //        (Classification)ClassificationComboBox.SelectedIndex
            //    );
        }
    }
}