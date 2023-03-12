using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu5;

namespace codewars_tests.kyu5;

[TestClass]
public class PerfectPowerTests
{
    [TestMethod]
    public void PerfectPowerTest0()
    {
        Assert.IsNull(PerfectPower.IsPerfectPower(0), "0 is not a perfect number");
    }

    [TestMethod]
    public void PerfectPowerTest1()
    {
        Assert.IsNull(PerfectPower.IsPerfectPower(1), "1 is not a perfect number");
    }

    [TestMethod]
    public void PerfectPowerTest2()
    {
        Assert.IsNull(PerfectPower.IsPerfectPower(2), "2 is not a perfect number");
    }

    [TestMethod]
    public void PerfectPowerTest3()
    {
        Assert.IsNull(PerfectPower.IsPerfectPower(3), "3 is not a perfect number");
    }

    [TestMethod]
    public void PerfectPowerTest4()
    {
        Assert.AreEqual((2, 2), PerfectPower.IsPerfectPower(4), "4 = 2^2");
    }

    [TestMethod]
    public void PerfectPowerTest5()
    {
        Assert.IsNull(PerfectPower.IsPerfectPower(5), "5 is not a perfect power");
    }

    [TestMethod]
    public void PerfectPowerTest8()
    {
        Assert.AreEqual((2, 3), PerfectPower.IsPerfectPower(8), "8 = 2^3");
    }

    [TestMethod]
    public void PerfectPowerTest9()
    {
        Assert.AreEqual((3, 2), PerfectPower.IsPerfectPower(9), "9 = 3^2");
    }

    [TestMethod]
    public void PerfectPowerTestUpTo500()
    {
        var pp = new int[] { 4, 8, 9, 16, 25, 27, 32, 36, 49, 64, 81, 100, 121, 125, 128, 144, 169, 196, 216, 225, 243, 256, 289, 324, 343, 361, 400, 441, 484 };
        foreach (var i in pp)
            Assert.IsNotNull(PerfectPower.IsPerfectPower(i), $"{i} is a perfect power");
    }
}