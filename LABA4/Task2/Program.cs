namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите значение x: ");
                double x = Convert.ToDouble(Console.ReadLine());

                double result;

                if (x <= -1)
                {
                    result = 3;
                }
                else if (x > -1 && x < 1)
                {
                    if (x == 0)
                    {
                        throw new DivideByZeroException("Деление на ноль невозможно!");
                    }
                    result = 1 / x;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("x не может быть больше 1");
                }

                Console.WriteLine("Результат: " + result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Неверный формат ввода числа");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }
        }
    }
}