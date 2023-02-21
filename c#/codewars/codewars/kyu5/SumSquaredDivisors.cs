namespace codewars.kyu5;

public class SumSquaredDivisors
{
    //Find all integers between m and n (m and n integers with 1 <= m <= n) such that the sum of their squared divisors is itself a square.
    public static string listSquared(long m, long n)
    {
        string result = "[";
        for (long i = m; i <= n; i++)
        {
            long sum = 0;
            for (long j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    sum += j * j;
                }
            }
            if (IsSquare(sum))
            {
                result += "[" + i + ", " + sum + "], ";
            }
        }
        if (result.Length > 1)
        {
            result = result.Substring(0, result.Length - 2);
        }
        result += "]";
        return result;
    }
    
    private static bool IsSquare(long n)
    {
        long root = (long)System.Math.Sqrt(n);
        return root * root == n;
    }
}