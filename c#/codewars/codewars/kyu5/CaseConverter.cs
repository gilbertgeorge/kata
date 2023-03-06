namespace codewars.kyu5;

public static class CaseConverter
{
    public static string PascalToSnake(int str)
    {
        return str.ToString();
    }

    public static string PascalToSnake(string str) 
    {
        var result = "";
        foreach (var c in str)
        {
            if (char.IsUpper(c))
            {
                result += "_" + char.ToLower(c);
            }
            else
            {
                result += c;
            }
        }
        return result.TrimStart('_');
    }
}