using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu5;

namespace codewars_tests.kyu5;

[TestClass]
public class BestTravelTests
{
    [TestMethod]
    public void ChooseBestSumTests()
    {
        List<int> ts = new List<int> {50, 55, 56, 57, 58};
        int? n = BestTravel.ChooseBestSum(163, 3, ts);
        Assert.AreEqual(163, n);

        ts = new List<int> {50};
        n = BestTravel.ChooseBestSum(163, 3, ts);
        Assert.AreEqual(null, n);

        ts = new List<int> {91, 74, 73, 85, 73, 81, 87};
        n = BestTravel.ChooseBestSum(230, 3, ts);
        Assert.AreEqual(228, n);
    }
}