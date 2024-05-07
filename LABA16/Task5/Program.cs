namespace Task5
{
    class Program
    {
        static void Main()
        {
            
            File.WriteAllLines("f1.dat", new string[] { "1", "2", "3", "-1", "0" });
            File.WriteAllLines("f2.dat", new string[] { "2", "3", "4", "-2", "-1" });

            var f1 = File.ReadAllLines("f1.dat").Select(int.Parse).ToArray();
            var f2 = File.ReadAllLines("f2.dat").Select(int.Parse).ToArray();

           
            var minF2 = f2.Min();
            var closestToF2Min = f2.OrderBy(x => Math.Abs((long)x - minF2)).First(x => x != minF2);

            
            var posNegZeroCounts = new[] { f1, f2 }
                .Select((file, i) => new
                {
                    File = i + 1,
                    Positive = file.Count(x => x > 0),
                    Negative = file.Count(x => x < 0),
                    Zero = file.Count(x => x == 0)
                });

           
            var isF1Ordered = f1.SequenceEqual(f1.OrderBy(x => x));

           
            var isF1Alternating = f1.Skip(1).Select((x, i) => Math.Sign(x) != Math.Sign(f1[i])).All(x => x);

            
            Console.WriteLine($"Ближайшее к минимальному в f2.dat: {closestToF2Min}");
            foreach (var count in posNegZeroCounts)
            {
                Console.WriteLine($"Файл {count.File}: Положительных - {count.Positive}, Отрицательных - {count.Negative}, Нулей - {count.Zero}");
            }
            Console.WriteLine($"Числа в f1.dat упорядочены по возрастанию: {isF1Ordered}");
            Console.WriteLine($"Числа в f1.dat образуют знакопеременную последовательность: {isF1Alternating}");
        }
    }
}
