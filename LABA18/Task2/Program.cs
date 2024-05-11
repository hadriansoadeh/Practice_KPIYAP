namespace Task2
{
    public class Program
    {
        public static void Main()
        {
            int a = 10, b = 20; 
            var queue1 = new Queue<int>();
            var queue2 = new Queue<int>();
            var queue3 = new Queue<int>();

            foreach (var number in File.ReadLines("numbers.txt").Select(int.Parse))
            {
                if (number >= a && number <= b)
                    queue1.Enqueue(number);
                else if (number < a)
                    queue2.Enqueue(number);
                else
                    queue3.Enqueue(number);
            }

            File.WriteAllLines("output.txt", queue1.Concat(queue2).Concat(queue3).Select(n => n.ToString()));
        }
    }
}
