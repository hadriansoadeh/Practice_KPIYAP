namespace Task3
{
    class FixedStringArray
    {
        private string[,] array;

        public FixedStringArray(int rows, int columns)
        {
            array = new string[rows, columns];
        }

        public string this[int i, int j]
        {
            get { return array[i, j]; }
            set { array[i, j] = value; }
        }

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

        public static bool operator !=(FixedStringArray arr1, FixedStringArray arr2)
        {
            return !(arr1 == arr2);
        }
    }
    internal class Program
    {
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
    

