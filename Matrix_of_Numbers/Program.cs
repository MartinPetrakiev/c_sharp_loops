using System;

namespace MyProject
{
    class Program
    {
        static string generateMatrixOfSizeN(int n)
        {
            string result = "";
            int lastInRow = n;

            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= lastInRow; j++)
                {
                    result += j + " ";
                }

                lastInRow++;

                if (i != n)
                {
                    result += "\n";
                }
            }

            return result.Trim();
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            Console.WriteLine(generateMatrixOfSizeN(n));
        }
    }
}

/*
Description
Write a program that reads from the console a positive integer number N and prints a matrix like in the examples below. Use two nested loops.
Challenge: achieve the same effect without nested loops

Input
The input will always consist of a single line, which contains the number N

Output
See the examples.

Constraints
1 <= N <= 20
N will always be a valid integer number
Time limit: 0.1s
Memory limit: 16MB
*/