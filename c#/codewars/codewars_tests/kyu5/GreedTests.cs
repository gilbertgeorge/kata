using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu5;

namespace codewars_tests.kyu5;

[TestClass]
public class GreedTests
{
    [TestMethod]
    public void GreedWorthless()
    {
        Assert.AreEqual(0, Greed.Score(new int[] {2, 3, 4, 6, 2}), "Should be 0 :-(");
    }
  
    [TestMethod]
    public void GreedTriplets()
    {
        Assert.AreEqual(1000, Greed.Score(new int[] {1, 1, 1, 3, 3}), "Should be 1000");
        Assert.AreEqual(200, Greed.Score(new int[] {2, 2, 2, 3, 3}), "Should be 200");
        Assert.AreEqual(300, Greed.Score(new int[] {4, 4, 3, 3, 3}), "Should be 300");
        Assert.AreEqual(400, Greed.Score(new int[] {4, 4, 4, 3, 3}), "Should be 400");
        Assert.AreEqual(500, Greed.Score(new int[] {5, 5, 5, 3, 3}), "Should be 500");
        Assert.AreEqual(600, Greed.Score(new int[] {6, 6, 6, 3, 3}), "Should be 600");
    }
  
    [TestMethod]
    public void GreedMixedSets()
    {
        Assert.AreEqual(450, Greed.Score(new int[] {2, 4, 4, 5, 4}), "Should be 450");
        
        Assert.AreEqual(250, Greed.Score(new int[] {5, 1, 3, 4, 1}), "Should be 250");
        Assert.AreEqual(1100, Greed.Score(new int[] {1, 1, 1, 3, 1}), "Should be 1100");
    }
}