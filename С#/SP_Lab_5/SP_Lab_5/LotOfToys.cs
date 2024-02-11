using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Runtime.InteropServices;

namespace SP_Lab_5{
    [Serializable]
    public class LotOfToys : Toy, ICloneable, IComparable
    {
        public Date Date { get; set; }
        public int Name { get;  set; }
        public int Count { get;  set; }
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

        public object Clone() =>
            new LotOfToys(Name, Count, Date, NameProduct, NameOfCompany, Classification);



        public static LotOfToys operator +(LotOfToys lotOfToys1, LotOfToys lotOfToys2)
        {
            LotOfToys @new = new LotOfToys(lotOfToys1.Name, lotOfToys1.Count + lotOfToys2.Count,
                new Date(), lotOfToys1.NameProduct, lotOfToys1.NameOfCompany, lotOfToys1.Classification);
            return @new;
        }
        public static Color operator <(LotOfToys lotOfToys, int num)
        {
            try
            {
                if (lotOfToys.CompareTo(num) == 0 && lotOfToys != null)
                {
                    if (lotOfToys.Count > num)
                        return Color.Green;
                }
            }
            catch (NullReferenceException) { }
            return Color.Red;
        }
        public static Color operator >(LotOfToys lotOfToys, int num)
        {
            try {
                if (lotOfToys.CompareTo(num) == 0 && lotOfToys != null)
                {
                    if (lotOfToys.Count > num)
                        return Color.Yellow;
                }
            }
            catch (NullReferenceException) { }
            return Color.Purple;
        }
        public override string ToString() =>
            $"{Name}, {Count}, {Date.Day}.{Date.Month}.{Date.Year}, {base.ToString()}";

        public int CompareTo(object obj)
        {
            if (object.ReferenceEquals(obj, null))
                return 1;   // All instances are greater than null   
            else if (obj is LotOfToys)
                return Count.CompareTo(((LotOfToys)obj).Count);
            return 0;
        }

    }
}