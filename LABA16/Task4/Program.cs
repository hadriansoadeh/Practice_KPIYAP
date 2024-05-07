namespace Task4
{
    class Program
    {
        static void Main()
        {
            var lines = File.ReadAllLines("input.txt");
            File.WriteAllLines("evenLines.txt", lines.Where((line, index) => index % 2 != 0));
            File.WriteAllLines("oddLines.txt", lines.Where((line, index) => index % 2 == 0));
        }
    }
}
