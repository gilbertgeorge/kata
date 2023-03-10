namespace codewars.kyu4;

public static class PyramidSlideDown
{
    public static int LongestSlideDown(int[][] pyramid)
    {
        var memo = new Dictionary<string, int>();
        return LongestSlideDownAt(pyramid, 0, 0, memo);
    }

    private static int LongestSlideDownAt(IReadOnlyList<int[]> pyramid, int x, int y, Dictionary<string, int> memo)
    {
        if (x >= pyramid.Count || y >= pyramid[x].Length) return 0;
        if (x == pyramid.Count - 1) return pyramid[x][y];
        var key = $"{x}:{y}";
        if (memo.ContainsKey(key)) return memo[key];
        var max = int.MinValue;
        for (var i = 0; i < 2; i++)
        {
            var tmp = LongestSlideDownAt(pyramid, x + 1, y + i, memo);
            if (tmp > max) max = tmp;
        }

        memo[key] = pyramid[x][y] + max;
        return memo[key];
    }
}