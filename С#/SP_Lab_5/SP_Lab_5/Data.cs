using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SP_Lab_5
{
    public class Data {
        public static string Line = "---------------------------------------------";
        public static void DownloadMagazines(ComboBox ListMagazines, int count)
        {
            Random random = new Random();
            for (int i = 0; i < count; i++)
                ListMagazines.Items.Add(
                    new MagazineOfToys(
                        random.Next(1, 10000), 
                        Data.DownloadLotOfToys(random.Next(3, 20), 
                        random)));
            
            //ListMagazines.Items.Add(new MagazineOfToys());

        }
        
        public static List<LotOfToys> DownloadLotOfToys(int countLotOfToys, Random random)
        {
            List<LotOfToys> lotOfToys = new List<LotOfToys>();
            for(int i = 0; i < countLotOfToys; i++)
                lotOfToys.Add(CreateLotOfToys(random));
            return lotOfToys;
        }
        private static LotOfToys CreateLotOfToys(Random random) {
            Toy randomToy = GetToys(random.Next(1, 18));
            return new LotOfToys(
                random.Next(1, 10000),
                random.Next(5, 200),
                new Date(random.Next(1, 29), random.Next(1, 13), random.Next(2009, 2023)),
                randomToy.NameProduct, randomToy.NameOfCompany, randomToy.Classification);
        }
        public static string GetInfoMagazine(MagazineOfToys magazineOfToys) =>
            $"\nНомер магазина: {magazineOfToys.Number};" +
            $"\nКоличество елементов: {CountElementsInMagazine(magazineOfToys.list)};" +
            $"\n";
        private static int CountElementsInMagazine(List<LotOfToys> list) {
            int count = 0;
            foreach (var item in list)
                count += item.Count;
            return count;
        } 
        private static Toy GetToys(int NumberOfParty)
        {
            switch (NumberOfParty)
            {
                case 1: return
                    new Toy("Lynx", "Funko", Classification.SoftToy);
                case 2: return 
                    new Toy("Wolf", "Funko", Classification.SoftToy);
                case 3: return 
                    new Toy("Fox", "Funko", Classification.SoftToy);
                case 4: return 
                    new Toy("FrogPepe", "Funko", Classification.SoftToy);
                case 5: return 
                    new Toy("Rabbit", "Funko", Classification.SoftToy);
                case 6: return
                    new Toy("Vebmedik", "Softtoys.ua", Classification.SoftToy);
                case 7: return
                    new Toy("AK-47", "ToyGuns.ua", Classification.Doll);
                case 8: return
                    new Toy("Barbie", "Barbie", Classification.Toy);
                case 9: return
                    new Toy("Police Station", "LEGO", Classification.Constructor);
                case 10: return
                    new Toy("Lacetti", "Chevrolet", Classification.TechniqueModel);
                case 11: return
                    new Toy("Fiesta", "Ford", Classification.Doll);
                case 12: return
                    new Toy("Camri", "Toyota", Classification.Toy);
                case 13: return
                    new Toy("Passat", "Volkswagen", Classification.Constructor);
                case 14: return
                    new Toy("Focus", "Ford", Classification.Doll);
                case 15: return
                    new Toy("Corolla", "Toyota", Classification.Toy);
                case 16: return
                    new Toy("Ranger", "Ford", Classification.Doll);
                case 17: return
                    new Toy("Cruze", "Chevrolet", Classification.TechniqueModel);
                default:
                    break;
            }
            return new Toy();
        }
    }
}
