namespace codewars.kyu7;

public class Isogram
{
    public static bool IsIsogram(string str) 
    {
        return str.ToLower().Distinct().Count() == str.Length;
    }
}