using System;
using System.Threading;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace CS_Zav_1_var3
{
    class Muscleman { 
        public string Name { get; private set; }
        public float Stamina { get; private set; }
        public static int Qualification { get; private set; } = 1;
        private float Time { get; set; }
        
        public Muscleman(string name, float w) {
            Name = name;
            Stamina = w;
            Time = 0;
        }
        public Muscleman(string name, float w, int u) : this(name, w)
        {
            Qualification = u;
        }

        private void UpQualification() => Qualification++;
        private void DownQualification() => Qualification--;

        public void Drill(int time)
        {
            DrillView(time);
        }

        private void DrillView(int time)
        {
            DoTraine(0);
            for (int i = 1; i - 1 < time; i++)
                DoTraine((double)i / time * 100);
            Time += time;
        }

        private void DoTraine(double persent) {
            System.Console.WriteLine($"{Name} подкачался на {persent}%.");
            Thread.Sleep(1000);
        }
        public void Test() {
            Console.WriteLine($"{Name} имеет грузоподьемность {Math.Round(GetP(), 3)}");
        }
        private double GetP() =>
            Qualification * Math.Exp(-(2 * Math.Abs(Time - Stamina)/ Stamina));
    }
}
