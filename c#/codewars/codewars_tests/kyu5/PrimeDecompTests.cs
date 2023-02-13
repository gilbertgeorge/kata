using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu5;

namespace codewars_tests.kyu5;

[TestClass]
public class PrimeDecompTests
{
    [TestMethod]
    public void FactorsBase()
    {
        Assert.AreEqual("(2**5)(5)(7**2)(11)", PrimeDecomp.factors(86240));
        Assert.AreEqual("(2**2)(3**3)(5)(7)(11**2)(17)", PrimeDecomp.factors(7775460));
    }
}