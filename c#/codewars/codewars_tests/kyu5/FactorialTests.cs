using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu5;

namespace codewars_tests.kyu5;

[TestClass]
public class FactorialTests
{
    [TestMethod]
    public void TrailingZerosBase()
    {
        //arrange
        //act
        //assert
        Assert.AreEqual(1, Factorial.TrailingZeros(5));
        Assert.AreEqual(1, Factorial.TrailingZeros(6));
        Assert.AreEqual(2, Factorial.TrailingZeros(12));
        Assert.AreEqual(6, Factorial.TrailingZeros(25));
        Assert.AreEqual(131, Factorial.TrailingZeros(531));
        Assert.AreEqual(0, Factorial.TrailingZeros(0));
    }
}