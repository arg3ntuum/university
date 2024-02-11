using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SP_Lab_3{
    public class LotOfToys : Toy
    {
        public Date Date { get; private set; }
        public int Name { get; private set; }
        public int Count { get; private set; }
        public LotOfToys(int Name, int Count, Date Date, string NameProduct, string NameOfCompany, Classification Classification)
            : base(NameProduct, NameOfCompany, Classification) {
            this.Name = Name;
            this.Count = Count;
            this.Date = Date;
        }
        public LotOfToys() : base() {
            this.Name = 0;
            this.Count = 0;
            this.Date = new Date();
        }
        public void AddCounts(int value) =>
            Count += value;
        public static LotOfToys operator +(LotOfToys lotOfToys1, LotOfToys lotOfToys2)
        {
            LotOfToys @new = new LotOfToys(lotOfToys1.Name, lotOfToys1.Count + lotOfToys2.Count, 
                new Date(), lotOfToys1.NameProduct, lotOfToys1.NameOfCompany, lotOfToys1.Classification);
            return @new;
        }
        public static Color operator <(LotOfToys lotOfToys, int num)
        {
            if(lotOfToys.Count > num)
                return Color.Green;
            else return Color.Red;
        }
        public static Color operator >(LotOfToys lotOfToys, int num)
        {
            if (lotOfToys.Count > num)
                return Color.Yellow;
            else return Color.Purple;
        }
    }
}