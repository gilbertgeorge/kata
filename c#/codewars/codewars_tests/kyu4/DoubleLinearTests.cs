using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu4;

namespace codewars_tests.kyu4;

[TestClass]
public class DoubleLinearTests
{
    [TestMethod]
    public void DblLinearBase()
    {
        Assert.AreEqual(DoubleLinear.DblLinear(10), 22);
        Assert.AreEqual(DoubleLinear.DblLinear(20), 57);
        Assert.AreEqual(DoubleLinear.DblLinear(30), 91);
        Assert.AreEqual(DoubleLinear.DblLinear(50), 175);
    }
}