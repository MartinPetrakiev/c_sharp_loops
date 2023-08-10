using System;
using System.Numerics;


namespace MyProject
{
    class Program
    {
        static BigInteger catalanNumber(int n)
        {
            BigInteger catalan = new BigInteger(0);
            BigInteger factN = new BigInteger(1);
            BigInteger fact2N = new BigInteger(1);
            BigInteger factNPlusOne = new BigInteger(1);

            for (int k = 1; k <= 2 * n; k++)
            {
                fact2N *= (BigInteger)k;
            }

            for (int j = 1; j <= n; j++)
            {
                factN *= (BigInteger)j;
            }

            for (int x = 1; x <= n + 1; x++)
            {
                factNPlusOne *= (BigInteger)x;
            }

            catalan = (BigInteger)fact2N / (factNPlusOne * factN);

            return catalan;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            Console.Write(catalanNumber(n));
        }
    }
}

/*
Description
In combinatorics, the Catalan numbers are calculated by the following formula: 
...
Write a program to calculate the Nth Catalan number by given N

Input
On the only line, you will receive the number N

Output
Output a single number - the Nth Catalan number

Constraints
N will always be a valid integer number in the range [0, 100]
Hint: overflow is possible.
Time limit: 0.1s
Memory limit: 16MB
*/
