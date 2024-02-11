using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CS_Zavd_2_var_3
{
    class Program
    {
        private static List<Animal> _animalsList = new List<Animal>();

        private const string ListKey = "list";
        private const string ExitKey = "exit";
        private const string FeedKey = "feed";
        private const string RunKey = "run";

        private static bool _isFeed = false;
        static void Main(string[] args)
        {
            string key = string.Empty;
            AddToList();

            do {
                Console.WriteLine($"Command | Do;" +
                    $"\n{ExitKey} | Закончить работу программы;" +
                    $"\n{ListKey} | Вывести весь список животных и инфу про них;" +
                    $"\n{FeedKey} | Покормить всех животных;" +
                     $"\n{RunKey} | Отпустить животных! Пусть бегут..");
                key = Console.ReadLine();
                if (key.StartsWith(ListKey))
                    GetList();
                else if (key.StartsWith(FeedKey))
                    FeedAnimals();
                else if (key.StartsWith(RunKey)) 
                    RunAnimals();
            } while (!key.StartsWith(ExitKey));
        }
        private static void RunAnimals()
        {
            if (!_isFeed)
            {
                Console.WriteLine("Вы не покормили животных!");
                return;
            }
            UIRunAnimals();
            foreach (var item in _animalsList)
                item.Run();
            _isFeed = false;
        }
        private static void UIRunAnimals()
        {
            for (int i = 1; i < 60; i++)
            {
                Console.WriteLine($"Животные идут... Прошло {i} мин.");
                Thread.Sleep(100);
            }
        }

        private static void FeedAnimals()
        {
            if (_isFeed)
            {
                Console.WriteLine("Животные уже поели!");
                return;
            }
            UIFeedAnimals();
            for (int i = 0; i < _animalsList.Count; i++) { 
                _animalsList[i].Feed();
                Console.WriteLine($"{_animalsList[i].Name} съел {Math.Round(_animalsList[i].Mass, 3)} кг/л;");
            }
            _isFeed = true;
        }
        private static void UIFeedAnimals()
        {
            for (int i = 0; i < _animalsList.Count; i++)
            {
                Console.WriteLine($"Кормим животных...{(double)i / _animalsList.Count * 100}%");
                Thread.Sleep(500);
            }
            Console.WriteLine($"Кормим животных...100%");
        }

        private static void GetList()
        {
            for(int i = 0; i < _animalsList.Count; i++)
                Console.WriteLine($"{i}. {_animalsList[i].Name}. Осталось пройти {Math.Round(_animalsList[i].Distance, 3)} км.");
        }

        private static void AddToList() {
            _animalsList.Add(new Horse("Horse"));
            _animalsList.Add(new Crocodile("Crocodile"));
            _animalsList.Add(new Camel("Camel"));
            _animalsList.Add(new APC(100000));
        }
    }
}
