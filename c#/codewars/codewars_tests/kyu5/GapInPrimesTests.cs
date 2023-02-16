using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu5;

namespace codewars_tests.kyu5;

[TestClass]
public class GapInPrimesTests
{
    [TestMethod]
    public void GapInPrimesBase()
    {
        CollectionAssert.AreEqual(new long[] {101, 103}, GapInPrimes.Gap(2,100,110));
        CollectionAssert.AreEqual(new long[] {103, 107}, GapInPrimes.Gap(4,100,110));
        CollectionAssert.AreEqual(new long[] {101, 103}, GapInPrimes.Gap(2,100,103));
        CollectionAssert.AreEqual(null, GapInPrimes.Gap(6,100,110));
        CollectionAssert.AreEqual(new long[] {359, 367}, GapInPrimes.Gap(8,300,400));
        CollectionAssert.AreEqual(new long[] {337, 347}, GapInPrimes.Gap(10,300,400));
    }
}