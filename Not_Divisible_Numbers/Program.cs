using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            string result = "";

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    continue;
                }
                else
                {
                    result += ("" + i + " ").ToString();
                }
            }

            Console.WriteLine(result);
        }
    }
}

/*
Description
Write a program that reads from the console a positive integer N and prints all the numbers from 1 to N not divisible by 3 or 7, on a single line, separated by a space.

Input
Will always consists of one valid integer number - the number N.

Output
Should always consists of the numbers from 1 to N, which are not divisible by 3 or 7, separated by a whitespace.

Constraints
1 < N < 1500
Time limit: 0.1s
Memory limit: 16MB
*/