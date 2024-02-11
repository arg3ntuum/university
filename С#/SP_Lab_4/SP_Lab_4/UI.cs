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
using static SP_Lab_4.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SP_Lab_4
{
    /*
    1) обробку виняткових ситуацій (4 -5 варіантів)0
        стр 38, 43, 47, (и куча в классах).. TRY CATCH
    2) списки об'єктів класів... (колекції, узагальнення),
        колекції - List в MagazineOfToys +
        узагальнення - Т в Checkers +
    3) дані (списки об'єктів класів) зберігати у файли, завантажувати з файлів (серіалізація – десеріалізація).
        серіалізація - SerializeButton_Click
        десеріалізація - 
    4) занести значення для всіх списків даних і зберегти їх у файлах.
     */
    public partial class UI : Form
    {
        
        public const string FileName = "MagazineOfToys.xml";

        public class Magazines {
            public List<MagazineOfToys> list { get; set; }
            public Magazines() {
                list = new List<MagazineOfToys>();
            }
            public Magazines(List<MagazineOfToys> list)
            {
                this.list = list;
            }
        }
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
            if (Checkers<MagazineOfToys>.CheckForNull(MagazineOfToys))
                for(int i = 0; i < MagazineOfToys.list.Count; i++)
                    ListLotOfToys.Items.Add(MagazineOfToys.list.ElementAt(i));
        }
        
        private void UpdateInfo() {
            try { ChangeColor((LotOfToys)ListLotOfToys.SelectedItem);
            }catch(NullReferenceException) {
                MessageBox.Show("NullReferenceException");
            }
            Info.Text = Data.GetInfo((LotOfToys)ListLotOfToys?.SelectedItem) ;
        }
        private void ChangeColor(LotOfToys lotOfToys)
        {

            if (lotOfToys.Count > 100 && lotOfToys != null)
                ColorPanel.BackColor = Color.Green;
            else ColorPanel.BackColor = Color.Red;


        }
        private void UpdateCountMagazines() =>
            CountMagazines_number.Text = MagazineOfToys.Count.ToString();
        private void CheckAllLotOfToys() {
            RestartWhile:
            for (int i = 0; i < ListLotOfToys.Items.Count + 1; i++) {
                for (int j = 0; j < ListLotOfToys.Items.Count + 1; j++)
                {
                    try {
                        if (CheckItems((LotOfToys)ListLotOfToys.Items[i], (LotOfToys)ListLotOfToys.Items[j]) && i != j)
                    {
                        JoinLotOfToys((LotOfToys)ListLotOfToys.Items[i], (LotOfToys)ListLotOfToys.Items[j]);
                        ListLotOfToys.Items.RemoveAt(j);
                        goto RestartWhile;
                    } 
                    }catch(ArgumentOutOfRangeException) { MessageBox.Show("ArgumentOutOfRangeException"); }
                    
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

        private void SerializeButton_Click(object sender, EventArgs e)
        {
            Magazines magazines = new Magazines(new List<MagazineOfToys>());

            try { for (int i = 0; ListMagazines.Items.Count > i; i++)
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
            }catch(NullReferenceException) {
                MessageBox.Show("NullReferenceException");
                return; 
            }catch(Exception ex) { }
            
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
                try {magazines = (Magazines)xml.Deserialize(fs); }
                catch(InvalidOperationException) {
                    MessageBox.Show("InvalidOperationException");
                    return; }
                
            }

            //Upload to Magazine
            foreach (var item in magazines.list)
            {
                ListMagazines.Items.Add(item);
            }
            UpdateCountMagazines();
            
        }
    }
}