using System;
using System.Threading;

class Program
{
    static int SumNumbers()
    {
        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            sum += i;
        }
        return sum;
    }

    static void Main()
    {
        Thread t1 = new Thread(() =>
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int result = SumNumbers();
            watch.Stop();
            Console.WriteLine($"Поток 1: Сумма чисел от 1 до 10 равна {result}. Время выполнения: {watch.ElapsedMilliseconds} мс");
        });

        Thread t2 = new Thread(() =>
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int result = SumNumbers();
            watch.Stop();
            Console.WriteLine($"Поток 2: Сумма чисел от 1 до 10 равна {result}. Время выполнения: {watch.ElapsedMilliseconds} мс");
        });

        t1.Start();
        t2.Start();

        Console.ReadLine();
    }
}
