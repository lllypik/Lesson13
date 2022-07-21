namespace Task
{
    public class Building
    {
        string adress;
        double lenght;
        double width;
        double height;

        public string Adress
        {
            get
            {
                return adress;
            }
            set
            {
                adress = value;
            }
        }

        public double Lenght
        {
            get
            {
                return lenght;
            }
            set
            {
                if (value < 0)
                    lenght = 0;
                else
                    lenght = value;
            }
        }

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value < 0)
                    width = 0;
                else
                    width = value;
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                    height = 0;
                else
                    height = value;
            }

        }
        public Building(string Adress, double Lenght, double Width, double Height)
        {
            this.Adress = Adress;
            this.Lenght = Lenght;
            this.Width = Width;
            this.Height = Height;
        }
        public string Print()
        {
            return $"Здание по адресу {adress} имеет размеры Д х Ш х В  {lenght} x {width} x {height}";
        }
    }
}
