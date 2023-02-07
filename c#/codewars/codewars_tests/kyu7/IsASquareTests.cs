using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu7;

namespace codewars_tests.kyu7;

[TestClass]
public class IsASquareTests
{
    [TestMethod]
    public void SquareZero()
    {
        //arrange
        var expected = true;
        
        //act
        var actual = IsASquare.IsSquare(0);

        //assert
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void SquareNegative()
    {
        //arrange
        var expected = false;
        
        //act
        var actual = IsASquare.IsSquare(-1);

        //assert
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void SquareBaseCases()
    {
        //arrange
        var expected3 = false;
        var expected4 = true;
        var expected25 = true;
        var expected26 = false;
        
        //act
        var actual3 = IsASquare.IsSquare(3);
        var actual4 = IsASquare.IsSquare(4);
        var actual25 = IsASquare.IsSquare(25);
        var actual26 = IsASquare.IsSquare(26);

        //assert
        Assert.AreEqual(expected3, actual3);
        Assert.AreEqual(expected4, actual4);
        Assert.AreEqual(expected25, actual25);
        Assert.AreEqual(expected26, actual26);
    }
}