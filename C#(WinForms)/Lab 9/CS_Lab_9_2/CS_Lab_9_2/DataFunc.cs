using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CS_Lab_9_2
{
    class DataFunc
    {
        public static async Task RunFor()
        {
            await Task.Run(For);

        }

        private static void For()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(i);
                Task.Delay(100).Wait();
            }
        }

        public static async Task<string> GetTextAsync(string dataName)
        {
            string textFromFile = string.Empty;
            using (FileStream fstream = File.OpenRead(dataName))
            {
                // выделяем массив для считывания данных из файла
                byte[] buffer = new byte[fstream.Length];
                // считываем данные
                fstream.ReadAsync(buffer, 0, buffer.Length);
                // декодируем байты в строку
                textFromFile = Encoding.Default.GetString(buffer);
            }
            Console.WriteLine("Downloaded!");
            return textFromFile;
        }
        public static string AddSomeToStringFrom
            (string someString, string addingString, int addFromElement) =>
           someString.Insert(addFromElement, addingString);

        public static string SetStringFrom(string someString, int fromElement) =>
            someString.Substring(fromElement);

        public static async void SaveTextAsync(string dataName, string strSave)
        {
            using (FileStream fstream = File.Create(dataName))
            {

                Encoder e = Encoding.UTF8.GetEncoder();
                byte[] buffer = new byte[fstream.Length + strSave.Length];
                //узнать чего ошибка ерепенилась fstream.Length
                //Преобраование символьного масива в массив байтов

                e.GetBytes(strSave.ToCharArray(), 0, strSave.Length, buffer, 0, true);

                // Перемещение указателя файла в самое начало файла

                fstream.Seek(0, SeekOrigin.Begin);

                // Непосредственно запись в файл

                fstream.Write(buffer, 0, buffer.Length);

            }
        }
    }
}
