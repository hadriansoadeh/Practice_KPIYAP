namespace Task6
{
    class Program
    {
        static void Main()
        {

            File.WriteAllLines("words.txt", new string[] { "apple", "banana", "cherry", "date", "elderberry" });

            var words = File.ReadAllLines("words.txt");


            char letter = 'a';
            int length = 5;


            var wordsStartingWithLetter = words.Where(word => word.StartsWith(letter));
            Console.WriteLine($"Слова, начинающиеся на букву '{letter}': {string.Join(", ", wordsStartingWithLetter)}");


            var wordsWithLength = words.Where(word => word.Length == length);
            Console.WriteLine($"Слова длиной {length}: {string.Join(", ", wordsWithLength)}");


            var wordsSameStartEnd = words.Where(word => word.First() == word.Last());
            Console.WriteLine($"Слова, начинающиеся и заканчивающиеся на одну и ту же букву: {string.Join(", ", wordsSameStartEnd)}");


            if (words.Any())
            {
                char lastWordFirstLetter = words.Last().First();
                var wordsStartingWithLastWordFirstLetter = words.Where(word => word.StartsWith(lastWordFirstLetter));
                Console.WriteLine($"Слова, начинающиеся на ту же букву, что и первая");
            }
        }

    }
}
