namespace codewars.kyu5;

public class Factorial
{
    public static int TrailingZeros(int n)
    {
        var count = 0;
        var i = 5;
        while (n / i >= 1)
        {
            count += n / i;
            i *= 5;
        }
        return count;
    }    
}