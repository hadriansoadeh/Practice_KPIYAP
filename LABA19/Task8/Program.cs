/// <summary>
/// Пространство имен Task3 содержит класс Program и делегат StringDelegate.
/// </summary>
namespace Task8
{
    /// <summary>
    /// Делегат StringDelegate принимает строку и не возвращает значение.
    /// </summary>
    /// <param name="str">Строка для обработки.</param>
    delegate void StringDelegate(string str);

    /// <summary>
    /// Класс Program содержит методы для работы со строками.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        static void Main()
        {
            StringDelegate stringDelegate = ReverseString;
            stringDelegate += ToUpperString;
            stringDelegate += CountWords;

            string inputString = "Hello, World!";

            stringDelegate(inputString);
        }

        /// <summary>
        /// Метод ReverseString переворачивает строку.
        /// </summary>
        /// <param name="str">Строка для переворачивания.</param>
        static void ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);
            Console.WriteLine("Reversed string: " + reversedString);
        }

        /// <summary>
        /// Метод ToUpperString преобразует строку в верхний регистр.
        /// </summary>
        /// <param name="str">Строка для преобразования.</param>
        static void ToUpperString(string str)
        {
            string upperString = str.ToUpper();
            Console.WriteLine("Uppercase string: " + upperString);
        }

        /// <summary>
        /// Метод CountWords подсчитывает количество слов в строке.
        /// </summary>
        /// <param name="str">Строка для подсчета слов.</param>
        static void CountWords(string str)
        {
            string[] words = str.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;
            Console.WriteLine("Number of words: " + wordCount);
        }
    }
}
