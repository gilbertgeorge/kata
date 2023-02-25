namespace codewars.kyu7;

public static class Isogram
{
    public static bool IsIsogram(string str) 
    {
        return str.ToLower().Distinct().Count() == str.Length;
    }
}