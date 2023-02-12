namespace codewars.kyu6;

public class AreTheySame
{
    public static bool comp(int[]? a, int[]? b)
    {
        if((a == null || b == null) || a.Length != b.Length)
        {
            return false;
        }
        if (a.Length > 0 && b.Length > 0)
        {
            var orderedA = a.OrderBy(x => x).ToList();
            var orderedB = b.OrderBy(x => x).ToList();
            for (int i = 0; i < a.Length; i++)
            {
                if (orderedA.ElementAt(i) * orderedA.ElementAt(i) != orderedB.ElementAt(i))
                {
                    return false;
                }
            }
        }
        return true;
    }
}