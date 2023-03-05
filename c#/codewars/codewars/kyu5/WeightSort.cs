namespace codewars.kyu5;

public static class WeightSort
{
    public static string OrderWeight(string strng)
    {
        var weightList = strng.Split(' ').ToList();
        weightList.Sort((a, b) =>
        {
            var aSum = a.Sum(c => c - '0');
            var bSum = b.Sum(c => c - '0');
            if (aSum == bSum) return String.Compare(a, b, StringComparison.Ordinal);
            return aSum.CompareTo(bSum);
        });
        return string.Join(' ', weightList);
    }
}