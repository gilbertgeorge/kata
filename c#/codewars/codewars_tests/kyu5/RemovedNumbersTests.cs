using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu5;

namespace codewars_tests.kyu5;

[TestClass]
public class RemovedNumbersTests
{
    private bool AreEqual(List<long[]> a, List<long[]> b) {
        if (a.Count != b.Count) return false;
        for (int i = 0; i < a.Count; i++) {
            if (a[i][0] != b[i][0] || a[i][1] != b[i][1]) return false;
        }
        return true;
    }
    
    [TestMethod]
    public void RemovedNumbersTest1() {
        List<long[]> r = new List<long[]> {
            new long[] { 15, 21 },
            new long[] { 21, 15 }
        };
        var actual = RemovedNumbers.removNb(26);
        Assert.IsTrue(AreEqual(r, actual));
    }
    [TestMethod]
    public void RemovedNumbersTest2() {
        CollectionAssert.AreEqual(Array.Empty<long>(), RemovedNumbers.removNb(100));
    }
}