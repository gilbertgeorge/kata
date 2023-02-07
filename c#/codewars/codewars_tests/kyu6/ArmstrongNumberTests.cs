using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu6;

namespace codewars_tests.kyu6;

[TestClass]
public class ArmstrongNumberTests
{
    [TestMethod]
    public void ArmstrongNumberBase()
    {
        //arrange
        var expectedFirst = true;
        var expectedSecond = true;
        var expectedThird = true;
        var expectedFourth = false;
        
        //act
        var actualFirst = ArmstrongNumber.Narcissistic(1);
        var actualSecond = ArmstrongNumber.Narcissistic(153);
        var actualThird = ArmstrongNumber.Narcissistic(371);
        var actualFourth = ArmstrongNumber.Narcissistic(1652);
        
        //assert
        Assert.AreEqual(expectedFirst, actualFirst);
        Assert.AreEqual(expectedSecond, actualSecond);
        Assert.AreEqual(expectedThird, actualThird);
        Assert.AreEqual(expectedFourth, actualFourth);
    }
}