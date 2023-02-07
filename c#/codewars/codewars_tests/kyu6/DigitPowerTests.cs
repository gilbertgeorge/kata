using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu6;

namespace codewars_tests.kyu6;

[TestClass]
public class DigitPowerTests
{
    [TestMethod]
    public void DigitPowerBase()
    {
        //arrange
        var expectedFirst = 1;
        var expectedSecond = -1;
        var expectedThird = 51;
        var expectedFourth = 2;
        
        //act
        var actualFirst = DigitPower.digPow(89, 1);
        var actualSecond = DigitPower.digPow(92, 1);
        var actualThird = DigitPower.digPow(46288, 3);
        var actualFourth = DigitPower.digPow(695, 2);
        
        //assert
        Assert.AreEqual(expectedFirst, actualFirst);
        Assert.AreEqual(expectedSecond, actualSecond);
        Assert.AreEqual(expectedThird, actualThird);
        Assert.AreEqual(expectedFourth, actualFourth);
    }
}