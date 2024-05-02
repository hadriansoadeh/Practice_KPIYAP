namespace Task1
{
    delegate double CalcFigure(double R);

    class Program
    {
        static void Main()
        {
            CalcFigure CF = null;

            
            CF = Get_Length;
            Console.WriteLine("Длина окружности: " + CF(5));

           
            CF = Get_Area;
            Console.WriteLine("Площадь круга: " + CF(5));

            
            CF = Get_Volume;
            Console.WriteLine("Объем шара: " + CF(5));
        }

        static double Get_Length(double R)
        {
            return 2 * Math.PI * R;
        }

        static double Get_Area(double R)
        {
            return Math.PI * R * R;
        }

        static double Get_Volume(double R)
        {
            return 4.0 / 3.0 * Math.PI * R * R * R;
        }
    }
}
