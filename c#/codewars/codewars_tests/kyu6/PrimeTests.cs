using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu6;

namespace codewars_tests.kyu6;

[TestClass]
public class PrimeTests
{
    [TestMethod]
    public void IsPrimeBase()
    {
        //arrange
        //act
        //assert
        Assert.AreEqual(false, Prime.IsPrime(1));
        Assert.AreEqual(true, Prime.IsPrime(2));
        Assert.AreEqual(false, Prime.IsPrime(-1));
        
        Assert.AreEqual(true, Prime.IsPrime(5));
        Assert.AreEqual(false, Prime.IsPrime(6));
        Assert.AreEqual(true, Prime.IsPrime(7));
        Assert.AreEqual(false, Prime.IsPrime(8));
        Assert.AreEqual(false, Prime.IsPrime(9));
        Assert.AreEqual(false, Prime.IsPrime(10));
        Assert.AreEqual(true, Prime.IsPrime(11));
    }

    [TestMethod]
    public void IsPrimeLarge()
    {
        Assert.AreEqual(false, Prime.IsPrime(2147483200));
        Assert.AreEqual(true, Prime.IsPrime(2147483563));
        // Assert.AreEqual(true, Prime.IsPrime(2147483489));
        // Assert.AreEqual(true, Prime.IsPrime(2147483353));
        // Assert.AreEqual(true, Prime.IsPrime(2147483237));
        // Assert.AreEqual(true, Prime.IsPrime(2147483123));
        // Assert.AreEqual(true, Prime.IsPrime(2147483053));        
    }
}