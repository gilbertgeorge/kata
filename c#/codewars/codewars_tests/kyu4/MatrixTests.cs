using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu4;

namespace codewars_tests.kyu4;

[TestClass]
public class MatrixTests
{
    [TestMethod]
    public void DeterminantBase()
    {
        var a = new int[][] {new[] {1}};
        var b = new int[][] {new[] {1, 3}, new[] {2, 5}};
        var c = new int[][] {new[] {2, 5, 3}, new[] {1, -2, -1}, new[] {1, 3, 4}};
        var d = new int[][] {new[] {1, 2, 3, 4}, new[] {5, 0, 2, 8}, new[] {3, 5, 6, 7}, new[] {2, 5, 3, 1}};
        
        Assert.AreEqual(Matrix.Determinant(a), 1);
        Assert.AreEqual(Matrix.Determinant(b), -1);
        Assert.AreEqual(Matrix.Determinant(c), -20);
        Assert.AreEqual(Matrix.Determinant(d), 24);
    }
}