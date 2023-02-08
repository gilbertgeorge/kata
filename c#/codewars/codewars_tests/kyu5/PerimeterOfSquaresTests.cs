using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu5;

namespace codewars_tests.kyu5;

[TestClass]
public class PerimeterOfSquaresTests
{
    [TestMethod]
    public void PerimeterBase()
    {
        //arrange
        //act
        //assert
        Assert.AreEqual(new BigInteger(80), PerimeterOfSquares.perimeter(new BigInteger(5)));
        Assert.AreEqual(new BigInteger(216), PerimeterOfSquares.perimeter(new BigInteger(7)));
        Assert.AreEqual(new BigInteger(14098308), PerimeterOfSquares.perimeter(new BigInteger(30)));
    }
    
}