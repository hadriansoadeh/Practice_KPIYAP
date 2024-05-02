namespace Task2
{
    abstract class Building
    {
        protected string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public abstract void CalculateFoundationHeight();
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

            buildings[0] = new Office { Name = "Офисное здание 1", numberOfFloors = 5 };
            buildings[1] = new Factory { Name = "Завод 1", weight = 50000 };
            buildings[2] = new Office { Name = "Офисное здание 2", numberOfFloors = 3 };
            buildings[3] = new Office { Name = "Офисное здание 3", numberOfFloors = 8 };
            buildings[4] = new Factory { Name = "Завод 2", weight = 100000 };

            double maxFoundationHeight = 0;

            foreach (var building in buildings)
            {
                building.CalculateFoundationHeight();

                
                if (building is Office office && office.numberOfFloors > 0)
                {
                    double foundationHeight = 0.05 * office.numberOfFloors;
                    if (foundationHeight > maxFoundationHeight)
                    {
                        maxFoundationHeight = foundationHeight;
                    }
                }
                else if (building is Factory factory && factory.weight > 0)
                {
                    double foundationHeight = 0.000002 * factory.weight;
                    if (foundationHeight > maxFoundationHeight)
                    {
                        maxFoundationHeight = foundationHeight;
                    }
                }
            }

            Console.WriteLine("Максимальная высота фундамента всех зданий: " + maxFoundationHeight + " метров");
        }
    }

}
