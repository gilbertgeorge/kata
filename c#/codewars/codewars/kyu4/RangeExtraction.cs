namespace codewars.kyu4;

public class RangeExtraction
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