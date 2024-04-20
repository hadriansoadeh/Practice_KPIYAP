using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numbers = new int[50];
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 101); 
            }

            
            Console.WriteLine("Исходный массив:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

           
            int lastNumber = numbers[numbers.Length - 1];

           
            int differentCount = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] != lastNumber)
                {
                    differentCount++;
                }
            }

            
            Console.WriteLine($"Количество чисел, отличных от последнего ({lastNumber}), равно {differentCount}.");

            
            Array.Sort(numbers);

            
            Console.WriteLine("Отсортированный массив:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            
            Console.Write("Введите число k: ");
            int k = int.Parse(Console.ReadLine());

            
            int index = Array.BinarySearch(numbers, k);
            if (index >= 0)
            {
                Console.WriteLine($"Число {k} найдено в массиве на позиции {index + 1}.");
            }
            else
            {
                Console.WriteLine($"Число {k} не найдено в массиве.");
            }

            Console.ReadKey();
        }
    }
}
