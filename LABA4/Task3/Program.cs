namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                for (int i = 0;i < 5; i++)
                {
                    double number = Convert.ToDouble(Console.ReadLine());

                    double square, cube, fourth;
                    PowerA234(number, out square, out cube, out fourth);

                    Console.WriteLine($"Число: {number}, Вторая степень: {square}, Третья степень: {cube}, Четвертая степень: {fourth}");
                }

             
 
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Неверный формат ввода числа");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }

        }

        static void PowerA234(double A, out double B, out double C, out double D)
        {
            B = Math.Pow(A, 2);
            C = Math.Pow(A, 3);
            D = Math.Pow(A, 4);
        }
    }
}