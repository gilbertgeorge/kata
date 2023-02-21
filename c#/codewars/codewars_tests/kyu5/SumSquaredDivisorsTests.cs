using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu5;

namespace codewars_tests.kyu5;

[TestClass]
public class SumSquaredDivisorsTests
{
    [TestMethod]
    public void Test01() {
        Assert.AreEqual("[[1, 1], [42, 2500], [246, 84100]]", SumSquaredDivisors.listSquared(1, 250));
    }
    [TestMethod]
    public void Test02() {
        Assert.AreEqual("[[42, 2500], [246, 84100]]", SumSquaredDivisors.listSquared(42, 250));
    }
    [TestMethod]
    public void Test03() {
        Assert.AreEqual("[[287, 84100]]", SumSquaredDivisors.listSquared(250, 500));
    }
}