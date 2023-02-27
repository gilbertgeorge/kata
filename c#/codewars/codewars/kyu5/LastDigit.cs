using System.Numerics;

namespace codewars.kyu5;

public static class LastDigit
{
    private static readonly Dictionary<int, int[]> DigitCycles = new Dictionary<int, int[]>
    {
        {1, new[] {1}},
        {2, new[] {6, 2, 4, 8}},
        {3, new[] {1, 3, 9, 7}},
        {4, new[] {6, 4}},
        {5, new[] {5}},
        {6, new[] {6}},
        {7, new[] {1, 7, 9, 3}},
        {8, new[] {6, 8, 4, 2}},
        {9, new[] {1, 9}},
        {0, new[] {0}}
    };
    
    public static int GetLastDigit(BigInteger n1, BigInteger n2)
    {
        if (n2 == 0)
            return 1;
        var lastDigit = (int) (n1 % 10);
        var n2Mod = (int) (n2 % DigitCycles[lastDigit].Length);
        return DigitCycles[lastDigit][n2Mod];
    }
}