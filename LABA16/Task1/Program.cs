namespace Task1
{
    class Program
    {
        static void Main()
        {
            string filePath = "f.txt"; 

            
            using (StreamWriter sw = File.CreateText(filePath))
            {
                Random random = new Random();
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(random.NextDouble() * 50);
                }
            }

            
            var numbers = File.ReadAllLines(filePath).Select(double.Parse).ToList();

            double sum = numbers.Sum();
            double difference = numbers.First() - numbers.Last();

            Console.WriteLine("Сумма всех чисел: " + sum);
            Console.WriteLine("Разность первого и последнего числа: " + difference);
        }
    }
}
