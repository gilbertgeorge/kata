using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu4;

namespace codewars_tests.kyu4;

[TestClass]
public class ParserTests
{
    [TestMethod]
    public void ParseIntFixedTest1()
    {
        Assert.AreEqual(0, Parser.ParseInt("zero"));
    }
    
    [TestMethod]
    public void ParseIntFixedTest2()
    {
        Assert.AreEqual(1, Parser.ParseInt("one"));
    }
    
    [TestMethod]
    public void ParseIntFixedTest3()
    {
        Assert.AreEqual(20, Parser.ParseInt("twenty"));
    }
    
    [TestMethod]
    public void ParseIntFixedTest4()
    {
        Assert.AreEqual(246, Parser.ParseInt("two hundred forty-six"));
    }
    
    [TestMethod]
    public void ParseIntFixedTest5()
    {
        Assert.AreEqual(783919, Parser.ParseInt("seven hundred eighty-three thousand nine hundred and nineteen"));
    }
    
    [TestMethod]
    public void ParseIntComplexTests()
    {
        Assert.AreEqual(1000000, Parser.ParseInt("one million"));
        Assert.AreEqual(1000001, Parser.ParseInt("one million one"));
        Assert.AreEqual(999999, Parser.ParseInt("NINE HUNDRED NINETY-NINE THOUSAND NINE HUNDRED NINETY-NINE"));
        Assert.AreEqual(65, Parser.ParseInt("sixty-five"));
        Assert.AreEqual(295811, Parser.ParseInt("two hundred and ninety-five thousand eight hundred and eleven"));
        Assert.AreEqual(83000, Parser.ParseInt("eighty-three thousand"));
        Assert.AreEqual(646020, Parser.ParseInt("six hundred forty-six thousand and twenty"));
    }

    [TestMethod]
    public void ParseIntTricks()
    {
        Assert.AreEqual(200003, Parser.ParseInt("Two hundred thousand and three"));
    }
}