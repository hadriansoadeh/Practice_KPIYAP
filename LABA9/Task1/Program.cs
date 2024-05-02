namespace Task1
{
    public interface Iy
    {
        double F0(double w);
        double F1(double w);
    }

    public interface Iz
    {
        double F0(double w);
        double F1(double w);
    }

    class Program : Iy, Iz
    {
        public double F0(double w)
        {
            return Math.Cos(w);
        }

        public double F1(double w)
        {
            return Math.Exp(w);
        }

        public double IyF0(double w)
        {
            return ((Iy)this).F0(w);
        }

        public double IyF1(double w)
        {
            return ((Iy)this).F1(w);
        }

        public double IzF0(double w)
        {
            return ((Iz)this).F0(w);
        }

        public double IzF1(double w)
        {
            return ((Iz)this).F1(w);
        }

        static void Main()
        {
            Program program = new Program();
            double w = 1.0;

            Console.WriteLine("F0 from Iy: " + program.IyF0(w));
            Console.WriteLine("F1 from Iy: " + program.IyF1(w));
            Console.WriteLine("F0 from Iz: " + program.IzF0(w));
            Console.WriteLine("F1 from Iz: " + program.IzF1(w));
        }
    }
}
    
