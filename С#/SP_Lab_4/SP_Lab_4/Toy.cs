using System;

namespace SP_Lab_4
{
    [Serializable]
    public class Toy
    {
        public string NameProduct { get; set; }
        public string NameOfCompany { get; set; }
        public Classification Classification { get; set; }

        public Toy()
        {
            NameProduct = Default.String;
            NameOfCompany = Default.String;
            Classification = Default.Classification;
        }
        public Toy(string NameProduct, string NameOfCompany, Classification Classification) { 
            this.NameProduct = NameProduct;
            this.NameOfCompany = NameOfCompany;
            this.Classification = Classification;
        }
    }
}
