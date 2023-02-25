using System.Text.RegularExpressions;

namespace codewars.kyu5;

public static class AlphaCheck
{
    public static bool Alphanumeric(string str)
    {
        Regex reg = new Regex("^[a-zA-Z0-9]+$");
        return reg.IsMatch(str);
    }
}