namespace Library
{
    public class Triangle
    {
        private double a, b, c;

        public void InputSides(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public bool CheckExistence()
        {
            return a + b > c && a + c > b && b + c > a;
        }

        public double CalculatePerimeter()
        {
            return a + b + c;
        }

        public double CalculateArea()
        {
            double p = CalculatePerimeter() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public string DetermineType()
        {
            if (a == b && b == c)
                return "equilateral";
            else if (a == b || a == c || b == c)
                return "isosceles";
            else
                return "scalene";
        }
    }

    public class Rectangle
    {
        private double a, b;

        public void InputSides(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double CalculatePerimeter()
        {
            return 2 * (a + b);
        }

        public double CalculateArea()
        {
            return a * b;
        }
    }
}
