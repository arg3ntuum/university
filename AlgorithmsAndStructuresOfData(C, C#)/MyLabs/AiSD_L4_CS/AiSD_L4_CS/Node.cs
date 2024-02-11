namespace AiSD_L4_CS
{
    public class Node
    {
        public string Name;
        public string SecondName;
        public float Number;//nomer//Переменная плаваю- щего типа. 

        public long SizeOfMassive { get; private set; }//Переменная беззнакового длинного целого типа; 
        public long[] Massive;
        public Node Next;
        public Node Behind;
        public Node(string name, string secondName, float nomer, long sizeMassive)
        {
            Name = name;
            SecondName = secondName;
            Number = nomer;
            SizeOfMassive = sizeMassive;
            Massive = null;
            Next = null;
            Behind = null;
        }
        public void ViewInfo(int i) { 
            Console.Write($"\n{i}. Name = {Name} | SecondName = {SecondName} | Number = {Number} | Массив чисел: ");
            for (int j = 0; j < SizeOfMassive; j++)
                Console.Write($"{Massive[j]} ");
            if (SizeOfMassive == 0)
                Console.Write("Пустой");
        }
  
    }
}