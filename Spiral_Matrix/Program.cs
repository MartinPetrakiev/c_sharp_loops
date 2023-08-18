using System;

namespace MyProject
{
    class Program
    {
        static int[,] GenerateSpiralMatrix(int n)
        {
            int[,] matrix = new int[n, n];
            int iterator = 1;
            int matrixSize = n * n;
            int colStart = 0, colEnd = n - 1;

            while (iterator <= matrixSize)
            {
                //Add to the right  
                for (int i = colStart; i <= colEnd; i++)
                {
                    matrix[colStart, i] = iterator++;
                }
                //Add downwards 
                for (int j = colStart + 1; j <= colEnd; j++)
                {
                    matrix[j, colEnd] = iterator++;
                }
                //Add to the left
                for (int i = colEnd - 1; i >= colStart; i--)
                {
                    matrix[colEnd, i] = iterator++;
                }
                //Add upwards 
                for (int j = colEnd - 1; j >= colStart + 1; j--)
                {
                    matrix[j, colStart] = iterator++;
                }
                colStart++;
                colEnd--;
            }

            return matrix;
        }

        static void PrintSpiralMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] spiralMatrix = GenerateSpiralMatrix(n);

            PrintSpiralMatrix(spiralMatrix);
        }
    }
}



/*
Description
Write a program that reads from the console a positive integer number N (1 ≤ N ≤ 20)
and prints a matrix holding the numbers from 1 to N*N in the form of square spiral like in
the examples below.

Input
The input will always consist of a single line containing a single number - N.

Output
Output a spiral matrix as described below.

Constraints
N will always be a valid integer number.
1 ≤ N ≤ 20
Time limit: 0.1s
Memory limit: 16MB


input   output
4       1   2   3   4
        12  13  14  5
        11  16  15  6
        10  9   8   7
*/