using System.Threading.Channels;


namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                Console.Write("Введите первое число: ");
                int x = Convert.ToInt32(Console.ReadLine());
                

                if ((x + 12) == 0)
                {
                    if (2 * x + 6 == 0)
                    {
                        throw new DivideByZeroException("Деление на ноль невозможно!");
                    }
                    else
                    {
                        double result2 = Math.Log(Math.Abs(x)) - (Math.Atan(x * x * x) / (2 * x + 6));
                        Console.WriteLine("Результат: " + result2);
                        
                    } 

                    throw new DivideByZeroException("Деление на ноль невозможно!");
                }
                else
                {
                    double result1 = ((Math.Tan(x - 2)) / (x + 12)) + (Math.Pow(Math.Sin(x/2),2));
                    Console.WriteLine("Результат: " + result1);

                    if (2 * x + 6 == 0)
                    {
                        throw new DivideByZeroException("Деление на ноль невозможно!");
                    }
                    else
                    {
                        double result2 = Math.Log(x) - (Math.Atan(x * x * x) / (2 * x + 6));
                        Console.WriteLine("Результат: " + result2);
                        
                    }
                    

                }
            }
            
            catch (DivideByZeroException e)
            { 
                Console.WriteLine("Ошибка: " + e.Message);
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
    }
}