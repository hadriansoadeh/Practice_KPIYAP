namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5];
            Random random = new Random();


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = random.Next(0, 16);
                }
            }


            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Введите число");
            int k = int.Parse(Console.ReadLine());

            int sumElements = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    sumElements += matrix[i, j];
                    
                }
                if (sumElements > k)
                {
                    Console.WriteLine($"Сумма чисел в строке {i + 1} равна {sumElements} и больше {k} ");
                }
                else if (sumElements < k)
                {
                    Console.WriteLine($"Сумма чисел в строке {i + 1} равна {sumElements} и меньше {k} ");
                }
                Console.WriteLine();
            }


        }
    }
}