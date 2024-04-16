namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            for (int i = 100; i <= 1001; i++)
            {
                if ( i == i * i % 1000)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}