using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu5;

namespace codewars_tests.kyu5;

[TestClass]
public class WeightSortTests
{
    [TestMethod]
    public void WeightTest() {
        Assert.AreEqual("2000 103 123 4444 99", WeightSort.OrderWeight("103 123 4444 99 2000"));
        Assert.AreEqual("11 11 2000 10003 22 123 1234000 44444444 9999", WeightSort.OrderWeight("2000 10003 1234000 44444444 9999 11 11 22 123"));
    }
}