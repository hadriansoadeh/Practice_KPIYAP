namespace LibraryAutoPark
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Mileage { get; set; }

        public Car(string brand, string model, int year, double mileage)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Mileage = mileage;
        }

        public override string ToString()
        {
            return $"Марка: {Brand}, Модель: {Model}, Год: {Year}, Пробег: {Mileage}";
        }
    }

    public class CarPark
    {
        private List<Car> carPark;

        public CarPark()
        {
            carPark = new List<Car>();
        }

        public void AddCar(Car car)
        {
            carPark.Add(car);
        }

        public void RemoveCar(Car car)
        {
            carPark.Remove(car);
        }

        public void ShowCarPark()
        {
            foreach (var car in carPark)
            {
                Console.WriteLine(car);
            }
        }
    }
}
