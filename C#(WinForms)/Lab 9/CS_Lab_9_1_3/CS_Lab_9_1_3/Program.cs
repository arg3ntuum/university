using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab_9_1_3
{
    internal class Program
    {
        static void Main(string[] args)

        {

            try

            {

                // Создание объекта, привязаного к файлу

                FileStream aFile = new FileStream("Log.txt", FileMode.OpenOrCreate);

                // Создание потока вывода через файл

                StreamWriter sw = new StreamWriter(aFile);

                // Запись данных з файл //

                // Запись строки

                sw.WriteLine("Hello World");

                // Просто запись передаваемых символов

                sw.Write("This is a ");

                sw.Write("string of characters.");

                sw.Close();

            }

            catch (IOException e)

            {

                Console.WriteLine("An 10 exception has been thrown!");

                Console.WriteLine(e.ToString());

                Console.ReadLine();

                return;

            }

        }
    }
}
