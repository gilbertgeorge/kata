namespace codewars.kyu6;

public static class ArmstrongNumber
{
    // Your code must return true or false (not 'true' and 'false') depending upon whether the given number
    // is a Narcissistic number in base 10.
    public static bool Narcissistic(int value)
    {
        var digits = value.ToString().ToCharArray();
        var sum = 0;
        foreach (var digit in digits)
        {
            sum += (int)System.Math.Pow(int.Parse(digit.ToString()), digits.Length);
        }
        return sum == value;
    }
}