using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu5;

namespace codewars_tests.kyu5;

[TestClass]
public class PaginationHelperTests
{
    private readonly IList<int> _collection = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24};
    private PagnationHelper<int> _helper;
    private readonly IList<char> _collection2 = new List<char>{'a', 'b', 'c', 'd', 'e', 'f'};
    private PagnationHelper<char> _helper2;
    
    [TestInitialize]
    public void SetUp()
    {
        _helper = new PagnationHelper<int>(_collection, 10);
        _helper2 = new PagnationHelper<char>(_collection2, 4);
    }
    
    [TestMethod]
    public void PageItemCountTest()
    {
        Assert.AreEqual(-1, _helper.PageItemCount(-1));
        Assert.AreEqual(10, _helper.PageItemCount(1));
        Assert.AreEqual(-1, _helper.PageItemCount(3));
        
        Assert.AreEqual(4, _helper2.PageItemCount(0));
        Assert.AreEqual(2, _helper2.PageItemCount(1));
        Assert.AreEqual(-1, _helper2.PageItemCount(2));
        
    }
    
    [TestMethod]
    public void PageIndexTest()
    {
        Assert.AreEqual(-1, _helper.PageIndex(-1));
        Assert.AreEqual(1, _helper.PageIndex(12));
        Assert.AreEqual(-1, _helper.PageIndex(24));
        
        Assert.AreEqual(1, _helper2.PageIndex(5));
        Assert.AreEqual(0, _helper2.PageIndex(2));
        Assert.AreEqual(-1, _helper2.PageIndex(20));
        Assert.AreEqual(-1, _helper2.PageIndex(-10));
    }
    
    [TestMethod]
    public void ItemCountTest()
    {
        Assert.AreEqual(24, _helper.ItemCount);
        
        Assert.AreEqual(6, _helper2.ItemCount);
    }
    
    [TestMethod]
    public void PageCountTest()
    {
        Assert.AreEqual(3, _helper.PageCount);
        
        Assert.AreEqual(2, _helper2.PageCount);
    }
    
}