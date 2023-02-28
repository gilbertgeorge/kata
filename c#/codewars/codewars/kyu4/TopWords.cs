using System.Text.RegularExpressions;

namespace codewars.kyu4;

// Write a function that, given a string of text (possibly with punctuation and line-breaks), returns an array of the
// top-3 most occurring words, in descending order of the number of occurrences.
//
// Assumptions:
// A word is a string of letters (A to Z) optionally containing one or more apostrophes (') in ASCII.
//     Apostrophes can appear at the start, middle or end of a word ('abc, abc', 'abc', ab'c are all valid)
// Any other characters (e.g. #, \, / , . ...) are not part of a word and should be treated as whitespace.
//     Matches should be case-insensitive, and the words in the result should be lowercased.
// Ties may be broken arbitrarily.
// If a text contains fewer than three unique words, then either the top-2 or top-1 words should be returned,
// or an empty array if a text contains no words.
public static class TopWords
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