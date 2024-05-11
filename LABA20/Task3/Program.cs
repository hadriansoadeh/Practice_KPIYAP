namespace Task3
{
    class Program
    {
        static void Main()
        {
            int number = 34; 

            Task<int> task1 = Task.Run(() =>
            {
                int product = (number / 10) * (number % 10); 
                return product;
            });

            Task task2 = task1.ContinueWith((t) =>
            {
                Console.WriteLine("Произведение цифр числа: " + t.Result);
            });

            task2.Wait(); 
        }
    }
}
