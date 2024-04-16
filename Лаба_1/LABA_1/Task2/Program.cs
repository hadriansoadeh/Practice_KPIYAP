namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Число является четным");
            }
            else 
            { 
                Console.WriteLine("Число является нечетным"); 
            }
        }
    }
}