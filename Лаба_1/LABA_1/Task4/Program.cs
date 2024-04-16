namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите вид цикла: while - 1,do while - 2 ,for - 3");
            int choice = int.Parse(Console.ReadLine());
            int number = 80;

            if (choice == 1)
            {
                while (number >= 10)
                {
                    Console.WriteLine(number);
                    number -= 2;
                }
            }
            else if (choice == 2)
            {
                do
                {
                    Console.WriteLine(number);
                    number -= 2;
                } 
                while (number >= 10);
            }
            else if (choice == 3)
            {
                
                for (number = 80; number >= 10; number -= 2)
                {
                    Console.WriteLine(number);
                }
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }
    }
}