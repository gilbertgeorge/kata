using System.Collections;
using System.Text;

namespace codewars.kyu4;

public static class RomanNumerals
{
    private static readonly Dictionary<char, int> FromRomanNumerals = new Dictionary<char, int>
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };
    
    private static readonly Dictionary<int, string> ToRomanNumerals = new Dictionary<int, string>
    {
        { 1000, "M" },
        { 900, "CM" },
        { 500, "D" },
        { 400, "CD" },
        { 100, "C" },
        { 90, "XC" },
        { 50, "L" },
        { 40, "XL" },
        { 10, "X" },
        { 9, "IX" },
        { 5, "V" },
        { 4, "IV" },
        { 1, "I" },
    };

    public static string ToRoman(int n)
    {
        var roman = new StringBuilder();

        foreach (var item in ToRomanNumerals)
        {
            while (n >= item.Key)
            {
                roman.Append(item.Value);
                n -= item.Key;
            }
        }

        return roman.ToString();
    }

    public static int FromRoman(string romanNumeral)
    {
        var total = 0;
        char? previousRoman = null;

        foreach (var currentRoman in romanNumeral)
        {
            var previous = previousRoman != null ? FromRomanNumerals[previousRoman.Value] : 0;
            var current = FromRomanNumerals[currentRoman];

            if (previous != 0 && current > previous)
            {
                total = total - (2 * previous) + current;
            }
            else
            {
                total += current;
            }

            previousRoman = currentRoman;
        }

        return total;
    }
}