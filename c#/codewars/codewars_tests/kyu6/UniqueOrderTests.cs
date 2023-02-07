using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu6;

namespace codewars_tests.kyu6;

[TestClass]
public class UniqueOrderTests
{
    [TestMethod]
    public void UniqueOrderBase()
    {
        //arrange
        IEnumerable<char> expectedFirst = new List<char>() {'A', 'B', 'C', 'D', 'A', 'B'};
        IEnumerable<char> expectedSecond = new List<char>() {'A', 'B', 'C', 'c', 'A', 'D'};
        IEnumerable<int> expectedThird = new List<int>() {1, 2, 3};
        
        //act
        var actualFirst = UniqueOrder.UniqueInOrder("AAAABBBCCDAABBB");
        var actualSecond = UniqueOrder.UniqueInOrder("ABBCcAD");
        var actualThird = UniqueOrder.UniqueInOrder(new int[] {1,2,2,3,3});
        
        //assert
        CollectionAssert.AreEqual(expectedFirst.ToList(), actualFirst.ToList());
        CollectionAssert.AreEqual(expectedSecond.ToList(), actualSecond.ToList());
        CollectionAssert.AreEqual(expectedThird.ToList(), actualThird.ToList());
    }
}