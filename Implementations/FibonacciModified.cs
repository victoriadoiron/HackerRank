using System;
using System.Numerics;

namespace Solutions.Implementations
{
    // https://www.hackerrank.com/challenges/fibonacci-modified/problem
    class FibonacciModified
    {
        static BigInteger fibonacciModified(BigInteger t1, BigInteger t2, int n)
        {
            for (int i = 2; i < n; i++)
            {
                var t3 = t1 + BigInteger.Pow(t2, 2);
                t1 = t2;
                t2 = t3;
            }

            return t2;
        }

        static void Main(String[] args)
        {
            string[] tokens_t1 = Console.ReadLine().Split(' ');
            int t1 = Convert.ToInt32(tokens_t1[0]);
            int t2 = Convert.ToInt32(tokens_t1[1]);
            int n = Convert.ToInt32(tokens_t1[2]);
            var result = fibonacciModified(t1, t2, n);
            Console.WriteLine(result);
        }
    }
}
