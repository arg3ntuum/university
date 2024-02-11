using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiSD_L4_CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string menu = string.Empty;
            string exitTag = "exit";
            string listTag = "list";
            string addTag = "add";
            string deleteTag = "delete";

            LinkedList linkedList = new LinkedList();
            CreateList(linkedList);

            do
            {
                Console.WriteLine("\nМеню: " +
                                $"\n{exitTag} - Выход" +
                                $"\n{listTag} - Просмотреть список" +
                                $"\n{addTag} - Добавить елемент" +
                                $"\n{deleteTag} - Удалить елемент");
                menu = Console.ReadLine();

                if (menu == listTag)
                    linkedList.WriteList();
                else if (menu == addTag)
                    linkedList.Add();
                else if (menu == deleteTag)
                    linkedList.Delete();
            } while (menu != exitTag);
        }
        private static void CreateList(LinkedList linkedList)
        {

            //Add first node.
            Node first = new Node("1st", "2nd", 1, 0);

            first.Next = null;
            first.Behind = null;
            //linking with head node

            linkedList.Head = first;
            //linking next of the node with head
            first.Next = linkedList.Head;
            //linking prev of the head 

            linkedList.Head.Behind = first;

            //Add second node.
            Node second = new Node("3st", "4nd", 2, 0);
            second.Next = null;
            //linking with first node
            second.Behind = first;
            first.Next = second;
            //linking next of the node with head
            second.Next = linkedList.Head;
            //linking prev of the head 
            linkedList.Head.Behind = second;

            //Add third node.
            Node third = new Node("5st", "6nd", 3, 0);
            third.Next = null;
            //linking with second node
            third.Behind = second;
            second.Next = third;
            //linking next of the node with head
            third.Next = linkedList.Head;
            //linking prev of the head 
            linkedList.Head.Behind = third;
            
        }
    }
}