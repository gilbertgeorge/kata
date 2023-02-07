namespace codewars.kyu6;

public class DigitPower
{
    public static long digPow(int n, int p) 
    {
        var digits = n.ToString();
        var sum = 0;
        foreach (var digit in digits)
        {
            sum += (int)Math.Pow(int.Parse(digit.ToString()), p);
            p++;
        }
        return sum % n == 0 ? sum / n : -1;
    }
}