using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab_9_1_4
{
    internal class Program
    {
        static void Main(string[] args)

        {

            string strLine;

            try

            {

                FileStream aFile = new FileStream("Log.txt", FileMode.Open);

                StreamReader sr = new StreamReader(aFile);

                strLine = sr.ReadLine();

                //Построчное считывание данных

                while (strLine != null)

                {

                    Console.WriteLine(strLine);

                    strLine = sr.ReadLine();

                }

                sr.Close();

                Console.ReadLine();

            }

            catch (IOException e)

            {

                Console.WriteLine("An I0 exception has been thrown!");

                Console.WriteLine(e.ToString());

                Console.ReadLine();

                return;

            }

            return;

        }
    }
}
