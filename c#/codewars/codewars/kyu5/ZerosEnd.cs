namespace codewars.kyu5;

public class ZerosEnd
{
    public static int[] MoveZeroes(int[] arr)
    {
        int[] result = new int[arr.Length];
        int zeroCount = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0)
            {
                zeroCount++;
            }
            else
            {
                result[i - zeroCount] = arr[i];
            }
        }
        return result;
    }
}