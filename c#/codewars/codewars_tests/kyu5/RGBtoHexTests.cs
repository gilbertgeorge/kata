using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu5;

namespace codewars_tests.kyu5;

[TestClass]
public class RGBtoHexTests
{
    [TestMethod]
    public void FixedTests() 
    {
        Assert.AreEqual("FFFFFF", RGBtoHex.Rgb(255,255,255));
        Assert.AreEqual("FFFFFF", RGBtoHex.Rgb(255,255,300));
        Assert.AreEqual("000000", RGBtoHex.Rgb(0,0,0));
        Assert.AreEqual("9400D3", RGBtoHex.Rgb(148,0,211));
        Assert.AreEqual("9400D3", RGBtoHex.Rgb(148,-20,211), "Handle negative numbers.");
        Assert.AreEqual("90C3D4", RGBtoHex.Rgb(144,195,212));
        Assert.AreEqual("D4350C", RGBtoHex.Rgb(212,53,12), "Consider single hex digit numbers.");
    }
}