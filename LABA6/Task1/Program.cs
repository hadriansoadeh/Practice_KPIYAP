namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();

            for (int i = 0;i < text.Length;i++)
            {
                if (text[i] == ' ')
                {
                    Console.Write(i + 1 + " ");
                }
            }
        }

    }
}