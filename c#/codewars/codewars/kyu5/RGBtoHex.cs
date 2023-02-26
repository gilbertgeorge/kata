namespace codewars.kyu5;

public static class RGBtoHex
{
    public static string Rgb(int r, int g, int b) 
    {
        return $"{ToHex(r)}{ToHex(g)}{ToHex(b)}";
    }
    
    private static string ToHex(int value)
    {
        return value switch
        {
            < 0 => "00",
            > 255 => "FF",
            _ => value.ToString("X2")
        };
    }
}