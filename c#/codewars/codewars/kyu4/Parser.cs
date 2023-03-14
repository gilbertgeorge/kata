namespace codewars.kyu4;

public static class Parser
{
    private static readonly Dictionary<string, int> _WordDictionary = new()
    {
        {"zero", 0},
        {"one", 1},
        {"two", 2},
        {"three", 3},
        {"four", 4},
        {"five", 5},
        {"six", 6},
        {"seven", 7},
        {"eight", 8},
        {"nine", 9},
        {"ten", 10},
        {"eleven", 11},
        {"twelve", 12},
        {"thirteen", 13},
        {"fourteen", 14},
        {"fifteen", 15},
        {"sixteen", 16},
        {"seventeen", 17},
        {"eighteen", 18},
        {"nineteen", 19},
        {"twenty", 20},
        {"thirty", 30},
        {"forty", 40},
        {"fifty", 50},
        {"sixty", 60},
        {"seventy", 70},
        {"eighty", 80},
        {"ninety", 90},
        {"hundred", 100},
        {"thousand", 1000},
        {"million", 1000000}
    };

    private static int GetSimpleNumber(string number)
    {
        var numbers = number.Split('-');
        if (numbers.Length == 2) return _WordDictionary[numbers[0]] + _WordDictionary[numbers[1]];
        return _WordDictionary[number];
    }
    
    private static int GetComplexNumber(string[] numbers)
    {
        var result = 0;
        for (var i = 0; i < numbers.Length; i++)
        {
            if (i + 1 < numbers.Length && _WordDictionary.ContainsKey(numbers[i + 1]))
            {
                var next = numbers[i + 1];
                if (next == "hundred" && i + 2 < numbers.Length && numbers[i + 2] == "thousand")
                {
                    result += _WordDictionary[numbers[i]] * _WordDictionary[next] * _WordDictionary[numbers[i + 2]];
                    i += 1;
                }
                else if (next == "hundred")
                {
                    result += _WordDictionary[numbers[i]] * _WordDictionary[next];
                }
                else
                {
                    result += GetSimpleNumber(numbers[i]);
                    result *= _WordDictionary[numbers[i + 1]];
                }
                i += 1;
            }
            else if (numbers[i] == "thousand")
            {
                result *= _WordDictionary["thousand"];
            }
            else
            {
                result += GetSimpleNumber(numbers[i]);
            }
        }
        
        return result;
    }
    
    public static int ParseInt(string s)
    {
        var numbers = s.ToLower().Split(' ').Where(n => n != "and").ToArray();
        if(numbers.Length == 1) return GetSimpleNumber(numbers[0]);
        return GetComplexNumber(numbers);
    }
}