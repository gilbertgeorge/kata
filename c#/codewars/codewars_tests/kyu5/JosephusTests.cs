using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu5;

namespace codewars_tests.kyu5;

[TestClass]
public class JosephusTests
{
    
    [TestMethod]
    public void JosephusPermutationTest1()
    {
        JosephusPermutationTest(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 1, new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
    }

    [TestMethod]
    public void JosephusPermutationTest2()
    {
        JosephusPermutationTest(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 2, new object[] { 2, 4, 6, 8, 10, 3, 7, 1, 9, 5 });
    }

    [TestMethod]
    public void JosephusPermutationTest3()
    {
        JosephusPermutationTest(new object[] { "C", "o", "d", "e", "W", "a", "r", "s" }, 4, new object[] { "e", "s", "W", "o", "C", "d", "r", "a" });
    }

    [TestMethod]
    public void JosephusPermutationTest4()
    {
        JosephusPermutationTest(new object[] { 1, 2, 3, 4, 5, 6, 7 }, 3, new object[] { 3, 6, 2, 7, 5, 1, 4 });
    }

    [TestMethod]
    public void JosephusPermutationTest5()
    {
        JosephusPermutationTest(new object[] { }, 3, new object[] { });
    }

    private void JosephusPermutationTest(object[] items, int k, object[] result)
    {
        var actual = Josephus.JosephusPermutation(new List<object>(items), k);
        CollectionAssert.AreEqual(new List<object>(result), actual);
    }
    
    
    [TestMethod]
    public void JosephusSurvivorTest() 
    {        
        //Console.WriteLine("Basic Tests JosSurvivor");
        JosephusSurvivorTest(Josephus.JosephusSurvivor(7,3),4);
        JosephusSurvivorTest(Josephus.JosephusSurvivor(11,19),10);
        JosephusSurvivorTest(Josephus.JosephusSurvivor(40,3),28);
        JosephusSurvivorTest(Josephus.JosephusSurvivor(14,2),13);
        JosephusSurvivorTest(Josephus.JosephusSurvivor(100,1),100);
        JosephusSurvivorTest(Josephus.JosephusSurvivor(1,300),1);
        JosephusSurvivorTest(Josephus.JosephusSurvivor(2,300),1);
        JosephusSurvivorTest(Josephus.JosephusSurvivor(5,300),1);
        JosephusSurvivorTest(Josephus.JosephusSurvivor(7,300),7);
        JosephusSurvivorTest(Josephus.JosephusSurvivor(300,300),265);
    }
    private static void JosephusSurvivorTest(int actual, int expected) 
    {
        Assert.AreEqual(expected, actual);
    }
}