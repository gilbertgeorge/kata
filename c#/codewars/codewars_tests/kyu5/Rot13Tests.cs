using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu5;

namespace codewars_tests.kyu5;

[TestClass]
public class Rot13Tests
{
    [TestMethod]
    public void Rot13Encode()
    {
        //arrange
        var expectedFirst = "grfg";
        var expectedSecond = "Grfg";
        var expectedThird = "NNNN";
        var expectedFourth = "aaaa";
        var expectedFifth = "Guvf! vf n grfg.";
        
        var expectedSixth = "Va gur ryringbef, gur rkgebireg ybbxf ng gur BGURE thl'f fubrf.";
        
        //act
        var actualFirst = Rot13.Encode("test");
        var actualSecond = Rot13.Encode("Test");
        var actualThird = Rot13.Encode("AAAA");
        var actualFourth = Rot13.Encode("nnnn");
        var actualFifth = Rot13.Encode("This! is a test.");
        var actualSixth = Rot13.Encode("In the elevators, the extrovert looks at the OTHER guy's shoes.");
        
        //assert
        Assert.AreEqual(expectedFirst, actualFirst);
        Assert.AreEqual(expectedSecond, actualSecond);
        Assert.AreEqual(expectedThird, actualThird);
        Assert.AreEqual(expectedFourth, actualFourth);
        Assert.AreEqual(expectedFifth, actualFifth);
        Assert.AreEqual(expectedSixth, actualSixth);
    }

    [TestMethod]
    public void Rot13Decode()
    {
        //arrange
        var expectedFirst = "ROT13 example.";
        var expectedSecond = "This is my first ROT13 excercise!";
        
        //act
        var actualFirst = Rot13.Decode("EBG13 rknzcyr.");
        var actualSecond = Rot13.Decode("Guvf vf zl svefg EBG13 rkprepvfr!");
        
        //assert
        Assert.AreEqual(expectedFirst, actualFirst);
        Assert.AreEqual(expectedSecond, actualSecond);
    }

}