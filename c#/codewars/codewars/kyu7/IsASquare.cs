namespace codewars.kyu7;

public class IsASquare
{
    public static bool IsSquare(int n)
    {
        return n >= 0 && Math.Sqrt(n) % 1 == 0;
    }
}