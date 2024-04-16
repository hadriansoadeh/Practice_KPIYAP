namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] animals = { "Крыса", "Корова", "Тигр", "Заяц", "Дракон", "Змея", "Лошадь", "Овца", "Обезьяна", "Петух", "Собака", "Свинья" };

            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());

            int animalIndex = (year - 1900) % 12;

            if (year >= 1900)
            {
                Console.WriteLine($"Год {year} соответствует животному: {animals[animalIndex]}");
            }
            else
            {
                Console.WriteLine("Год должен быть больше или равен 1900.");
            }
        }
    }
}