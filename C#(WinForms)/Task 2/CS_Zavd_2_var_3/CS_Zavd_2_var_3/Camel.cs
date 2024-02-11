namespace CS_Zavd_2_var_3
{
    class Camel : Animal
    {
        public override void UpdateFatigue() =>
            Fatigue = 0.4 * (TakeSpeed()/VelocityNominale);

        public Camel(string name) : base(name)
        {
            MassMax = 12;
            VelocityNominale = 14;

        }
    }
}
