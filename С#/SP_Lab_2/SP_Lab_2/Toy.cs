namespace SP_Lab_2
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
    }
}
