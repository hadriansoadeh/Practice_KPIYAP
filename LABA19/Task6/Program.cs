namespace Task6
{
    /// <summary>
    /// Делегат для вычисления свойств фигуры.
    /// </summary>
    /// <param name="R">Радиус фигуры.</param>
    /// <returns>Результат вычисления.</returns>
    delegate double CalcFigure(double R);

    class Program
    {
        static void Main()
        {
            CalcFigure CF = null;

            // Вычисление длины окружности
            CF = Get_Length;
            Console.WriteLine("Длина окружности: " + CF(5));

            // Вычисление площади круга
            CF = Get_Area;
            Console.WriteLine("Площадь круга: " + CF(5));

            // Вычисление объема шара
            CF = Get_Volume;
            Console.WriteLine("Объем шара: " + CF(5));
        }

        /// <summary>
        /// Вычисляет длину окружности.
        /// </summary>
        /// <param name="R">Радиус окружности.</param>
        /// <returns>Длина окружности.</returns>
        static double Get_Length(double R)
        {
            return 2 * Math.PI * R;
        }

        /// <summary>
        /// Вычисляет площадь круга.
        /// </summary>
        /// <param name="R">Радиус круга.</param>
        /// <returns>Площадь круга.</returns>
        static double Get_Area(double R)
        {
            return Math.PI * R * R;
        }

        /// <summary>
        /// Вычисляет объем шара.
        /// </summary>
        /// <param name="R">Радиус шара.</param>
        /// <returns>Объем шара.</returns>
        static double Get_Volume(double R)
        {
            return 4.0 / 3.0 * Math.PI * R * R * R;
        }
    }
}
