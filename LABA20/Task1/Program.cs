namespace Task1
{
    public class Task
    {
        private int number;

        public Task(int number)
        {
            this.number = number;
        }

        public int ProductOfDigits()
        {
            int product = 1;
            while (number > 0)
            {
                product *= number % 10;
                number /= 10;
            }
            return product;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Task task1 = new Task(1234);
            Task task2 = new Task(5678);
            Task task3 = new Task(9123);

            Console.WriteLine(task1.ProductOfDigits());  
            Console.WriteLine(task2.ProductOfDigits()); 
            Console.WriteLine(task3.ProductOfDigits());  
        }
    }
}
