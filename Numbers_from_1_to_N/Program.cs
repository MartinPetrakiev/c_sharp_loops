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
                result += ("" + i + " ").ToString();
            }

            Console.WriteLine(result);
        }
    }
}

/*
Description
Write a program that enters from the console a positive integer n and prints all the numbers from 1 to N inclusive, on a single line, separated by a whitespace.

Input
The input will consist of a single line - the number N

Output
The output should consist of a single line - the numbers from 1 to N, separated by a whitespace

Constraints
N will be a valid positive 32-bit integers
Time limit: 0.1s
Memory limit: 16MB
*/