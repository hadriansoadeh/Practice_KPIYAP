/// <summary>
/// Пространство имен для задания 15.
/// </summary>
namespace Task15
{
    /// <summary>
    /// Основной класс программы.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        static void Main()
        {
            // Запись слов в файл.
            File.WriteAllLines("words.txt", new string[] { "apple", "banana", "cherry", "date", "elderberry" });

            // Чтение слов из файла.
            var words = File.ReadAllLines("words.txt");

            // Инициализация буквы и длины.
            char letter = 'a';
            int length = 5;

            // Получение слов, начинающихся на определенную букву.
            var wordsStartingWithLetter = words.Where(word => word.StartsWith(letter));
            Console.WriteLine($"Слова, начинающиеся на букву '{letter}': {string.Join(", ", wordsStartingWithLetter)}");

            // Получение слов определенной длины.
            var wordsWithLength = words.Where(word => word.Length == length);
            Console.WriteLine($"Слова длиной {length}: {string.Join(", ", wordsWithLength)}");

            // Получение слов, начинающихся и заканчивающихся на одну и ту же букву.
            var wordsSameStartEnd = words.Where(word => word.First() == word.Last());
            Console.WriteLine($"Слова, начинающиеся и заканчивающиеся на одну и ту же букву: {string.Join(", ", wordsSameStartEnd)}");

            // Если есть слова, получение слов, начинающихся на ту же букву, что и первая буква последнего слова.
            if (words.Any())
            {
                char lastWordFirstLetter = words.Last().First();
                var wordsStartingWithLastWordFirstLetter = words.Where(word => word.StartsWith(lastWordFirstLetter));
                Console.WriteLine($"Слова, начинающиеся на ту же букву, что и первая");
            }
        }
    }
}
