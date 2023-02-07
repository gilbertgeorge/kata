namespace codewars.kyu6;

public class FindUnique
{
    // Write a function called findUnique which returns the only unique number from an array.
    // All numbers in the unsorted array are present twice, except for one number which is only present once.
    // The numbers in the array can be any integer positive or negative, or zero.
    public static int GetUnique(IEnumerable<int> numbers)
    {
        return numbers.GroupBy(x => x).First(x => x.Count() == 1).Key;
    }
}