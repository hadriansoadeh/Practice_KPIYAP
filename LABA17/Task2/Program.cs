using LibraryAutoPark;
namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarPark carPark = new CarPark();

            Car car1 = new Car("BMW", "F90", 2022, 50000);
            Car car2 = new Car("Porshe", "911 Turbo S", 2017, 180000);

            carPark.AddCar(car1);
            carPark.AddCar(car2);

            carPark.ShowCarPark();
        }
    }
}
