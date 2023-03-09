namespace codewars.kyu4;

//Interesting numbers are 3-or-more digit numbers that meet one or more of the following criteria:
// Any digit followed by all zeros: 100, 90000
// Every digit is the same number: 1111
// The digits are sequential, incrementing†: 1234
// The digits are sequential, decrementing‡: 4321
// The digits are a palindrome: 1221 or 73837
// The digits match one of the values in the awesomePhrases array
// † For incrementing sequences, 0 should come after 9, and not before 1, as in 7890.
// ‡ For decrementing sequences, 0 should come after 1, and not before 9, as in 3210.
public static class CarMileage
{
    public static int IsInteresting(int number, List<int> awesomePhrases)
    {
        if (IsInterestingNumber(number, awesomePhrases)) return 2;
        if (IsInterestingNumber(number + 1, awesomePhrases) || IsInterestingNumber(number + 2, awesomePhrases)) return 1;
        return 0;
    }
    
    private static bool IsInterestingNumber(int number, List<int> awesomePhrases)
    {
        if(number.ToString().Length > 2 && number.ToString().Substring(1).All(c => c == '0')) return true;
        if (number.ToString().Length > 2 && number.ToString().All(c => c == number.ToString()[0])) return true;
        if (IsIncrementing(number)) return true;
        if (IsDecrementing(number)) return true;
        if (IsPalindrome(number)) return true;
        if (awesomePhrases.Contains(number)) return true;
        return false;
    }
    
    private static bool IsPalindrome(int number)
    {
        var numberString = number.ToString();
        if (numberString.Length < 3) return false;
        for (int i = 0; i < numberString.Length / 2; i++)
        {
            if (numberString[i] != numberString[numberString.Length - 1 - i]) return false;
        }
        return true;
    }

    private static bool IsIncrementing(int number)
    {
        string text = number.ToString();
        if (text.Length < 3) return false;
        char? previous = null;
        foreach(char c in text)
        {
            if(previous == '9' && c == '0')
            {
                previous = c;
                continue;
            }
            if (previous !=null && int.Parse(c.ToString()) != int.Parse(previous.ToString())+1)
                return false;
            previous = c;
        }
        return true;      
    }
    
    private static bool IsDecrementing(int number)
    {
        string text = number.ToString();
        if (text.Length < 3) return false;
        char? previous = null;
        foreach (char c in text)
        {
            if (previous == '1' && c == '0')
            {
                previous = c;
                continue;
            }
            if (previous !=null && int.Parse(c.ToString()) != int.Parse(previous.ToString())-1)
                return false;
            previous = c;
        }
        return true;
    }
}