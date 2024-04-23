namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string inputSentence = Console.ReadLine();

            
            string[] words = inputSentence.Split(' ');

            
            string firstWord = words[0];
            string lastWord = words[^1];
            words[0] = lastWord;
            words[^1] = firstWord;

            
            string secondAndThirdWords = words[1] + words[2];

            
            string thirdWordReversed = ReverseWord(words[2]);

            
            string firstWordTrimmed = firstWord.Substring(2);

           
            Console.WriteLine($"Результаты действий:");
            Console.WriteLine($"1. Поменять местами первое и последнее слово: {string.Join(" ", words)}");
            Console.WriteLine($"2. Склеить второе и третье слова: {secondAndThirdWords}");
            Console.WriteLine($"3. Третье слово в обратном порядке: {thirdWordReversed}");
            Console.WriteLine($"4. В первом слове вырезать первые две буквы: {firstWordTrimmed}");
        }
        static string ReverseWord(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}