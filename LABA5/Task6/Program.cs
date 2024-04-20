﻿using System;

namespace SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            int[,] matrix = new int[n, n];

            int num = 1;
            int rowStart = 0, rowEnd = n - 1;
            int colStart = 0, colEnd = n - 1;

            while (num <= n * n)
            {
                for (int i = colStart; i <= colEnd; i++)
                    matrix[rowStart, i] = num++;

                rowStart++;

                for (int i = rowStart; i <= rowEnd; i++)
                    matrix[i, colEnd] = num++;

                colEnd--;

                for (int i = colEnd; i >= colStart; i--)
                    matrix[rowEnd, i] = num++;

                rowEnd--;

                for (int i = rowEnd; i >= rowStart; i--)
                    matrix[i, colStart] = num++;

                colStart++;
            }

            




            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
