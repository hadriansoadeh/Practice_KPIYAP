namespace Task2
{
    using System;

    class FixedLengthStringArray
    {
        private string[] array;
        private int lowerBound;
        private int upperBound;

        public FixedLengthStringArray(int lowerBound, int upperBound)
        {
            this.lowerBound = lowerBound;
            this.upperBound = upperBound;
            array = new string[upperBound - lowerBound + 1];
        }

        public string this[int index]
        {
            get
            {
                if (index < lowerBound || index > upperBound)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }
                return array[index - lowerBound];
            }
            set
            {
                if (index < lowerBound || index > upperBound)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }
                array[index - lowerBound] = value;
            }
        }

        public FixedLengthStringArray Concatenate(FixedLengthStringArray otherArray)
        {
            FixedLengthStringArray resultArray = new FixedLengthStringArray(lowerBound, upperBound + otherArray.upperBound - otherArray.lowerBound + 1);
            for (int i = lowerBound; i <= upperBound; i++)
            {
                resultArray[i] = this[i];
            }
            for (int i = otherArray.lowerBound; i <= otherArray.upperBound; i++)
            {
                resultArray[i + upperBound - lowerBound + 1] = otherArray[i];
            }
            return resultArray;
        }

        public void PrintElement(int index)
        {
            Console.WriteLine("Element at index " + index + ": " + this[index]);
        }

        public void PrintArray()
        {
            for (int i = lowerBound; i <= upperBound; i++)
            {
                Console.WriteLine("Element at index " + i + ": " + this[i]);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            FixedLengthStringArray array1 = new FixedLengthStringArray(1, 3);
            array1[1] = "Hello";
            array1[2] = "World";
            array1[3] = "!";

            FixedLengthStringArray array2 = new FixedLengthStringArray(1, 2);
            array2[1] = "Welcome";
            array2[2] = "to";

            FixedLengthStringArray concatenatedArray = array1.Concatenate(array2);

            concatenatedArray.PrintArray();
            concatenatedArray.PrintElement(2);
        }
    }

}
