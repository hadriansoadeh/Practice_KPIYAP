namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите значение b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Введите значение шага h: ");
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine("x | y");
            for (int x = a; x <= b; x += h)
            {
                double y = function(a,b,x);
                Console.WriteLine($"{x} | {y}");
            }


        }
        static double function(int a,int b,int x)
        {
            double result = 0;
            if (Math.Abs(x) < 3)
            {
                 result = (Math.Sin(Math.Sin(x + a)));
                
            }
            else if (Math.Abs(x) >= 3 && Math.Abs(x) <= 9)
            {
                result = (Math.Sqrt(x * x + a) / Math.Sqrt(x * x + b));
            }
            else if (Math.Abs(x) >= 9)
            {
                result = Math.Sqrt(x * x + a) - Math.Sqrt(x * x + b);

            }

            return result;
        }
    }
}