namespace codewars.kyu5;

public static class GapInPrimes
{
    private static bool IsPrime(long n)
    {
        if (n%2==0) return false;
        for(long i=3; i*i<=n; i+=2)
        {
            if (n%i==0) return false;
        }

        return true;
    }
    
    public static long[] Gap(int g, long m, long n)
    {
        long prime = 0;
        for (; m <= n; m++)
        {
            if (IsPrime(m))
            {
                if (m - prime == g) return new long[] {prime, m};
                prime=m;
            }
        }
        return null;
    } 
}