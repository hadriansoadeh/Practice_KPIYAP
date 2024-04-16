namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите четырехзначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number >= 1000 && number <= 9999)
            {
                int product = 1;
                int digit;
                while (number > 0)
                {
                    digit = number % 10;
                    product *= digit;
                    number /= 10;
                }

                Console.WriteLine($"Произведение цифр четырехзначного числа: {product}");
            }
            else
            {
                Console.WriteLine("Введенное число не является четырехзначным.");
            }

        }
    }
    }
}