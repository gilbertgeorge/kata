using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu5;

namespace codewars_tests.kyu5;

[TestClass]
public class PickPeaksTests
{
    // [TestMethod]
    // public void GetPeaksBase()
    // {
    //     var result = PickPeaks.GetPeaks(new int[] {1, 2, 3, 6, 4, 1, 2, 3, 2, 1});
    //     Assert.AreEqual(3, result["pos"].Count);
    //     Assert.AreEqual(3, result["peaks"].Count);
    //     Assert.AreEqual(3, result["pos"][0]);
    //     Assert.AreEqual(6, result["peaks"][0]);
    //     Assert.AreEqual(7, result["pos"][1]);
    //     Assert.AreEqual(3, result["peaks"][1]);
    //     Assert.AreEqual(8, result["pos"][2]);
    //     Assert.AreEqual(2, result["peaks"][2]);
    // }
    
    private static string[] msg =
    {
        "should support finding peaks",
        "should support finding peaks, but should ignore peaks on the edge of the array",
        "should support finding peaks; if the peak is a plateau, it should only return the position of the first element of the plateau",
        "should support finding peaks; if the peak is a plateau, it should only return the position of the first element of the plateau",
        "should support finding peaks, but should ignore peaks on the edge of the array"
    };

    private static int[][] array = 
    {
        new int[]{1,2,3,6,4,1,2,3,2,1},
        new int[]{3,2,3,6,4,1,2,3,2,1,2,3},
        new int[]{3,2,3,6,4,1,2,3,2,1,2,2,2,1},
        new int[]{2,1,3,1,2,2,2,2,1},
        new int[]{2,1,3,1,2,2,2,2}
    };

    private static int[][] posS = 
    {
        new int[]{3,7},
        new int[]{3,7},
        new int[]{3,7,10},
        new int[]{2,4},
        new int[]{2}
    };

    private static int[][] peaksS =
    {
        new int[]{6,3},
        new int[]{6,3},
        new int[]{6,3,2},
        new int[]{3,2},
        new int[]{3}
    };

    [TestMethod]
    public void GetPeaksBase()
    {
        for (int n = 0; n < msg.Length; n++)
        {
            int[] p1 = posS[n], p2 = peaksS[n];
            var expected = new Dictionary<string, List<int>>()
            {
                ["pos"] = p1.ToList(),
                ["peaks"] = p2.ToList()
            };
            var actual = PickPeaks.GetPeaks(array[n]);
            CompareDictionaries(expected, actual);
        }
    }

    private static void PrintDictionary(Dictionary<string, List<int>> dictionary)
    {
        foreach (var (key, value) in dictionary)
        {
            Console.WriteLine(key);
            var values = value.Aggregate("", (current, item) => current + (item + ", "));
            Console.WriteLine(values);
        }
    }
    
    private static void CompareDictionaries(Dictionary<string, List<int>> expected, Dictionary<string, List<int>> actual)
    {
        foreach (var (key, value) in expected)
        {
            CollectionAssert.AreEqual(value, actual[key]);
        }
    }
}