namespace Task1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            A operation = new A(a,b);

            Console.WriteLine("Значение переменной a: " + operation.a);
            Console.WriteLine("Значение переменной b: " + operation.b);

            Console.WriteLine("Разность: " + operation.Subtraction());
            Console.WriteLine("Значение выражения: " + operation.Division());
        }

    }
    class A
    {
        public int a;
        public int b;

        public A(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int Subtraction()
        {
            return a - b;
        }

        public double Division()
        {
            return (double)(a + b) / (a - b);
        }
    }


}