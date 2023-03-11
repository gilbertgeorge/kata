namespace codewars.kyu5;

public static class RemovedNumbers
{
    public static List<long[]> removNb(long n) {
        var sum = n * (n + 1) / 2;
        var result = new List<long[]>();
        for (var a = 1; a <= n; a++)
        {
            long b = (sum - a) / (a + 1);
            if (b <= n && a * b == sum - a - b) {
                result.Add(new long[] {a, b});
            }
        }

        return result;
    }
}