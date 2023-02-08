using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu4;

namespace codewars_tests.kyu4;

[TestClass]
public class RomanNumeralsTests
{
    [TestMethod]
    public void ToRomanBase()
    {
        //arrange
        var expectations = new Dictionary<int, string>
        {
            { 1, "I" },
            { 2, "II" },
            { 3, "III" },
            { 4, "IV" },
            { 5, "V" },
            { 6, "VI" },
            { 9, "IX" },
            { 27, "XXVII" },
            { 48, "XLVIII" },
            { 59, "LIX" },
            { 93, "XCIII" },
            { 141, "CXLI" },
            { 163, "CLXIII" },
            { 402, "CDII" },
            { 575, "DLXXV" },
            { 911, "CMXI" },
            { 1024, "MXXIV" },
            { 3000, "MMM" }
        };

        foreach (var number in expectations)
        {
            Assert.AreEqual(number.Value, RomanNumerals.ToRoman(number.Key), "Number: " + number);
        }
    }
    
    [TestMethod]
    public void FromRomanBase()
    {
        //arrange
        var expectations = new Dictionary<string, int>
        {
            { "I", 1 },
            { "II", 2 },
            { "III", 3 },
            { "IV", 4 },
            { "V", 5 },
            { "VI", 6 },
            { "IX", 9 },
            { "XXVII", 27 },
            { "XLVIII", 48 },
            { "LIX", 59 },
            { "XCIII", 93 },
            { "CXLI", 141 },
            { "CLXIII", 163 },
            { "CDII", 402 },
            { "DLXXV", 575 },
            { "CMXI", 911 },
            { "MXXIV", 1024 },
            { "MMM", 3000 }
        };

        foreach (var number in expectations)
        {
            Assert.AreEqual(number.Value, RomanNumerals.FromRoman(number.Key), "Number: " + number);
        }
    }
}