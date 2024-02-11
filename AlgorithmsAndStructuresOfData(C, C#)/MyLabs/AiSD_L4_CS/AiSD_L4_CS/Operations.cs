namespace AiSD_L4_CS
{
    public class Operations {
        public static string TakeLine() {
            return ";";
        }
        public static float TakeNum(float numbers_type)
        {
            string num_str = string.Empty;
            float num = 0;
            errorFloat:
            num_str = Console.ReadLine();
            try
            {
                num = float.Parse(num_str);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Введен был неверный формат!");
                goto errorFloat;
            }

            return num;
        }
        public static int TakeNum(int numbers_type)
        {
            string num_str = string.Empty;
            int num = 0;
            errorInt:
            num_str = Console.ReadLine();
            try { 
                num = Convert.ToInt32(num_str); 
            }
            catch (System.FormatException) {
                Console.WriteLine("Введен был неверный формат!");
                goto errorInt;
            }

            return num;
        }
        public static long TakeNum(long numbers_type)
        {
            string num_str = string.Empty;
            long num = 0;
        errorInt:
            num_str = Console.ReadLine();
            try
            {
                num = Convert.ToInt64(num_str);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Введен был неверный формат!");
                goto errorInt;
            }

            return num;
        }

    }
}