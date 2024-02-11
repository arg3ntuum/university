using System.Drawing;

namespace SP_Lab_3
{
    public class Toy
    {
        public string NameProduct { get; protected set; }
        public string NameOfCompany { get; protected set; }
        public Classification Classification { get; protected set; }

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
        public static bool operator ==(Toy Toy1, Toy Toy2) =>
            Toy1.NameProduct == Toy2.NameProduct &&
            Toy1.NameOfCompany == Toy2.NameOfCompany &&
            Toy1.Classification == Toy2.Classification
            ? true : false;
        
        public static bool operator !=(Toy Toy1, Toy Toy2) =>
            Toy1.NameProduct != Toy2.NameProduct &&
            Toy1.NameOfCompany != Toy2.NameOfCompany &&
            Toy1.Classification != Toy2.Classification
            ? true : false;
    }
}
