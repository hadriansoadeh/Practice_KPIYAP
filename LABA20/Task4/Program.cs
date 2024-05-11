namespace Task4
{
    class Program
    {
        static void Main()
        {
            double A = -3; 
            double B = 7; 
            int N = 1000; 

            double step = (B - A) / N;

            Parallel.For(0, N, i =>
            {
                double x = A + i * step;
                double y = Function(x); 
                Console.WriteLine($"f({x}) = {y}");
            });
        }

        static double Function(double x)
        {
            
            return 2 - Math.Sin(x);
        }
    }
}
