using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu5;

namespace codewars_tests.kyu5;

[TestClass]
public class LandPerimeterTests
{
    [TestMethod]
    public void LandPerimeterBase()
    {
        //arrange
        //act
        //assert
        Assert.AreEqual("Total land perimeter: 24", LandPerimeter.Calculate(new string[] {"XOOXO", "XOOXO", "OOOXO", "XXOXO", "OXOOO"}));
        Assert.AreEqual("Total land perimeter: 18", LandPerimeter.Calculate(new string[] {"XOOO", "XOXO", "XOXO", "OOXX", "OOOO"}));
        Assert.AreEqual("Total land perimeter: 0", LandPerimeter.Calculate(new string[] {""}));
        Assert.AreEqual("Total land perimeter: 0", LandPerimeter.Calculate(new string[] {"O"}));
        Assert.AreEqual("Total land perimeter: 4", LandPerimeter.Calculate(new string[] {"X"}));
        
        Assert.AreEqual("Total land perimeter: 60", LandPerimeter.Calculate(new string[] {"OXOOOX", "OXOXOO", "XXOOOX", "OXXXOO", "OOXOOX", "OXOOOO", "OOXOOX", "OOXOOO", "OXOOOO", "OXOOXX"}));
        Assert.AreEqual("Total land perimeter: 52", LandPerimeter.Calculate(new string[] {"OXOOO", "OOXXX", "OXXOO", "XOOOO", "XOOOO", "XXXOO", "XOXOO", "OOOXO", "OXOOX", "XOOOO", "OOOXO"}));
        Assert.AreEqual("Total land perimeter: 40", LandPerimeter.Calculate(new string[] {"XXXXXOOO", "OOXOOOOO", "OOOOOOXO", "XXXOOOXO", "OXOXXOOX"}));
        Assert.AreEqual("Total land perimeter: 54", LandPerimeter.Calculate(new string[] {"XOOOXOO", "OXOOOOO", "XOXOXOO", "OXOXXOO", "OOOOOXX", "OOOXOXX", "XXXXOXO"}));
        Assert.AreEqual("Total land perimeter: 40", LandPerimeter.Calculate(new string[] {"OOOOXO", "XOXOOX", "XXOXOX", "XOXOOO", "OOOOOO", "OOOXOO", "OOXXOO"}));
    }
}