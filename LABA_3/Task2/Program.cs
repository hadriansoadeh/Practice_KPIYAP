using System.Transactions;

namespace Task2
{
    internal class Program
    {
        static void PowerA234(int A,out double B,out double C,out double D)
        {
            B = Math.Pow(A, 2);
            C = Math.Pow(A, 3);
            D = Math.Pow(A, 4);
            Console.WriteLine("Число " + A + " в степени 2 равно " + B);
            Console.WriteLine("Число " + A + " в степени 3 равно " + C);
            Console.WriteLine("Число " + A + " в степени 4 равно " + D);
        }
        static void Main(string[] args)
        {
            double B, C, D;
            int A = int.Parse(Console.ReadLine());
            PowerA234(A,out B,out C,out D);
                

        }
    }
}