using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CS_Lab_9_1_1
{
    internal class Program
    {
        static void Main(string[] args)

        {

            byte[] byData = new byte[100];

            char[] charData = new Char[100];

            try

            {

                //открывает свой файл кода для чтения, ../ исспользуется для доступа

                FileStream aFile = new FileStream("../../Program.cs", FileMode.Open);

                //Переход на 55 позицию от начала

                aFile.Seek(55, SeekOrigin.Begin);

                //Читает в буфер byData 100 символов

                aFile.Read(byData, 0, 100);

            }

            catch (IOException e)
            {

                //Обработка исключительных ситуаций

                Console.WriteLine("An IO exception has been thrown!");

                Console.WriteLine(e.ToString());

                Console.ReadLine();

                return;

            }

            //Преобразование символов в другую кодировку

            Decoder d = Encoding.UTF8.GetDecoder();

            d.GetChars(byData, 0, byData.Length, charData, 0);

            //Вывод результата на консоль

            Console.WriteLine(charData);

            Console.ReadLine();

            return;

        }
    }
}
