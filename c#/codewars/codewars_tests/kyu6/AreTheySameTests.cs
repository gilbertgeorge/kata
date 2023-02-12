using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu6;

namespace codewars_tests.kyu6;

[TestClass]
public class AreTheySameTests
{
    [TestMethod]
    public void CompBase()
    {
        int[]? a = new int[] {121, 144, 19, 161, 19, 144, 19, 11};
        int[]? b = new int[] {11*11, 121*121, 144*144, 19*19, 161*161, 19*19, 144*144, 19*19};
        bool r = AreTheySame.comp(a, b); // True
        Assert.AreEqual(true, r);
        
        bool n = AreTheySame.comp(new int[] {}, new int[] {});
        Assert.AreEqual(true, n);
        
        //initialize nullable integer array
        bool z = AreTheySame.comp(null, null);
        Assert.AreEqual(false, z);
    }
}