using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms_L4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string chooseCommand = string.Empty;
            const string ExitCommand = "0";
            const string ListCommand = "1";
            const string AddCommand = "2";
            const string DeleteCommand = "3";

            LinkedList linkedList = new LinkedList();
            CreateList(linkedList);

            do
            {
                Console.WriteLine("\nМеню: " +
                                $"\n===================" +
                                $"\nКоманда - Дiя" +
                                $"\n===================" +
                                $"\n{ExitCommand} - Закрити програму;" +
                                $"\n{ListCommand} - Побачити список;" +
                                $"\n{AddCommand} - Додати елемент;" +
                                $"\n{DeleteCommand} - Видалити елемент;" +
                                $"\nВаш вибiр: ");
                chooseCommand = Console.ReadLine();

                if (chooseCommand == ListCommand)
                    linkedList.WriteList();
                else if (chooseCommand == AddCommand)
                    linkedList.Add();
                else if (chooseCommand == DeleteCommand)
                    linkedList.Delete();
            } while (chooseCommand != ExitCommand);
        }
        private static void CreateList(LinkedList linkedList)
        {

            Node first = new Node("1st", "2nd", 'a', 0);

            first.Next = null;
            first.Behind = null;

            linkedList.Head = first;
            first.Next = linkedList.Head;

            linkedList.Head.Behind = first;

            Node second = new Node("3st", "4nd", 'b', 0);
            second.Next = null;
            second.Behind = first;
            first.Next = second;
            second.Next = linkedList.Head;
            linkedList.Head.Behind = second;

            Node third = new Node("5st", "6nd", 'c', 0);
            third.Next = null;
            third.Behind = second;
            second.Next = third;
            third.Next = linkedList.Head;
            linkedList.Head.Behind = third;
        }
    }
    public class LinkedList
    {
        public Node Head = null;
        public void WriteList()
        {
            Node node = Head;
            Node def = node;
            for (int i = 0; i < CountElements(); i++)
            {
                node.ViewInfo(i);
                node = node.Next;
            }
        }
        public void Add()
        {
            string choose = string.Empty;
            int chooseInt = 0;
            do
            {
                Console.WriteLine("Уведiть номер елементу, пiсля якого вставимо новий елемент: ");
                chooseInt = Operations.TakeNum(chooseInt);

                if (IsHaveElement(chooseInt))
                    break;
            } while (true);
            AddElement(TakeNode(chooseInt), TakeNode(chooseInt + 1));
        }
        private void AddElement(Node nodeBehind, Node nodeNext)
        {
            string name = string.Empty;
            string secondName = string.Empty;
            float sizeMassive = 0;
            Console.WriteLine("Уведiть iм'я: ");
            name = Console.ReadLine();

            Console.WriteLine("Уведiть прiзвище: ");
            secondName = Console.ReadLine();

            Console.WriteLine("Уведiть порядковий номер: ");
            int number = 0;
            number = Operations.TakeNum(number);

        errorMassive:
            Console.WriteLine("Уведiть розмiр масиву: ");
            sizeMassive = Operations.TakeNum(sizeMassive);
            if (sizeMassive < 0)
            {
                Console.WriteLine("Не той розмiр!");
                goto errorMassive;
            }

            Node newNode = new Node(name, secondName, number, sizeMassive);

            if (sizeMassive > 0)
                newNode.Massive = CreateMassive(Convert.ToInt32(sizeMassive));

            nodeBehind.Next.Behind = newNode;
            newNode.Next = nodeBehind.Next;
            nodeBehind.Next = newNode;
            newNode.Behind = nodeBehind;
        }

        private float[] CreateMassive(int sizeMassive)
        {
            float[] massive = new float[sizeMassive];

            Console.WriteLine($"Уведiть {sizeMassive} елементiв: ");

            for (int i = 0; i < sizeMassive; i++)
                massive[i] = Operations.TakeNum(massive[i]);

            return massive;
        }
        public void Delete()
        {
            int chooseInt = 0;
            do
            {
                Console.WriteLine("Уведiть номер елементу, який потрiбно видалити: ");
                chooseInt = Operations.TakeNum(chooseInt);

                if (IsHaveElement(chooseInt))
                    break;
            } while (true);
            if (CountElements() == 1)
            {
                Console.WriteLine("Залишився 1 елемент!");
                return;
            }
            if (chooseInt > 0)
                DeleteElement(TakeNode(chooseInt), TakeNode(chooseInt - 1));
            else
            {
                DeleteElementHead();
                DeleteElement(TakeNode(CountElements() - 1), TakeNode(CountElements() - 2));
            }


        }
        private void DeleteElement(Node deleteElement, Node behindDeleteElement)
        {
            behindDeleteElement.Next = deleteElement.Next;
            deleteElement.Next.Behind = behindDeleteElement;
        }
        private void DeleteElementHead()
        {
            Head.Behind = Head.Next;
            Head = Head.Next;
        }
        private Node TakeNode(int number)
        {
            Node node = Head;
            for (int i = 0; i != number; i++)
                node = node.Next;

            return node;
        }
        private bool IsHaveElement(int chooseInt)
        {
            if (chooseInt >= 0 && chooseInt <= CountElements() - 1)
                return true;
            return false;
        }
        private int CountElements()
        {
            Node node = Head;
            Node def = Head;
            int i = 1;
            for (; ; i++)
            {
                node = node.Next;
                if (node == Head)
                    break;
            }

            return i;
        }
    }
    public class Node
    {
        public string Name;
        public string SecondName;

        public float SizeOfMassive { get; private set; }
        public float[] Massive;
        public int Nomer;
        public Node Next;
        public Node Behind;
        public Node(string name, string secondName, int Nomer, float sizeMassive)
        {
            Name = name;
            SecondName = secondName;
            this.Nomer = Nomer;
            SizeOfMassive = sizeMassive;
            Massive = null;
            Next = null;
            Behind = null;
        }
        public void ViewInfo(int i)
        {
            Console.Write($"\n{i}. Назва = {Name} | Прiзвище = {SecondName} | Номер = {Nomer} | Масив чисел: ");
            for (int j = 0; j < SizeOfMassive; j++)
                Console.Write($"{Massive[j]} ");
            if (SizeOfMassive == 0)
                Console.Write("Пустой");
        }

    }
    public class Operations
    {
        public static string TakeLine()
        {
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
            try
            {
                num = Convert.ToInt32(num_str);
            }
            catch (System.FormatException)
            {
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
