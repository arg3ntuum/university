using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Zav_1_var3
{
    internal class Program
    {
        private const string ExitConst = "exit";
        private const string TrainKey = "train";
        private const string TestKey = "test";
        private const string GetListKey = "list";
        private const string ClearKey = "clear";

        private static List<Muscleman> _list = new List<Muscleman>();
        static void Main(string[] args)
        {
            string line = string.Empty;
            SaveInfoInList();
            do
            {
                Console.WriteLine($"Введите {ExitConst} для выхода;" +
                    $"\nДля тренировки Muscleman введите {TrainKey} и индекс." +
                    $"\nДля того, чтобы узнать грузоподъемность введите {TestKey} и индекс." +
                    $"\nДля того, чтобы узнать про всех Muscleman введите {GetListKey}." +
                    $"\nДля очистки введите {ClearKey}.");
                line = Console.ReadLine();

                if (line.StartsWith(GetListKey))
                    GetList();
                else if (line.StartsWith(TrainKey))
                    GetMuscleman(line)?.Drill(5);
                else if (line.StartsWith(TestKey))
                    GetMuscleman(line)?.Test();
                else if (line.StartsWith(ClearKey))
                    Console.Clear();
            } while (line != ExitConst);
        }

        private static Muscleman GetMuscleman(string line)
        {
            int nomer = TakeNumberOf(line);
            if(nomer != -1)
                return _list[nomer];
            return null;
        }

        private static int TakeNumberOf(string line)
        {
            int nomer;
            try { nomer = Convert.ToInt32(line.Remove(0, TrainKey.Length)); } 
            catch(System.ArgumentOutOfRangeException) { nomer = -1; }
            catch(System.FormatException) { nomer = -1; }
            if (nomer >= 0 && nomer <= _list.Count)
                return nomer;

            Console.WriteLine($"Muscleman с таким индексом не найдено.");
            return -1;
        }

        private static void GetList() { 
            for(int i = 0; i < _list.Count; i++)
                Console.WriteLine($"{i}. " +
                    $"{_list[i].Name} " +
                    $"имеет {_list[i].Stamina} Stamina " +
                    $"и у него {Muscleman.Qualification} уровень квалификации.");
        }
        private static void SaveInfoInList()
        {
            _list.Add(new Muscleman("Чеееел", 50));
            _list.Add(new Muscleman("Да ладно", 40));
            _list.Add(new Muscleman("Стринговский", 100));
        }
    }
}
