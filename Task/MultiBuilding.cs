namespace Task
{
    sealed class MultiBuilding : Building
    {
        int numberStage;

        public int NumberStage
        {
            get
            {
                return numberStage;
            }
            set
            {
                if (value < 0)
                    numberStage = 0;
                else
                    numberStage = value;
            }
        }

        public MultiBuilding(string Adress, double Lenght, double Width, double Height, int NumberStage)
            : base(Adress, Lenght, Width, Height)
        {
            this.NumberStage = NumberStage;
        }

        public string Print()
        {
            string result = base.Print();
            result += $", количество этажей в здании -  {numberStage}";
            return result;
        }
    }
}
