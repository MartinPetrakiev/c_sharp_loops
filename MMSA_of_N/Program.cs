using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            float maximalNum = float.MinValue;
            float minimalNum = float.MaxValue;
            float sumValue = 0;
            float averageValue = 0;

            for (int i = 0; i < n; i++)
            {
                float nextNum = float.Parse(Console.ReadLine()!);

                if (nextNum > maximalNum)
                {
                    maximalNum = nextNum;
                }

                if (nextNum < minimalNum)
                {
                    minimalNum = nextNum;
                }

                sumValue += nextNum;
            }

            averageValue = sumValue / n;

            Console.WriteLine("min={0:F2}", minimalNum);
            Console.WriteLine("max={0:F2}", maximalNum);
            Console.WriteLine("sum={0:F2}", sumValue);
            Console.WriteLine("avg={0:F2}", averageValue);

        }
    }
}

/*
Description
Write a program that reads from the console a sequence of N integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number N (alone in a line) followed by N lines, each holding an integer number.
The output is like in the examples below.


Input
On the first line, you will receive the number N.
On each of the next N lines, you will receive a single floating-point number.

Output
You output must always consist of exactly 4 lines - the minimal element on the first line, the maximal on the second, the sum on the third and the average on the fourth, in the following format:
min=3.00
max=6.00
sum=9.00
avg=4.50


Constraints
1 <= N <= 1000
All numbers will be valid floating-point numbers that will be in the range [-10000, 10000]
Time limit: 0.1s
Memory limit: 16MB
*/