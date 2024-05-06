using System;
using System.Threading;

class Program
{
    static int[] numbers = { 5, 12, 8, 23, 6, 10, 15, 18 }; // Пример массива чисел

    static int CalculatePartialSum(object data)
    {
        int partialSum = 0;
        int startIndex = (int)data;

        for (int i = startIndex; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                partialSum += numbers[i];
            }
        }

        return partialSum;
    }

    static void Main()
    {
        int numThreads = 4; // Количество потоков
        int totalSum = 0;
        Thread[] threads = new Thread[numThreads];
        int[] partialSums = new int[numThreads];

        for (int i = 0; i < numThreads; i++)
        {
            int index = i;
            threads[i] = new Thread(() =>
            {
                partialSums[index] = CalculatePartialSum(index);
            });
            threads[i].Start();
        }

        for (int i = 0; i < numThreads; i++)
        {
            threads[i].Join();
            totalSum += partialSums[i];
        }

        Console.WriteLine($"Общая сумма четных чисел: {totalSum}");

        Console.ReadLine();
    }
}
