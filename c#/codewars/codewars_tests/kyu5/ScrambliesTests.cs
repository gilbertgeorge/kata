using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu5;

namespace codewars_tests.kyu5;

[TestClass]
public class ScrambliesTests
{
    [TestMethod]
    public void ScrambleBase()
    {
        //arrange
        //act
        //assert
        Assert.AreEqual(true, Scramblies.Scramble("rkqodlw", "world"));
        Assert.AreEqual(true, Scramblies.Scramble("cedewaraaossoqqyt", "codewars"));
        Assert.AreEqual(false, Scramblies.Scramble("katas", "steak"));
        Assert.AreEqual(false, Scramblies.Scramble("scriptjavx","javascript"));
        Assert.AreEqual(true, Scramblies.Scramble("scriptingjava","javascript"));
        Assert.AreEqual(true, Scramblies.Scramble("scriptsjava","javascripts"));
        Assert.AreEqual(false, Scramblies.Scramble("javscripts","javascript"));
        Assert.AreEqual(true, Scramblies.Scramble("aabbcamaomsccdd","commas"));
        Assert.AreEqual(true, Scramblies.Scramble("commas","commas"));
        Assert.AreEqual(true, Scramblies.Scramble("sammoc","commas"));
    }
}