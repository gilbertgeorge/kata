using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu7;

namespace codewars_tests.kyu7;

[TestClass]
public class JadenCaseTests
{
    [TestMethod]
    public void JadenCaseBase()
    {
        //arrange
        var expectedFirst = "How Can Mirrors Be Real If Our Eyes Aren't Real";
        
        //act
        var actualFirst = JadenCase.ToJadenCase("How can mirrors be real if our eyes aren't real");
        
        //assert
        Assert.AreEqual(expectedFirst, actualFirst);
    }
}