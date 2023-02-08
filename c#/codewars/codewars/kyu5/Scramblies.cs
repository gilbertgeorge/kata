namespace codewars.kyu5;

public class Scramblies
{
    public static bool Scramble(string str1, string str2)
    {
        var set = new HashSet<char>(str2.ToLower());
        foreach (var c in set)
        {
            var count1 = str1.ToLower().Count(x => x == c);
            var count2 = str2.ToLower().Count(x => x == c);
            if (count2 > count1)
            {
                return false;
            }
        }

        return true;
    }
}