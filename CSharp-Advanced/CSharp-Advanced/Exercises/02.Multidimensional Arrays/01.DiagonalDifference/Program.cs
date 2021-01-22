using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int rows = size;
            int cols = size;

            int diagRow = 0;
            int diagCol = size - 1;

            int primaryDiagSum = 0;
            int secondaryDiagSum = 0;

            var matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                var rowInput = Console.ReadLine().Split(" ");
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(rowInput[col]);

                    if (row == col)
                    {
                        primaryDiagSum += matrix[row, col];
                    }
                    if (row == diagRow && col == diagCol)
                    {
                        diagRow++;
                        diagCol--;
                        secondaryDiagSum += matrix[row, col];
                    }
                }
            }
            int result = Math.Abs(primaryDiagSum - secondaryDiagSum);
            Console.WriteLine(result);
        }
    }
}