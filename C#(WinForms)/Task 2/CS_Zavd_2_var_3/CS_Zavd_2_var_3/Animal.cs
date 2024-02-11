using System;
using System.Xml.Linq;

namespace CS_Zavd_2_var_3
{
    abstract class Animal { 
        public string Name { get; protected set; }
        public double Mass { get; protected set; }
        public double MassMax { get; protected set; }
        public double Distance { get; protected set; }
        public double VelocityNominale { get; protected set; }
        public double Fatigue { get; protected set; }

        public Animal(string name) {
            Name = name;
            Distance = 100;
        }

        public void Feed() {
            Random random = new Random();
            Mass = random.Next(Convert.ToInt32(0.5 * MassMax), Convert.ToInt32(1.2 * MassMax));
        }
        public void Run()
        {
            UpdateFatigue();
            UpdateDistance(TakeSpeed());

        }
        public abstract void UpdateFatigue();

        protected double TakeSpeed() => 
            VelocityNominale * (1 - Fatigue);
        protected void UpdateDistance(double speed) {
            if(Distance - speed > 0)
            Distance -= speed;
            else Distance = 0;
        }
    }
}
