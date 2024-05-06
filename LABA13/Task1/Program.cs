namespace Task1
{
    public delegate void TriangleDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            TriangleDelegate triangleDelegate = new TriangleDelegate(Perimeter);
            triangleDelegate += Area;
            triangleDelegate += PrintSide;

            triangleDelegate.Invoke();
        }

        static void Perimeter()
        {
            try
            {
                Console.WriteLine("Введите длину стороны равностороннего треугольника:");
                double side = Convert.ToDouble(Console.ReadLine());
                double perimeter = 3 * side;
                Console.WriteLine("Периметр равностороннего треугольника: " + perimeter);
            }
            catch (FormatException)
            {
                Console.WriteLine("Пожалуйста, введите корректное число.");
            }
        }

        static void Area()
        {
            try
            {
                Console.WriteLine("Введите длину стороны равностороннего треугольника:");
                double side = Convert.ToDouble(Console.ReadLine());
                double area = (Math.Sqrt(3) / 4) * Math.Pow(side, 2);
                Console.WriteLine("Площадь равностороннего треугольника: " + area);
            }
            catch (FormatException)
            {
                Console.WriteLine("Пожалуйста, введите корректное число.");
            }
        }

        static void PrintSide()
        {
            try
            {
                Console.WriteLine("Введите длину стороны равностороннего треугольника:");
                double side = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Длина стороны равностороннего треугольника: " + side);
            }
            catch (FormatException)
            {
                Console.WriteLine("Пожалуйста, введите корректное число.");
            }
        }
    }
}
