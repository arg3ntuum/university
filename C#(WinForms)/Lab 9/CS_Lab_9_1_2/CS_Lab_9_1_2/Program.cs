using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab_9_1_2
{
    internal class Program
    {
        static void Main(string[] args)

        {

            byte[] byData = new byte[100];

            char[] charData = new Char[100];

            charData = "Hello World".ToCharArray();

            try

            {

                FileStream aFile = new FileStream("Temp.txt", FileMode.OpenOrCreate);

                Encoder e = Encoding.UTF8.GetEncoder();

                //Преобраование символьного масива в массив байтов

                e.GetBytes(charData, 0, charData.Length, byData, 0, true);

                // Перемещение указателя файла в самое начало файла

                aFile.Seek(0, SeekOrigin.Begin);

                // Непосредственно запись в файл

                aFile.Write(byData, 0, byData.Length);

            }

            catch (IOException ex)
            {

                Console.WriteLine("An 10 exception has been thrown!");

                Console.WriteLine(ex.ToString());

                Console.ReadLine();

                return;

            }

        }
    }
}
