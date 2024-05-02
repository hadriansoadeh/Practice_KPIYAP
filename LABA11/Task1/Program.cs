namespace Task1
{
    class Building
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public virtual void CalculateFoundationHeight()
        {
            Console.WriteLine("Расчет высоты фундамента для здания: " + name);
        }
    }

    class Office : Building
    {
        public int numberOfFloors;

        public override void CalculateFoundationHeight()
        {
            double foundationHeight = 0.05 * numberOfFloors;
            Console.WriteLine("Высота фундамента для офисного здания " + Name + " с " + numberOfFloors + " этажами: " + foundationHeight + " метров");
        }
    }

    class Factory : Building
    {
        public double weight;

        public override void CalculateFoundationHeight()
        {
            double foundationHeight = 0.000002 * weight;
            Console.WriteLine("Высота фундамента для здания завода " + Name + " с весом " + weight + " кг: " + foundationHeight + " метров");
        }
    }

    class Program
    {
        static void Main()
        {
            Building[] buildings = new Building[5];

            buildings[0] = new Building();
            buildings[0].Name = "Здание 1";

            buildings[1] = new Office();
            buildings[1].Name = "Офисное здание 1";
            ((Office)buildings[1]).numberOfFloors = 5;

            buildings[2] = new Factory();
            buildings[2].Name = "Завод 1";
            ((Factory)buildings[2]).weight = 50000;

            buildings[3] = new Building();
            buildings[3].Name = "Здание 2";

            buildings[4] = new Office();
            buildings[4].Name = "Офисное здание 2";
            ((Office)buildings[4]).numberOfFloors = 3;

            foreach (var building in buildings)
            {
                building.CalculateFoundationHeight();
            }
        }
    }

}
