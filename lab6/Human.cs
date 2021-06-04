namespace lab_3
{
    public abstract class Human
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        protected int Intelligence;
        public int Money;
        
        protected bool SleptWell = true;
        
        public void Sleep()
        {
            SleptWell = true;
        }
        
        public void Sleep(int hours)
        {
            SleptWell = true;
            if (hours > 8)
            {
                Intelligence++;
            }
        }

        public abstract void Ability();
        public abstract void PrintInfo();
    }
}