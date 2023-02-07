using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu7;

namespace codewars_tests.kyu7;

[TestClass]
public class IsogramTests
{
    [TestMethod]
    public void IsIsogramBase()
    {
        //arrange        
        //act
        var actualOne = Isogram.IsIsogram("Dermatoglyphics");
        var actualTwo = Isogram.IsIsogram("isogram");
        var actualThree = Isogram.IsIsogram("moose");
        var actualFour = Isogram.IsIsogram("isIsogram");
        var actualFive = Isogram.IsIsogram("aba");
        var actualSix = Isogram.IsIsogram("moOse");
        var actualSeven = Isogram.IsIsogram("thumbscrewjapingly");
        var actualEight = Isogram.IsIsogram("");
        
        

        //assert
        Assert.AreEqual(true, actualOne);
        Assert.AreEqual(true, actualTwo);
        Assert.AreEqual(false, actualThree);
        Assert.AreEqual(false, actualFour);
        Assert.AreEqual(false, actualFive);
        Assert.AreEqual(false, actualSix);
        Assert.AreEqual(true, actualSeven);
        Assert.AreEqual(true, actualEight);
    }
}