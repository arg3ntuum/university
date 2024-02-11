namespace CS_Zavd_2_var_3
{
    class Horse : Animal
    {
        public override void UpdateFatigue() =>
            Fatigue = 1 - (Mass / MassMax); 
        
        public Horse(string name) : base(name) 
        {
            MassMax = 6;
            VelocityNominale = 22;
        }
    }
}
