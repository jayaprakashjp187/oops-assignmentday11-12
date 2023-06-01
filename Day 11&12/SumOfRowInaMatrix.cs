using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_11_12
{
    internal class SumOfRowInaMatrix
    {
        public static void FindingSumOfRow()
        {
            int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[] rowSums = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                int sum = 0;
                for (int j = 0; j < cols; j++)
                {
                    sum += matrix[i, j];
                }
                rowSums[i] = sum;
            }

            Console.WriteLine("Sum of each row:");
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Row {i + 1}: {rowSums[i]}");
            }
        }
    }
}
