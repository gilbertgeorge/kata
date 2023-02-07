using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu8;

namespace codewars_tests.kyu8;

[TestClass]
public class UnfinishedLoopTests
{
    [TestMethod]
    public void CreateListBase()
    {
        //arrange
        var expected = new int[] { 1 };
        
        //act
        var actual = UnfinishedLoop.CreateList(1);

        //assert
        CollectionAssert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void CreateListMultiple()
    {
        //arrange
        var expected = new int[] { 1, 2, 3, 4, 5, 6 };
        
        //act
        var actual = UnfinishedLoop.CreateList(6);

        //assert
        CollectionAssert.AreEqual(expected, actual);
    }
}