using System;
using System.Threading;

class Program
{
    static AutoResetEvent firstEvent = new AutoResetEvent(false);
    static AutoResetEvent secondEvent = new AutoResetEvent(false);

    static void Main()
    {
        Thread t1 = new Thread(PrintNumbers);
        Thread t2 = new Thread(PrintNumbers);
        Thread t3 = new Thread(PrintNumbers);

        t1.Name = "Поток 1";
        t2.Name = "Поток 2";
        t3.Name = "Поток 3";

        t1.Start(0);
        t2.Start(10);
        t3.Start(20);

        firstEvent.Set();

        Console.ReadLine();
    }

    static void PrintNumbers(object startingNumber)
    {
        int number = (int)startingNumber;
        for (int i = 0; i < 10; i++)
        {
            firstEvent.WaitOne();
            Console.WriteLine($"{Thread.CurrentThread.Name}: {number}");
            secondEvent.Set();
            number++;
        }
    }
}
