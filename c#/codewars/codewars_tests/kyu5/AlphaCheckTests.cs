using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu5;

namespace codewars_tests.kyu5;

[TestClass]
public class AlphaCheckTests
{
    [TestMethod]
    public void AlphanumericBase()
    {
        //arrange
        //act
        //assert
        Assert.AreEqual(false, AlphaCheck.Alphanumeric("hello world_"));
        Assert.AreEqual(true, AlphaCheck.Alphanumeric("PassW0rd"));
        Assert.AreEqual(false, AlphaCheck.Alphanumeric("     "));
        Assert.AreEqual(false, AlphaCheck.Alphanumeric("     _"));
        Assert.AreEqual(false, AlphaCheck.Alphanumeric("Hello World"));
        Assert.AreEqual(true, AlphaCheck.Alphanumeric("HelloWorld"));
        Assert.AreEqual(false, AlphaCheck.Alphanumeric(""));
    }
}