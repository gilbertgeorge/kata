using System.Numerics;

namespace codewars.kyu5;

public class PerimeterOfSquares
{
    // private static Dictionary<BigInteger, BigInteger> FibonacciCache(BigInteger position, Dictionary<BigInteger, BigInteger> memoDict)
    // {
    //     if (memoDict.ContainsKey(position))
    //     {
    //         return memoDict;
    //     }
    //
    //     if (position == 1 || position == 2)
    //         memoDict[position] = 1;
    //     else
    //     {
    //         memoDict[position] = FibonacciCache(position - 1, memoDict)[position - 1] + FibonacciCache(position - 2, memoDict)[position - 2];
    //     }
    //
    //     return memoDict;
    // }
    
    private static BigInteger FibonacciSum(BigInteger n)
    {
        BigInteger a = 0;
        BigInteger b = 1;
        BigInteger sum = 0;
        for (BigInteger i = 0; i < n; i++)
        {
            BigInteger temp = a;
            a = b;
            b = temp + b;
            sum += a;
        }
        return sum;
    }
  
    public static BigInteger perimeter(BigInteger n)
    {
        BigInteger sum = FibonacciSum(n + 1);
        return (sum * 4);
    }
}