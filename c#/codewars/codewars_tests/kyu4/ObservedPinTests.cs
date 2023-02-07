using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu4;

namespace codewars_tests.kyu4;

[TestClass]
public class ObservedPinTests
{
    [TestMethod]
    public void ObservedPinBase()
    {
        //arrange
        var expectations = new Dictionary<string, string[]>
        {
            { "8", new[] { "5", "7", "8", "9", "0" } },
            { "11", new[] { "11", "22", "44", "12", "21", "14", "41", "24", "42" } },
            {
                "369",
                new[]
                {
                    "339", "366", "399", "658", "636", "258", "268", "669", "668", "266", "369", "398", "256", "296",
                    "259", "368", "638", "396", "238", "356", "659", "639", "666", "359", "336", "299", "338", "696",
                    "269", "358", "656", "698", "699", "298", "236", "239"
                }
            }
        };

        foreach (var pin in expectations)
        {
            CollectionAssert.AreEquivalent(pin.Value, ObservedPin.GetPINs(pin.Key), "PIN: " + pin);
        }
    }
}