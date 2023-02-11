using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace codewars.kyu4;

public class TopWords
{
    public static List<string> Top3(string s)
    {
        Regex rgx = new Regex("[^a-z']");
        var words = s.ToLower().Split(new char[] {' ',',', ';', '/', ':', '?', '.', '_','-','!' })
            .Select(x => rgx.Replace(x, ""))
            .Where(x=> x.Length > 0 && x.Any(char.IsLetter)).ToList();

        var top3 = words.GroupBy(x => x)
            .OrderByDescending(x => x.Count())
            .Take(3)
            .Select(x => x.Key)
            .ToList();
        
        return top3;
    }
}