namespace codewars.kyu5;

public class CommonDenominators
{
    public static string convertFrac(long[,] lst) 
    {
        if (lst.Length == 0) return "";
        long lcm = lst[0, 1];
        for (int i = 1; i < lst.Length / 2; i++)
        {
            lcm = (lcm * lst[i, 1]) / GCD(lcm, lst[i, 1]);
        }
        string result = "";
        for (int i = 0; i < lst.Length / 2; i++)
        {
            result += $"({lst[i, 0] * (lcm / lst[i, 1])},{lcm})";
        }
        return result;
    }
    
    private static long GCD(long a, long b)
    {
        if (a == 0) return b;
        if (b == 0) return a;
        if (a == b) return a;
        if (a > b) return GCD(a - b, b);
        return GCD(a, b - a);
    }
}