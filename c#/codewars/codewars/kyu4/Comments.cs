namespace codewars.kyu4;

public class Comments
{
    public static string StripComments(string text, string[] commentSymbols)
    {
        List<string> result = new List<string>();
        var lines = text.Split('\n');
        foreach (var line in lines)
        {
            var lineResult = line;
            if (commentSymbols.Any(marker => lineResult.Contains(marker)))
            {
                var marker = commentSymbols.First(marker => lineResult.Contains(marker));
                var markerIndex = lineResult.IndexOf(marker);
                lineResult = lineResult.Substring(0, markerIndex);
            }

            result.Add(lineResult.TrimEnd());
        }

        return string.Join("\n", result);
    }
}