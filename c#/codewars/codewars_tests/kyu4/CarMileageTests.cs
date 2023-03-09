using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu4;

namespace codewars_tests.kyu4;

[TestClass]
public class CarMileageTests
{
    [TestMethod]
    public void CarMileageBaseTests()
    {
        Assert.AreEqual(0, CarMileage.IsInteresting(3, new List<int>() { 1337, 256 }));
        Assert.AreEqual(1, CarMileage.IsInteresting(1336, new List<int>() { 1337, 256 }));
        Assert.AreEqual(2, CarMileage.IsInteresting(1337, new List<int>() { 1337, 256 }));
        Assert.AreEqual(0, CarMileage.IsInteresting(11208, new List<int>() { 1337, 256 }));
        Assert.AreEqual(1, CarMileage.IsInteresting(11209, new List<int>() { 1337, 256 }));
        Assert.AreEqual(2, CarMileage.IsInteresting(11211, new List<int>() { 1337, 256 }));
    }

    [TestMethod]
    public void CarMileageIncrementingTests()
    {
        Assert.AreEqual(2, CarMileage.IsInteresting(7890, new List<int>() { }));
        Assert.AreEqual(1, CarMileage.IsInteresting(7889, new List<int>() { }));
        Assert.AreEqual(0, CarMileage.IsInteresting(1469, new List<int>() { }));
    }
    
    [TestMethod]
    public void CarMileageDecrementingTests()
    {
        Assert.AreEqual(2, CarMileage.IsInteresting(3210, new List<int>() { }));
        Assert.AreEqual(1, CarMileage.IsInteresting(3209, new List<int>() { }));
        Assert.AreEqual(0, CarMileage.IsInteresting(9541, new List<int>() { }));
    }
    
    [TestMethod]
    public void AdvancedTests()
    {
        Assert.AreEqual(1, CarMileage.IsInteresting(98, new List<int>() { }));
        Assert.AreEqual(0, CarMileage.IsInteresting(30, new List<int>() { }));
        Assert.AreEqual(2, CarMileage.IsInteresting(1234, new List<int>() { }));
        Assert.AreEqual(0, CarMileage.IsInteresting(88, new List<int>() { }));
    }

}