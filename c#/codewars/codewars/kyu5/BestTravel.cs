namespace codewars.kyu5;

public static class BestTravel
{
    public static int? ChooseBestSum(int t, int k, List<int> ls)
    {
        if (ls.Count < k) return null;
        var best = 0;
        var bestFound = false;
        var combinations = Combinations(ls, k);
        foreach (var combination in combinations)
        {
            var sum = combination.Sum();
            if (sum <= t && sum > best)
            {
                best = sum;
                bestFound = true;
            }
            if (sum == t) break;
        }
        return bestFound ? best : (int?) null;
    }
    
    private static IEnumerable<IEnumerable<T>> GetPowerSet<T>(List<T> list)
    {
        return from m in Enumerable.Range(0, 1 << list.Count)
            select
                from i in Enumerable.Range(0, list.Count)
                where (m & (1 << i)) != 0
                select list[i];
    }
    
    private static IEnumerable<IEnumerable<T>> Combinations<T>(this IEnumerable<T> elements, int k)
    {
        return k == 0 ? 
            new[] { new T[0] } :
            elements.SelectMany((e, i) => 
                elements.Skip(i + 1).Combinations(k - 1).Select(c => 
                    (new[] { e }).Concat(c)));
    }
}