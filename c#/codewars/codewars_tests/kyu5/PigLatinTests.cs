using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu5;

namespace codewars_tests.kyu5;

[TestClass]
public class PigLatinTests
{
    [TestMethod]
    public void PigItTests()
    {
        Assert.AreEqual("igPay atinlay siay oolcay", PigLatin.PigIt("Pig latin is cool"));
        Assert.AreEqual("hisTay siay ymay tringsay", PigLatin.PigIt("This is my string"));
    }
}