using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu7;

namespace codewars_tests.kyu7;

[TestClass]
public class ExesOhsTests
{
    [TestMethod]
    public void ExesOhsBase()
    {
        //arrange
        
        //act
        var actualFirst = ExesOhs.XO("ooxx");
        var actualSecond = ExesOhs.XO("xooxx");
        var actualThird = ExesOhs.XO("ooxXm");
        var actualFourth = ExesOhs.XO("zpzpzpp");
        var actualFifth = ExesOhs.XO("zzoo");

        //assert
        Assert.AreEqual(true, actualFirst);
        Assert.AreEqual(false, actualSecond);
        Assert.AreEqual(true, actualThird);
        Assert.AreEqual(true, actualFourth);
        Assert.AreEqual(false, actualFifth);
    }
    
    [TestMethod]
    public void ExesOhsEmpty()
    {
        //arrange
        var expected = true;
        
        //act
        var actual = ExesOhs.XO("");

        //assert
        Assert.AreEqual(expected, actual);
    }
}