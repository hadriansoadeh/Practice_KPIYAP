namespace Task3
{
    delegate void StringDelegate(string str);

    class Program
    {
        static void Main()
        {
            StringDelegate stringDelegate = ReverseString;
            stringDelegate += ToUpperString;
            stringDelegate += CountWords;

            string inputString = "Hello, World!";

            stringDelegate(inputString);
        }

        static void ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);
            Console.WriteLine("Reversed string: " + reversedString);
        }

        static void ToUpperString(string str)
        {
            string upperString = str.ToUpper();
            Console.WriteLine("Uppercase string: " + upperString);
        }

        static void CountWords(string str)
        {
            string[] words = str.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;
            Console.WriteLine("Number of words: " + wordCount);
        }
    }
}
