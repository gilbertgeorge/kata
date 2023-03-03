namespace codewars.kyu5;

// https://en.wikipedia.org/wiki/Josephus_problem
public static class Josephus
{
    public static List<object> JosephusPermutation(List<object> items, int k)
    {
        var result = new List<object>();
        var index = 0;
        
        while (items.Count > 0)
        {
            index = (index + k - 1) % items.Count;
            result.Add(items[index]);
            items.RemoveAt(index);
        }
        
        return result;
    }
    
    public static int JosephusSurvivor(int n, int k)
    {
        var result = 0;
        for (var i = 1; i <= n; i++)
        {
            result = (result + k) % i;
        }
        return result + 1;
    }  
}