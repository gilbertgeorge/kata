using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu4;

namespace codewars_tests.kyu4;

[TestClass]
public class NextBiggerTests
{
    [TestMethod]
    public void SmallNumbers()
    {
        Assert.AreEqual(21, NextBigger.NextBiggerNumber(12));
        Assert.AreEqual(531, NextBigger.NextBiggerNumber(513));
        Assert.AreEqual(2071, NextBigger.NextBiggerNumber(2017));
        Assert.AreEqual(441, NextBigger.NextBiggerNumber(414));
        Assert.AreEqual(414, NextBigger.NextBiggerNumber(144));
    }
}