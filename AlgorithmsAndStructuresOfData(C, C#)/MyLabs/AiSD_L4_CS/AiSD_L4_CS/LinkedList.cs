using System.Collections.Generic;
using System.Xml.Linq;

namespace AiSD_L4_CS
{
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
        public void Add() {
            string choose = string.Empty;
            int chooseInt = 0;
            do {
                Console.WriteLine("Введите номер елемента, после которого вставиться елемент: ");
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
            float number = 0;
            long sizeMassive = 0;

            Console.WriteLine("Введите имя: ");
            name = Console.ReadLine();

            Console.WriteLine("Введите фамилию: ");
            secondName = Console.ReadLine();

            Console.WriteLine("Введите номер: ");
            number = Operations.TakeNum(number);

            errorMassive: Console.WriteLine("Введите размер массива: ");
            sizeMassive = Operations.TakeNum(sizeMassive);
            if (sizeMassive < 0) {
                Console.WriteLine("Не верный размер!");
                goto errorMassive;
            }

            Node newNode = new Node(name, secondName, number, sizeMassive);

            if(sizeMassive > 0)
                newNode.Massive = CreateMassive(sizeMassive);


            nodeBehind.Next.Behind = newNode;
            newNode.Next = nodeBehind.Next;
            nodeBehind.Next = newNode;
            newNode.Behind = nodeBehind;
        }

        private long[] CreateMassive(long sizeMassive) {
            long[] massive = new long[sizeMassive];

            Console.WriteLine($"Введите {sizeMassive} елементов: ") ;
            
            for(int i = 0; i < sizeMassive; i++)
                massive[i] = Operations.TakeNum(massive[i]);

            return massive;
        }
        public void Delete()
        {
            int chooseInt = 0;
            do
            {
                Console.WriteLine("Введите номер елемента, который нужно удалить: ");
                chooseInt = Operations.TakeNum(chooseInt);

                if (IsHaveElement(chooseInt))
                    break;
            } while (true);
            if (CountElements() == 1)
            {
                Console.WriteLine("У нас остался 1 елемент!");
                return;
            }
            if (chooseInt > 0)
                DeleteElement(TakeNode(chooseInt), TakeNode(chooseInt - 1));
            else { 
                DeleteElementHead();
                DeleteElement(TakeNode(CountElements() - 1), TakeNode(CountElements() - 2));
            }

            
        }
        private void DeleteElement( Node deleteElement, Node behindDeleteElement)
        {
            behindDeleteElement.Next = deleteElement.Next;
            deleteElement.Next.Behind = behindDeleteElement;
        }
        private void DeleteElementHead() {
            Head.Behind = Head.Next;
            Head = Head.Next;
        }
        private Node TakeNode(int number) {
            Node node = Head;
            for (int i = 0; i != number; i++ ) 
                node = node.Next;
            
            return node;
        }
        private bool IsHaveElement(int chooseInt) {
            if (chooseInt >= 0 && chooseInt <= CountElements() - 1)
                return true;
            return false;
        }
        private int CountElements() {
            Node node = Head;
            Node def = Head;
            int i = 1;
            for (; ; i++) { 
                node = node.Next;
                if (node == Head)
                    break;
            }

            return i;
        }
    }
}