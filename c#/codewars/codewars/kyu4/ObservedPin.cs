namespace codewars.kyu4;

// Alright, detective, one of our colleagues successfully observed our target person, Robby the robber.
// We followed him to a secret warehouse, where we assume to find all the stolen stuff. The door to this
// warehouse is secured by an electronic combination lock. Unfortunately our spy isn't sure about the
// PIN he saw, when Robby entered it.
// The keypad has the following layout:
//     ┌───┬───┬───┐
//     │ 1 │ 2 │ 3 │
//     ├───┼───┼───┤
//     │ 4 │ 5 │ 6 │
//     ├───┼───┼───┤
//     │ 7 │ 8 │ 9 │
//     └───┼───┼───┘
//         │ 0 │
//         └───┘
// He noted the PIN 1357, but he also said, it is possible that each of the digits he saw could actually be another
// adjacent digit (horizontally or vertically, but not diagonally). E.g. instead of the 1 it could also be the 2 or 4.
// And instead of the 5 it could also be the 2, 4, 6 or 8.
//
// He also mentioned, he knows this kind of locks. You can enter an unlimited amount of wrong PINs, they never
// finally lock the system or sound the alarm. That's why we can try out all possible (*) variations.
// * possible in sense of: the observed PIN itself and all variations considering the adjacent digits
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