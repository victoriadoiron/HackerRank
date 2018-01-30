using System;
using System.Linq;

namespace Solutions.Implementations
{
    // <see href="https://www.hackerrank.com/challenges/migratory-birds/problem"/>
    class MigratoryBirds
    {
        static int migratoryBirds(int n, int[] ar)
        {
            var orderedTypes = (from type in ar
                               group type by type into flock
                               let flockCount = flock.Count()
                               orderby flockCount descending
                               select new
                               {
                                   Type = flock.Key,
                                   FlockSize = flockCount
                               }).ToList();

            var biggestFlockSize = orderedTypes.First().FlockSize;
            var matchingBiggestFlock = orderedTypes.Where(p => p.FlockSize == biggestFlockSize);
            return matchingBiggestFlock.Min(p => p.Type);
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = migratoryBirds(n, ar);
            Console.WriteLine(result);
        }
    }
}
