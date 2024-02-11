using System;

namespace CS_Zavd_2_var_3
{
    class APC : Animal
    {
        public override void UpdateFatigue() {
            if (Mass > 50)
                Fatigue = 0;
            else Fatigue = 1;
        }
        private static string GetNomer(int name) {
            Random random = new Random();
            if(name > 0 && name < 10)
                return $"APC-000{name}"; 
            else if (name >= 10 && name < 100)
                return $"APC-00{name}";
            else if (name >= 100 && name < 1000)
                return $"APC-0{name}";
            else if (name >= 1000 && name < 10000)
                return $"APC-{name}";
            return $"APC-{random.Next(0, 10000)}";
        }
        public APC(int name) : base(GetNomer(name))
        {
            MassMax = 150;
            VelocityNominale = 30;
        }
    }
}
