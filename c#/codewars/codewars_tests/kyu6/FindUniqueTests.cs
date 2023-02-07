using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu6;

namespace codewars_tests.kyu6;

[TestClass]
public class FindUniqueTests
{
    [TestMethod]
    public void GetUniqueBase()
    {
        //arrange
        var expectedFirst = 1;
        var expectedSecond = -2;
        var expectedThird = 14;
        
        //act
        var actualFirst = FindUnique.GetUnique(new [] {1, 2, 2, 2});
        var actualSecond = FindUnique.GetUnique(new [] {-2, 2, 2, 2});
        var actualThird = FindUnique.GetUnique(new [] {11, 11, 14, 11, 11});
        
        //assert
        Assert.AreEqual(expectedFirst, actualFirst);
        Assert.AreEqual(expectedSecond, actualSecond);
        Assert.AreEqual(expectedThird, actualThird);
    }
}