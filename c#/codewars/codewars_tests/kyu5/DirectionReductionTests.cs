using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu5;

namespace codewars_tests.kyu5;

[TestClass]
public class DirectionReductionTests
{
    [TestMethod]
    public void DirReductionTest1() {
        string[] a = new string[] {"NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST"};
        string[] b = new string[] {"WEST"};
        CollectionAssert.AreEqual(b, DirectionReduction.DirReduction(a));
    }
    [TestMethod]
    public void DirReductionTest2() {
        string[] a = new string[] {"NORTH", "WEST", "SOUTH", "EAST"};
        string[] b = new string[] {"NORTH", "WEST", "SOUTH", "EAST"};
        CollectionAssert.AreEqual(b, DirectionReduction.DirReduction(a));
    }
}