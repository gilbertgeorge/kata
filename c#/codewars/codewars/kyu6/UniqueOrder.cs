namespace codewars.kyu6;

public static class UniqueOrder
{
    //Implement the function unique_in_order which takes as argument a sequence and returns a list of items without
    //any elements with the same value next to each other and preserving the original order of elements.
    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable) 
    {
        var list = new List<T>();
        var last = default(T);
        foreach (var item in iterable)
        {
            if (item != null && !item.Equals(last))
            {
                list.Add(item);
                last = item;
            }
        }
        return list;
    }
}