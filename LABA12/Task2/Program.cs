namespace Task2
{
    class Program
    {
        static void Main()
        {
            Func<double, double, double> Add = (a, b) => a + b;
            Func<double, double, double> Sub = (a, b) => a - b;
            Func<double, double, double> Mul = (a, b) => a * b;
            Func<double, double, double> Div = (a, b) =>
            {
                if (b != 0)
                {
                    return a / b;
                }
                else
                {
                    Console.WriteLine("Ошибка: деление на ноль!");
                    return double.NaN; // возвращаем NaN (Not a Number), чтобы обозначить ошибку
                }
            };

            Console.WriteLine("Введите два числа:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Выберите операцию: \n1 - Сложение\n2 - Вычитание\n3 - Умножение\n4 - Деление");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result = 0;

            switch (choice)
            {
                case 1:
                    result = Add(num1, num2);
                    break;
                case 2:
                    result = Sub(num1, num2);
                    break;
                case 3:
                    result = Mul(num1, num2);
                    break;
                case 4:
                    result = Div(num1, num2);
                    break;
                default:
                    Console.WriteLine("Неверный выбор операции.");
                    break;
            }

            Console.WriteLine("Результат: " + result);
        }
    }
}
