namespace Task2
{
    class Program
    {
        static void Main()
        {
            Task[] tasks = new Task[2];

            tasks[0] = Task.Run(() =>
            {
                Thread.Sleep(2000); 
                double alpha = 0.5; 
                double z1 = (1 - 2 * Math.Pow(Math.Sin(alpha), 2)) / (1 + Math.Sin(2 * alpha));
                Console.WriteLine("Задача 1 завершена, z1 = " + z1);
            });

            tasks[1] = Task.Run(() =>
            {
                Thread.Sleep(1000); 
                double alpha = 0.5; 
                double z2 = (1 - Math.Tan(alpha)) / (1 + Math.Tan(alpha));
                Console.WriteLine("Задача 2 завершена, z2 = " + z2);
            });

            Task.WhenAll(tasks).Wait(); 
            Console.WriteLine("Все задачи завершены");

            
        }
    }
}
