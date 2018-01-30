using System;

class ExtraLongFactorial
{
    public static void ExtraLongFactorials(System.Numerics.BigInteger n)
    {
        var product = n;

        checked
        {
            for (var i = n; i > 1; i--)
            {
                product *= (i - 1);
            }
        }

        Console.WriteLine(product);
    }

    void Main(string[] args)
    {
        var n = Convert.ToInt64(Console.ReadLine());
        ExtraLongFactorials(n);
    }
}