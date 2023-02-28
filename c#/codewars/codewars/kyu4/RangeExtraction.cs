namespace codewars.kyu4;

// A format for expressing an ordered list of integers is to use a comma separated list of either
// individual integers
// or a range of integers denoted by the starting integer separated from the end integer in the range by a dash, '-'.
// The range includes all integers in the interval including both endpoints. It is not considered a range unless it
// spans at least 3 numbers. For example "12,13,15-17"
// Complete the solution so that it takes a list of integers in increasing order and returns a correctly formatted string in the range format.
public static class RangeExtraction
{
    public static string Extract(int[] args)
    {
        string result = "";
        int start = args[0];
        int end = args[0];
        for (int i = 1; i < args.Length; i++)
        {
            if (args[i] == end + 1)
            {
                end = args[i];
            }
            else
            {
                if (start == end)
                {
                    result += start + ",";
                }
                else if (end - start == 1)
                {
                    result += start + "," + end + ",";
                }
                else
                {
                    result += start + "-" + end + ",";
                }
                start = args[i];
                end = args[i];
            }
        }
        if (start == end)
        {
            result += start;
        }
        else if (end - start == 1)
        {
            result += start + "," + end;
        }
        else
        {
            result += start + "-" + end;
        }
        return result;
    }
}