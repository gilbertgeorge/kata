namespace codewars.kyu5;

public static class DirectionReduction
{
    private static readonly Dictionary<string, string> _opposites = new Dictionary<string, string>
    {
        {"NORTH", "SOUTH"},
        {"SOUTH", "NORTH"},
        {"EAST", "WEST"},
        {"WEST", "EAST"}
    };
    
    public static string[] DirReduction(String[] arr)
    {
        var result = new string[] { };
        foreach (var direction in arr)
        {
            if (result.Length > 0 && result[^1] == _opposites[direction]) result = result[..^1];
            else result = result.Append(direction).ToArray();
        }
        return result;
    }
}