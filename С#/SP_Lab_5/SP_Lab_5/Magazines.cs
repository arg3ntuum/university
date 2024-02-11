using System;
using System.Collections.Generic;

namespace SP_Lab_5
{
    [Serializable]
    public class Magazines
    {
        public List<MagazineOfToys> list { get; set; }
        public Magazines()
        {
            list = new List<MagazineOfToys>();
        }
        public Magazines(List<MagazineOfToys> list)
        {
            this.list = list;
        }
    }
}