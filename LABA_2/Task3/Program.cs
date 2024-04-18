namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HexCounter counter1 = new HexCounter();  
            Console.WriteLine("Текущее значение счетчика: " + counter1.Value);

            counter1.Increment();
            Console.WriteLine("После увеличения: " + counter1.Value);

            counter1.Decrement();
            Console.WriteLine("После уменьшения: " + counter1.Value);


            Console.WriteLine("\nВведите минимальное значение ");
            int minValue = int.Parse(Console.ReadLine());

            while (minValue > 15 | minValue < 0)
            {
                Console.WriteLine("Неправильное минимальное значение! Введите минимальное значение: ");
                minValue = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Введите максимальное значение");
            int maxValue = int.Parse(Console.ReadLine());

            while ((maxValue > 15 | maxValue < 0 | maxValue < minValue ))
            {
                Console.WriteLine("Неправильное максимальное значение! Введите максимальное значение: ");
                maxValue = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Введите текущее значение");
            int currentlyValue = int.Parse(Console.ReadLine());

            while (currentlyValue > maxValue | currentlyValue <  minValue)
            {
                Console.WriteLine("Неправильное текущее значение! Введите текущее значение: ");
                currentlyValue = int.Parse(Console.ReadLine());
            }

            HexCounter counter2 = new HexCounter(currentlyValue, minValue, maxValue);
            Console.WriteLine("\nТекущее значение счетчика: " + counter2.Value);

            counter2.Increment();
            Console.WriteLine("После увеличения: " + counter2.Value);

           

            counter2.Decrement();
            Console.WriteLine("После уменьшение: " + counter2.Value);
            }
            
                
          
        }
    }

    class HexCounter
    {
        private int value;
        private int minValue;
        private int maxValue;

        public HexCounter(int initialValue = 0, int minValue = 0, int maxValue = 15)
        {
            this.value = initialValue;
            this.minValue = minValue;
            this.maxValue = maxValue;
        }

        public int Value
        {
            get { return value; }
        }

        public void Increment()
        {
            value = (value == maxValue) ? minValue : value + 1;
        }

        public void Decrement()
        {
            value = (value == minValue) ? maxValue : value - 1;
        }
    }
