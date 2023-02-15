using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu5;

namespace codewars_tests.kyu5;

[TestClass]
public class IntToIPv4Tests
{
    [TestMethod]
    public void UInt32ToIPBase()
    {
        Assert.AreEqual("128.32.10.1", IntToIPv4.UInt32ToIP(2149583361));
        Assert.AreEqual("128.114.17.104", IntToIPv4.UInt32ToIP(2154959208));
        Assert.AreEqual("0.0.0.0", IntToIPv4.UInt32ToIP(0));
        Assert.AreEqual("33.178.48.191", IntToIPv4.UInt32ToIP(565326015));
    }
}