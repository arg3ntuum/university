namespace SP_Lab_1
{
    public class Toy
    {
        public string NameProduct { get; private set; }
        public string NameOfCompany { get; private set; }
        public Classification Classification { get; private set; }

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
