namespace Task5
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 6, 5, 12 };
            CancellationTokenSource cts = new CancellationTokenSource();

            Parallel.ForEach(numbers, new ParallelOptions { CancellationToken = cts.Token }, (n, loopState) =>
            {
                int sum = Enumerable.Range(0, n + 1).Sum();
                int product = Enumerable.Range(1, n + 1).Aggregate(1, (a, b) => a * b);

                Console.WriteLine($"Для числа {n}, сумма = {sum}, произведение = {product}");

                if (sum > 535 || product > 535)
                {
                    Console.WriteLine($"Прерывание выполнения для числа {n}...");
                    cts.Cancel();
                    loopState.Stop();
                }
            });
        }
    }
}
