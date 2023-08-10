using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            float x = float.Parse(Console.ReadLine()!);

            double sum = 1;

            for (int i = 1; i <= n; i++)
            {
                int fact = 1;
                for (int k = 1; k <= i; k++)
                {
                    fact *= k;
                }

                sum += (fact / Math.Pow(x, i));
            }

            Console.WriteLine("{0:0.00000}", sum);
        }
    }
}

/*
Description
Write a program that, for a given two numbers N and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + N!/xN.
Use only one loop. Print the result with 5 digits after the decimal point.

Input
On the first line you will receive one number - N.
On the second line you will receive another number - x.

Output
Output only one number - the sum of the sequence for the given N and x.

Constraints
N will always be a valid integer between 2 and 10, inclusive.
X will always be a valid floating-point number between 0.5 and 100
Time limit: 0.1s
Memory limit: 16MB
*/
