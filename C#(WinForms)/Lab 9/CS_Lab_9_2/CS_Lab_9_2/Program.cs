using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab_9_2
{
    internal class Program
    {
        private static string FileName { get; set; } = "Text.txt";
        static void Main(string[] args)
        {
            string data = string.Empty;

            DataFunc.RunFor();
            data = DataFunc.GetTextAsync(FileName).Result;
            WriteConsole(data);

            Wait();

            //добавить с какой-то позиции какойто текст
            data = DataFunc.AddSomeToStringFrom(data, "Something", 10);
            WriteConsole(data);

            Wait();

            data = DataFunc.SetStringFrom(data, 10);
            WriteConsole(data);

            Wait();

            DataFunc.SaveTextAsync(FileName, data);
        }

        private static void WriteConsole(string data) =>
            Console.WriteLine($"Текст из файла: \n{data}");

        private static void Wait() { 
            Console.ReadLine();
            Console.Clear();
        }
    }
}
