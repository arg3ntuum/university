namespace CS_Zavd_2_var_3
{
    class Crocodile : Animal
    {
        public override void UpdateFatigue() =>
            Fatigue = 1 + 0.2 * Fatigue - 0.6 * (Mass / MassMax);

        public Crocodile(string name) : base(name)
        {
            MassMax = 12;
            VelocityNominale = 6;

        }
    }
}
