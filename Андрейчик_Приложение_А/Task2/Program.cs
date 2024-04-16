namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите двузначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number >= 10 && number <= 99)
            {
                int firstDigit = number / 10;
                int secondDigit = number % 10;
                int product = firstDigit * secondDigit;

                Console.WriteLine($"Произведение цифр числа {number}: {product}");
            }
            else
            {
                Console.WriteLine("Введенное число не является двузначным.");
            }
        }
    }
}