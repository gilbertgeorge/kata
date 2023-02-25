namespace codewars.kyu5;

public static class LandPerimeter
{
    public static string Calculate(string[] map)
    {
        var result = 0;
        for (var i = 0; i < map.Length; i++)
        {
            for (var j = 0; j < map[i].Length; j++)
            {
                if (map[i][j] == 'X')
                {
                    result += 4;
                    if (i > 0 && map[i - 1][j] == 'X')
                    {
                        result -= 2;
                    }
                    if (j > 0 && map[i][j - 1] == 'X')
                    {
                        result -= 2;
                    }
                }
            }
        }
        return $"Total land perimeter: {result}";
    }
}