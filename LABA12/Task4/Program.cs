namespace Task4
{
    delegate int RandomNumberDelegate();

    class Program
    {
        static void Main()
        {
            RandomNumberDelegate[] delegates = {
            new RandomNumberDelegate(() => GetRandomNumber()),
            new RandomNumberDelegate(() => GetRandomNumber()),
            new RandomNumberDelegate(() => GetRandomNumber())
        };

            Console.WriteLine($"Среднее случайных чисел: {CalculateAverage(delegates)}");
        }

        static int GetRandomNumber()
        {
            Random random = new Random();
            return random.Next(1, 101); 
        }

        static double CalculateAverage(params RandomNumberDelegate[] delegates)
        {
            int sum = 0;
            foreach (var del in delegates)
            {
                sum += del();
            }

            return (double)sum / delegates.Length;
        }
    }
}
