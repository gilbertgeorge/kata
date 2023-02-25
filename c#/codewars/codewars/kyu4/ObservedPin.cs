namespace codewars.kyu4;

public static class ObservedPin
{
    private static readonly Dictionary<char, char[]> AdjacentCodes = new Dictionary<char, char[]>
    {
        {'1', new[] {'1', '2', '4'}},
        {'2', new[] {'1', '2', '3', '5'}},
        {'3', new[] {'2', '3', '6'}},
        {'4', new[] {'1', '4', '5', '7'}},
        {'5', new[] {'2', '4', '5', '6', '8'}},
        {'6', new[] {'3', '5', '6', '9'}},
        {'7', new[] {'4', '7', '8'}},
        {'8', new[] {'5', '7', '8', '9', '0'}},
        {'9', new[] {'6', '8', '9'}},
        {'0', new[] {'0', '8'}}
    };
    
    private static void GetPINs(string observed, char[] pin, int index, List<string> pins)
    {
        if (index == observed.Length)
        {
            pins.Add(new string(pin));
            return;
        }
        foreach (var digit in AdjacentCodes[observed[index]])
        {
            pin[index] = digit;
            GetPINs(observed, pin, index + 1, pins);
        }
    }
    
    public static List<string> GetPINs(string observed)
    {
        var pins = new List<string>();
        var pin = new char[observed.Length];
        GetPINs(observed, pin, 0, pins);
        return pins;
    }
}