using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu4;

namespace codewars_tests.kyu4;

[TestClass]
public class CommentsTests
{
    [TestMethod]
    public void StripCommentsBase()
    {
        Assert.AreEqual(
            "apples, pears\ngrapes\nbananas",
            Comments.StripComments(
                "apples, pears # and bananas\ngrapes\nbananas !apples", new string[] {"#", "!"}));

        Assert.AreEqual(
            "a\nc\nd", Comments.StripComments(
                "a #b\nc\nd $e f g", new string[] {"#", "$"}));
        
        Assert.AreEqual(
            "ad", Comments.StripComments(
                "ad $test single", new string[] {"#", "$"}));
        
        Assert.AreEqual(
            "a\n b\nc", Comments.StripComments(
                "a  #test\n b  $test \nc", new string[] {"#", "$"}));
        
        Assert.AreEqual(
            "a\n b\nc", Comments.StripComments(
                "a \n b \nc", new string[] {"#", "$"}));
    }
}