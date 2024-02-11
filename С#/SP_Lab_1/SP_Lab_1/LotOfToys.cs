using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SP_Lab_1{
    public class LotOfToys
    {
        public Toy ToyType { get; private set; }
        public Date Date { get; private set; }
        public int Name { get; private set; }
        public int Count { get; private set; }
        public LotOfToys(int Name, int Count, Date Date, Toy ToyType) {
            this.Name = Name;
            this.Count = Count;
            this.Date = Date;
            this.ToyType = ToyType;
        }
        public LotOfToys() {
            this.Name = 0;
            this.Count = 0;
            this.Date = new Date();
            this.ToyType = new Toy();
        }
        public void AddCounts(int value) =>
            Count += value;
    }
}