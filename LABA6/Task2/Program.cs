namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            string text = Console.ReadLine();
            int countDigit = 0;
            int countSymbol = 0;

            foreach (var element in text)
            {
                if (char.IsDigit(element))
                {
                    countDigit++;
                }
                else if (!char.IsDigit(element) && element != ' ')
                {
                    countSymbol++;
                    
                }          
            }

            Console.WriteLine($"Кол-во цифр в тексте : {countDigit} ");
            Console.WriteLine($"Кол-во символов в тексте : {countSymbol}");
        }
    }
}