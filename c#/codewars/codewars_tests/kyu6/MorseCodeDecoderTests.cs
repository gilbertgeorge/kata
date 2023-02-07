using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu6;

namespace codewars_tests.kyu6;

[TestClass]
public class MorseCodeDecoderTests
{
    [TestMethod]
    public void DecodeBase()
    {
        var input = ".... . -.--   .--- ..- -.. .";
        var expected = "HEY JUDE";

        var actual = MorseCodeDecoder.Decode(input);

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecodeWithPunctuation()
    {
        var input = "... --- ... -.-.--   - .... .   --.- ..- .. -.-. -.-   -... .-. --- .-- -.   ..-. --- -..-   .--- ..- -- .--. ...   --- ...- . .-.   - .... .   .-.. .- --.. -.--   -.. --- --. .-.-.-";
        var expected = "SOS! THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG.";
        
        var actual = MorseCodeDecoder.Decode(input);
        
        Assert.AreEqual(expected, actual);
    }
}