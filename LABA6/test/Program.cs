using System.Text;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Александр Сергеевич Пушкин".Replace(" ", "").ToLower();
            int[] mas = GetNumberCodes(text);
            int Sum = mas.Sum();
            while (Sum > 9)
            {
                Sum = SumDigits(Sum);
            }
            Console.WriteLine(Sum);
        }

        public static string Alphabet = GetAplhabetString();

        static string GetAplhabetString()
        {
            var str = new StringBuilder();
            for (char i = 'а'; i <= 'я'; i++)
            {
                str.Append(i.ToString());
            }
            return str.ToString();
        }

        public static int[] GetNumberCodes(string text)
        {
            int[] array = new int[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                array[i] = Alphabet.IndexOf(text[i]) + 1;
            }
            return array;
        }
        public static int SumDigits(int Number)
        {
            int Sum = 0;
            while (Number > 0)
            {
                Sum += Number % 10;
                Number /= 10;
            }
            return Sum;
        }
    }
}