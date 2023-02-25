namespace codewars.kyu5;

public static class FirstNonRepeating
{
    public static string FirstNonRepeatingLetter(string s)
    {
        var result = "";
        var lower = s.ToLower().ToCharArray();
        var firstUnique = lower.GroupBy(x => x).FirstOrDefault(x => x.Count() == 1);
        if (firstUnique != null)
        {
            result = s[Array.IndexOf(lower, firstUnique.Key)].ToString();    
        }

        return result;
    }
}