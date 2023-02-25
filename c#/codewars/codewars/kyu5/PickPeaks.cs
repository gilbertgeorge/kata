using System;
using System.Collections.Generic;

namespace codewars.kyu5;

public static class PickPeaks
{
    public static Dictionary<string, List<int>> GetPeaks(int[] arr)
    {
        var result = new Dictionary<string, List<int>>() {{"pos", new List<int>()}, {"peaks", new List<int>()}};
        
        if (arr.Length < 3)
            return result;
        
        for (int pos = 1; pos < arr.Length - 1; pos++)
        {
            if (arr[pos] > arr[pos - 1] && arr[pos] > arr[pos + 1])
            {
                result["pos"].Add(pos);
                result["peaks"].Add(arr[pos]);
            }
            else if (arr[pos] > arr[pos - 1] && arr[pos] == arr[pos + 1])
            {
                int plateauPos = pos + 1;
                while (plateauPos < arr.Length - 1 && arr[plateauPos] == arr[plateauPos + 1])
                    plateauPos++;
                if (arr.Length - 1 >= plateauPos+1 && arr[plateauPos+1] < arr[pos])
                {
                    result["pos"].Add(pos);
                    result["peaks"].Add(arr[pos]);
                }
                pos = plateauPos;
            }
        }
        
        return result;
    }
}