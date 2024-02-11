using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CS_Lab_9_1_5
{
    internal class AsyncRead
    {
        byte[] byData;
        char[] charData;
        public AsyncRead()
        {
            byData = new byte[100];
            charData = new char[100];
            try
            {
                FileStream aFile = new FileStream("C:/Users/tftfj/source/repos/CS_Lab_9_1_5/CS_Lab_9_1_5/AsyncRead.cs", FileMode.Open);
                System.AsyncCallback cb = new AsyncCallback(this.HandleRead);
                System.IAsyncResult aResult = aFile.BeginRead(byData, 0, 100, cb, "Read AsyncRead.cs");
            }
            catch (IOException e)
            {
                Console.WriteLine("An I0 excepti-on has been thrown!");
                Console.WriteLine(e.ToString());

                Console.ReadLine();

                return;

            }

        }
        private void HandleRead(IAsyncResult ar)
        {
            Decoder d = Encoding.UTF8.GetDecoder();
            d.GetChars(byData, 0, byData.Length, charData, 0);
            Console.WriteLine("Value of state object for this operation: {0}", ar.AsyncState);
            Console.WriteLine(charData);
        }
        static void Main(string[] args)
        {
            AsyncRead aClass = new AsyncRead();
            for (int x = 0; x < 200; x++)
                Console.WriteLine(x);
            Console.ReadLine();
            return;
        }
    }
}
