using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение n: ");
            int n = int.Parse(Console.ReadLine());

            double result = CalculateFunction(n);

            Console.WriteLine($"f({n}) = {result}");

            Console.ReadKey();
        }

        
        static int Factorial(int num)
        {
            if (num == 0 || num == 1)
                return 1;
            else
                return num * Factorial(num - 1);
        }

        
        static double CalculateFunction(int n)
        {
            if (n == 0)
                return 0; 
            else
                return 2.0 / Factorial(n); 
        }
    }
}
