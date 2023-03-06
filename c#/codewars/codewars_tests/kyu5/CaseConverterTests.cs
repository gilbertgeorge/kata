using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu5;

namespace codewars_tests.kyu5;

[TestClass]
public class CaseConverterTests
{
    [TestMethod]
    public void PascalToSnakeTests()
    {
        Assert.AreEqual("test_controller", CaseConverter.PascalToSnake("TestController"));
        Assert.AreEqual("this_is_beautiful_day", CaseConverter.PascalToSnake("ThisIsBeautifulDay"));
        Assert.AreEqual("am7_days", CaseConverter.PascalToSnake("Am7Days"));
        Assert.AreEqual("my3_code_is4_times_better", CaseConverter.PascalToSnake("My3CodeIs4TimesBetter"));
        Assert.AreEqual("arbitrarily_sending_different_types_to_functions_makes_katas_cool", CaseConverter.PascalToSnake("ArbitrarilySendingDifferentTypesToFunctionsMakesKatasCool"));
        Assert.AreEqual("1", CaseConverter.PascalToSnake(1), "Numbers should be turned to strings!");
    }
}