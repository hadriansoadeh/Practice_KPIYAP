using Library;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();

            triangle.InputSides(3, 2, 4);

            Console.WriteLine($"Периметр: {triangle.CalculatePerimeter()} ");

        }
    }
}
