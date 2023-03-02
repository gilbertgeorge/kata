using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu5;

namespace codewars_tests.kyu5;

[TestClass]
public class DenominatorsTests
{
    [TestMethod]
    public void Test1() {
  
        long[,] lst = new long[,] { {1, 2}, {1, 3}, {1, 4} };
        Assert.AreEqual("(6,12)(4,12)(3,12)", CommonDenominators.convertFrac(lst));
  
    }
}