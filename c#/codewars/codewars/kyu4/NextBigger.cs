namespace codewars.kyu4;

public static class NextBigger
{
    public static long NextBiggerNumber(long n)
    {
        var digits = n.ToString().ToCharArray();
        
        var i = digits.Length - 1;
        while (i > 0 && digits[i - 1] >= digits[i]) i--;
        if (i <= 0) return -1;
        
        var j = digits.Length - 1;
        while (digits[j] <= digits[i - 1]) j--;
        
        (digits[i - 1], digits[j]) = (digits[j], digits[i - 1]);
        var left = digits.Take(i).ToArray();
        var right = digits.Skip(i).ToArray();
        Array.Sort(right);

        return long.Parse(new string(left.Concat(right).ToArray()));
    }
}