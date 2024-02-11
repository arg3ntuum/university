using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SP_Lab_3
{
    public class MagazineOfToys {
        public static int Count { get; private set; }
        public int Number { get; private set; }
        public List<LotOfToys> list { get; private set; }
        public MagazineOfToys(int Number, List<LotOfToys> list)
        {
            this.Number = Number;
            this.list = list;
            Count++;
        }
        public MagazineOfToys() { 
            Random random = new Random();
            this.Number = random.Next(1, 10000);
            this.list = new List<LotOfToys>
            {
                new LotOfToys()
            };
            Count++;
        }
        public List<LotOfToys> GetListLotOfToys() => 
            list;
        public void DeleteLotOfToys(LotOfToys lotOfToys) => 
            list.Remove(lotOfToys);
        public void AddElement(LotOfToys lotOfToys) =>
            list.Add(lotOfToys);
        public LotOfToys this[double index]
        {
            get
            {
                //MessageBox.Show("return");
                return list[(int)Math.Round(index)];
            }

            set
            {
                //MessageBox.Show("set");
                list[(int)Math.Round(index)] = value;
            }
        }
    }
}
