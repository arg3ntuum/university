using System;
using System.Xml.Linq;

namespace SP_Lab_5
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

        public override string ToString() =>
            $"{NameProduct}, {NameOfCompany}, {Classification}.";

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public static bool operator ==(Toy Toy1, object Toy2)
        {
            return Toy1.Equals(Toy2);
        }

        public static bool operator !=(Toy Toy1, object Toy2)
        {
                return !Toy1.Equals(Toy2);
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Toy))
            {
                return false;
            }
            return NameProduct == ((Toy)obj).NameProduct &&
                NameOfCompany == ((Toy)obj).NameOfCompany &&
                Classification == ((Toy)obj).Classification
                ? true : false;
        }
    }
}
