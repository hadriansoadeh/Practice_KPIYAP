namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ArrayLength = int.Parse(Console.ReadLine());
            double[] arr = new double[ArrayLength];
            double sumElements = 0;
            

            Random random = new Random();

            for (int i = 0;i < ArrayLength;i++)
            {
                arr[i] = random.Next(0, 50);
            }

            foreach (double el in arr)
            {
                sumElements += el;
            }

            for (int i = 0;i < ArrayLength;i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Сумма элементов массива: " + sumElements);
            Console.WriteLine("Кол-во элементов массива: " + arr.Count());
            




        }
    }
}