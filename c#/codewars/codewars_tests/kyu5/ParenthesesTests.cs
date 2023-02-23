using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu5;

namespace codewars_tests.kyu5;

[TestClass]
public class ParenthesesTests
{
    [TestMethod]
    public void SampleTest1()
    {
        Assert.AreEqual(true, Parentheses.ValidParentheses( "()" ));
    }
    
    [TestMethod]
    public void SampleTest2()
    {
        Assert.AreEqual(false, Parentheses.ValidParentheses( ")((((" ));
    }
    
    [TestMethod]
    public void SampleTest3()
    {
        Assert.AreEqual(false, Parentheses.ValidParentheses( ")(()))" ));
    }
    
    [TestMethod]
    public void SampleTest4()
    {
        Assert.AreEqual(false, Parentheses.ValidParentheses( "(" ));
    }
    
    [TestMethod]
    public void SampleTest5()
    {
        Assert.AreEqual(true, Parentheses.ValidParentheses( "(())((()())())" ));
    }
}