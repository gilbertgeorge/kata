namespace codewars.kyu4;

public static class DoubleLinear
{
    public static int DblLinear (int n)
    {
        var u = new List<int> {1};
        var i = 0;
        var j = 0;
        while (u.Count <= n)
        {
            var y = 2 * u[i] + 1;
            var z = 3 * u[j] + 1;
            if (y <= z)
            {
                if (y != u[^1])
                {
                    u.Add(y);
                }
                i++;
            }
            if (y >= z)
            {
                if (z != u[^1])
                {
                    u.Add(z);
                }
                j++;
            }
        }
        return u[n];
    }
}