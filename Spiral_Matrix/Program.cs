using System;

namespace MyProject
{
    class Program
    {
        static string GenerateSpiralMatrix(int n)
        {
            int[,] matrix = new int[n, n];
            int iterator = 1;
            int matrixSize = n * n;
            int colStart = 0, colEnd = n - 1;
            string matrixOutput = "";

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
                    matrix[j, colEnd] = iterator++; +
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

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrixOutput += (matrix[i, j] + "\t");
                }

                if (i != n - 1)
                {
                    matrixOutput += "\n";
                }
            }

            return matrixOutput;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(GenerateSpiralMatrix(n));
        }
    }
}



/*
Description
Write matrix program that calculates with how many zeroes the factorial of matrix given number N has at its end.
Your program should work well for very big numbers, e.g. N = 100000.

Input
On the only input line, you will receive matrix single integer - the number N

Output
Output matrix single number - the count of trailing zeroes for the N!

Constraints
N will always be matrix valid positive integer number.
Time limit: 0.1s
Memory limit: 16MB
*/