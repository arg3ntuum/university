using System;

namespace CS_Lab_1_z_5
{
    class Program
    {
        static void Main(string[] args)
        {
            String exit = "1";
            int num1 = 0, num2 = 0;
            byte error;
            do {
                error = 0;
                Console.Write("Введите числа для суммы:\nПервое число: ");
                try {
                    num1 = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException) {
                    Console.WriteLine("Вводить нужно только числа!");
                    error = 1;
                }

               
                if (error != 1) {
                    Console.Write("Второе число: ");
                    try
                    {
                        num2 = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Вводить нужно только числа!");
                        error = 1;
                    }
                    if (error != 1)
                    {
                        Console.Write("Сумма чисел {0} и {1} равна: {2}", num1, num2, num1 + num2);

                        Console.Write("\nВы хотите продолжить операции или завершить работу(0 - выход, другое - продолжение)?: ");
                        exit = Convert.ToString(Console.ReadLine());
                    }
                }
            } while (exit != "0");
        }
    }
}