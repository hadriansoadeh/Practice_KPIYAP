
using System.Threading;

class Program
{
    static int CalculateSum(int A, int N)
    {
        int sum = 0;
        for (int i = 1; i <= N; i++)
        {
            sum += A;
        }
        return sum;
    }

    static int CalculateProduct(int A, int N)
    {
        int product = 1;
        for (int i = 1; i <= N; i++)
        {
            product *= A;
        }
        return product;
    }

    static void Main()
    {
        Console.Write("Введите число A: ");
        int A = int.Parse(Console.ReadLine());

        Console.Write("Введите число N: ");
        int N = int.Parse(Console.ReadLine());

        Thread t1 = new Thread(() =>
        {
            int sum = CalculateSum(A, N);
            Console.WriteLine($"Сумма: {sum}");
        });

        Thread t2 = new Thread(() =>
        {
            int product = CalculateProduct(A, N);
            Console.WriteLine($"Произведение: {product}");
        });

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        Console.ReadLine();
    }
}
