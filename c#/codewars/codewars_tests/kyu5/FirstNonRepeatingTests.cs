using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu5;

namespace codewars_tests.kyu5;

[TestClass]
public class FirstNonRepeatingTests
{
    [TestMethod]
    public void FirstNonRepeatingBase()
    {
        //arrange
        //act
        //assert
        Assert.AreEqual("a", FirstNonRepeating.FirstNonRepeatingLetter("a"));
        Assert.AreEqual("t", FirstNonRepeating.FirstNonRepeatingLetter("stress"));
        Assert.AreEqual("e", FirstNonRepeating.FirstNonRepeatingLetter("moonmen"));
        Assert.AreEqual("T", FirstNonRepeating.FirstNonRepeatingLetter("sTreSS"));
        Assert.AreEqual("", FirstNonRepeating.FirstNonRepeatingLetter("ssSSsss"));
        Assert.AreEqual("", FirstNonRepeating.FirstNonRepeatingLetter(""));
    }
}