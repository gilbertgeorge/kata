namespace codewars.kyu7;

public static class Mumbling
{
    public static String Accum(string s) 
    {
        return string.Join("-", s.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));
    }
}