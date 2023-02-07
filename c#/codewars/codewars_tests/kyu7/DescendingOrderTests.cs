using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu7;

namespace codewars_tests.kyu7;

[TestClass]
public class DescendingOrderTests
{
    [TestMethod]
    public void DescendingOrderZero()
    {
        //arrange
        var expected = 0;
        
        //act
        var actual = DescendingOrderGen.DescendingOrder(0);

        //assert
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void DescendingOrderBase()
    {
        //arrange
        var expectedFirst = 54421;
        var expectedSecond = 654321;
        var expectedThird = 987654321;

        
        //act
        var actualFirst = DescendingOrderGen.DescendingOrder(42145);
        var actualSecond = DescendingOrderGen.DescendingOrder(145263);
        var actualThird = DescendingOrderGen.DescendingOrder(123456789);

        //assert
        Assert.AreEqual(expectedFirst, actualFirst);
        Assert.AreEqual(expectedSecond, actualSecond);
        Assert.AreEqual(expectedThird, actualThird);
    }
}