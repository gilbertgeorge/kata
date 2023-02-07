using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu5;

namespace codewars_tests.kyu5;

[TestClass]
public class Rot13Tests
{
    [TestMethod]
    public void Rot13Base()
    {
        //arrange
        var expectedFirst = "grfg";
        var expectedSecond = "Grfg";
        var expectedThird = "NNNN";
        var expectedFourth = "aaaa";
        var expectedFifth = "Guvf! vf n grfg.";
        
        //act
        var actualFirst = Rot13.Encode("test");
        var actualSecond = Rot13.Encode("Test");
        var actualThird = Rot13.Encode("AAAA");
        var actualFourth = Rot13.Encode("nnnn");
        var actualFifth = Rot13.Encode("This! is a test.");
        
        //assert
        Assert.AreEqual(expectedFirst, actualFirst);
        Assert.AreEqual(expectedSecond, actualSecond);
        Assert.AreEqual(expectedThird, actualThird);
        Assert.AreEqual(expectedFourth, actualFourth);
        Assert.AreEqual(expectedFifth, actualFifth);
    }
}