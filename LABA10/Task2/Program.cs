namespace Task2
{
    class A
    {
        protected int a = 10;
        protected int b = 5;

        public int GetC()
        {
            return a + b;
        }
    }

    class B : A
    {
        private int d = 3;

        public int GetC2()
        {
            int result = 0;

            switch (GetC())
            {
                case 15:
                    result = a * b * d;
                    break;
                case 20:
                    result = (a + b) * d;
                    break;
                default:
                    result = a + b + d;
                    break;
            }

            return result;
        }

        public B() : base() { }

        public B(int a, int b, int d)
        {
            this.a = a;
            this.b = b;
            this.d = d;
        }
    }

    class Program
    {
        static void Main()
        {
            A objA = new A();
            Console.WriteLine("Value of property C in class A: " + objA.GetC());

            B objB1 = new B();
            Console.WriteLine("Value of property C2 in class B (created with base constructor): " + objB1.GetC2());

            B objB2 = new B(7, 3, 2);
            Console.WriteLine("Value of property C2 in class B (created with custom constructor): " + objB2.GetC2());
        }
    }

}
