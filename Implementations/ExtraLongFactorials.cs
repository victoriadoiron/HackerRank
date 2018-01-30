static class ExtraLongFactorial
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

        System.Console.WriteLine(product);
    }
}