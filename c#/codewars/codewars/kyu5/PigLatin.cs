using System.Text.RegularExpressions;

namespace codewars.kyu5;

public static class PigLatin
{
    public static string PigIt(string str)
    {
        Regex reg = new Regex("\\w+");
        return reg.Replace(str, (match) => match.Value.Substring(1) + match.Value[0] + "ay");
    }
}