namespace codewars.kyu4;

// Complete the solution so that it strips all text that follows any of a set of comment markers passed in.
// Any whitespace at the end of the line should also be stripped out.
//
// Example:
// Given an input string of:
// apples, pears # and bananas
// grapes
//     bananas !apples
//
// The output expected would be:
// apples, pears
//     grapes
// bananas
public static class Comments
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