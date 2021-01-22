using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            var matrix = new char[rows, cols];
            int matricesCount = 0;

            for (int row = 0; row < rows; row++)
            {
                var newMatrix = Console.ReadLine().
                    Split(" ", StringSplitOptions.RemoveEmptyEntries).
                    Select(char.Parse).
                    ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = newMatrix[col];
                }
            }

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    char matrixStart = matrix[row, col];
                    if (matrixStart == matrix[row + 1, col + 0] &&
                        matrixStart == matrix[row + 0, col + 1] &&
                        matrixStart == matrix[row + 1, col + 1])
                    {
                        matricesCount++;
                    }
                }
            }
            Console.WriteLine(matricesCount);
        }
    }
}
