namespace task4
{
    internal class Class
    {
        static void Main()
        {
            Console.WriteLine("Введите фамилию, имя и отчество: ");
            string fullName = Console.ReadLine();

            int sum = 0;
            foreach (char c in fullName.ToUpper())
            {
                if (char.IsLetter(c))
                {
                    sum += c - 'А' + 1;
                }
            }

            while (sum > 9)
            {
                int tempSum = 0;
                while (sum > 0)
                {
                    tempSum += sum % 10;
                    sum /= 10;
                }
                sum = tempSum;
            }

            Console.WriteLine("Код личности: " + sum);
        }
    }
}