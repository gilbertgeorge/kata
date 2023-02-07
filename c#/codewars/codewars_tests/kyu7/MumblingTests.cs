using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu7;

namespace codewars_tests.kyu7;

[TestClass]
public class MumblingTests
{
    [TestMethod]
    public void MumblingBase()
    {
        //arrange
        var expectedFirst = "A-Bb-Ccc-Dddd";
        var expectedSecond = "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy";
        var expectedThird = "C-Ww-Aaa-Tttt";
        var expectedFourth = "Z-Pp-Ggg-Llll-Nnnnn-Rrrrrr-Xxxxxxx-Qqqqqqqq-Eeeeeeeee-Nnnnnnnnnn-Uuuuuuuuuuu";
        var expectedFifth = "N-Yy-Fff-Ffff-Sssss-Gggggg-Eeeeeee-Yyyyyyyy-Yyyyyyyyy-Llllllllll-Bbbbbbbbbbb";
        var expectedSixth = "M-Jj-Ttt-Kkkk-Uuuuu-Bbbbbb-Ooooooo-Vvvvvvvv-Qqqqqqqqq-Rrrrrrrrrr-Uuuuuuuuuuu";
        var expectedSeventh = "E-Vv-Iii-Dddd-Jjjjj-Uuuuuu-Nnnnnnn-Oooooooo-Kkkkkkkkk-Mmmmmmmmmm-Mmmmmmmmmmm";
        var expectedEighth = "H-Bb-Iii-Dddd-Eeeee-Vvvvvv-Bbbbbbb-Xxxxxxxx-Nnnnnnnnn-Cccccccccc-Ccccccccccc";
        
        //act
        var actualFirst = Mumbling.Accum("abcd");
        var actualSecond = Mumbling.Accum("RqaEzty");
        var actualThird = Mumbling.Accum("cwAt");
        var actualFourth = Mumbling.Accum("ZpglnRxqenU");
        var actualFifth = Mumbling.Accum("NyffsGeyylB");
        var actualSixth = Mumbling.Accum("MjtkuBovqrU");
        var actualSeventh = Mumbling.Accum("EvidjUnokmM");
        var actualEighth = Mumbling.Accum("HbideVbxncC");
        
        //assert
        Assert.AreEqual(expectedFirst, actualFirst);
        Assert.AreEqual(expectedSecond, actualSecond);
        Assert.AreEqual(expectedThird, actualThird);
        Assert.AreEqual(expectedFourth, actualFourth);
        Assert.AreEqual(expectedFifth, actualFifth);
        Assert.AreEqual(expectedSixth, actualSixth);
        Assert.AreEqual(expectedSeventh, actualSeventh);
        Assert.AreEqual(expectedEighth, actualEighth);
    }
}