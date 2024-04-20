using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер матрицы (N): ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("Введите нижнюю границу случайных чисел (a): ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите верхнюю границу случайных чисел (b): ");
            int b = int.Parse(Console.ReadLine());

            
            int[,] matrix = new int[N, N];
            Random random = new Random();

           
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = random.Next(a, b + 1); 
                }
            }

          
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            
            int negativeSum = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        negativeSum += matrix[i, j];
                    }
                }
            }
            Console.WriteLine($"Сумма отрицательных элементов: {negativeSum}");

            
            for (int i = 0; i < N; i++)
            {
                int evenCount = 0;
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        evenCount++;
                    }
                }
                Console.WriteLine($"Количество четных элементов в строке {i + 1}: {evenCount}");
            }

            Console.ReadKey();
        }
    }
}
