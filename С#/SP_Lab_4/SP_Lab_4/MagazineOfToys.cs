using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SP_Lab_4
{
    [Serializable]
    public class MagazineOfToys {
        public static int Count { get; set; }
        public int Number { get; set; }
        public List<LotOfToys> list { get; set; }
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

        public static explicit operator MagazineOfToys(ListViewItem v)
        {
            throw new NotImplementedException();
        }
    }
}
