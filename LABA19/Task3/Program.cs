/// <summary>
/// Пространство имен Task3.
/// </summary>
namespace Task3
{
    /// <summary>
    /// Класс FixedStringArray представляет двумерный массив строк фиксированного размера.
    /// </summary>
    class FixedStringArray
    {
        /// <summary>
        /// Двумерный массив строк.
        /// </summary>
        private string[,] array;

        /// <summary>
        /// Конструктор класса FixedStringArray.
        /// </summary>
        /// <param name="rows">Количество строк в массиве.</param>
        /// <param name="columns">Количество столбцов в массиве.</param>
        public FixedStringArray(int rows, int columns)
        {
            array = new string[rows, columns];
        }

        /// <summary>
        /// Индексатор для доступа к элементам массива.
        /// </summary>
        /// <param name="i">Индекс строки.</param>
        /// <param name="j">Индекс столбца.</param>
        /// <returns>Элемент массива на позиции [i, j].</returns>
        public string this[int i, int j]
        {
            get { return array[i, j]; }
            set { array[i, j] = value; }
        }

        /// <summary>
        /// Оператор равенства для сравнения двух объектов FixedStringArray.
        /// </summary>
        /// <param name="arr1">Первый объект для сравнения.</param>
        /// <param name="arr2">Второй объект для сравнения.</param>
        /// <returns>Возвращает true, если объекты равны, иначе false.</returns>
        public static bool operator ==(FixedStringArray arr1, FixedStringArray arr2)
        {
            if (arr1.array.GetLength(0) != arr2.array.GetLength(0) || arr1.array.GetLength(1) != arr2.array.GetLength(1))
            {
                return false;
            }

            for (int i = 0; i < arr1.array.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.array.GetLength(1); j++)
                {
                    if (arr1.array[i, j] != arr2.array[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Оператор неравенства для сравнения двух объектов FixedStringArray.
        /// </summary>
        /// <param name="arr1">Первый объект для сравнения.</param>
        /// <param name="arr2">Второй объект для сравнения.</param>
        /// <returns>Возвращает true, если объекты не равны, иначе false.</returns>
        public static bool operator !=(FixedStringArray arr1, FixedStringArray arr2)
        {
            return !(arr1 == arr2);
        }
    }

    /// <summary>
    /// Класс Program содержит точку входа в приложение.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Точка входа в приложение.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            FixedStringArray array1 = new FixedStringArray(2, 3);
            array1[0, 0] = "1";
            array1[0, 1] = "2";
            array1[0, 2] = "3";
            array1[1, 0] = "4";
            array1[1, 1] = "5";
            array1[1, 2] = "6";

            FixedStringArray array2 = new FixedStringArray(2, 3);
            array2[0, 0] = "1";
            array2[0, 1] = "2";
            array2[0, 2] = "3";
            array2[1, 0] = "4";
            array2[1, 1] = "5";
            array2[1, 2] = "6";

            Console.WriteLine("Оба массива равны: " + (array1 == array2));
        }
    }
}
