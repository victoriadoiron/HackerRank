using System;

namespace Solutions.Implementations
{
    class DivisibleSumPairs
    {
        static int divisibleSumPairs(int n, int k, int[] ar)
        {
            var numOfPairs = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                    {
                        numOfPairs++;
                    }
                }
            }
            return numOfPairs;
        }

        void Main(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = divisibleSumPairs(n, k, ar);
            Console.WriteLine(result);
        }

    }
}
