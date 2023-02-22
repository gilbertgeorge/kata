using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu5;

namespace codewars_tests.kyu5;

[TestClass]
public class ZerosEndTests
{
    [TestMethod]
    public void Test()
    {
        CollectionAssert.AreEqual(new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}, ZerosEnd.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}));
    }
}