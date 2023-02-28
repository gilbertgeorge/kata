using Microsoft.VisualStudio.TestTools.UnitTesting;
using codewars.kyu5;

namespace codewars_tests.kyu5;

[TestClass]
public class TicTacToeTests
{
    private TicTacToe _tictactoe = new TicTacToe();
    
    [TestInitialize]
    public void Initialize() {
        _tictactoe = new TicTacToe();
    }
  
    [TestMethod]
    public void OneWins_Row() {
        int[,] board = new int[,] { { 1, 1, 1 }, { 0, 2, 2 }, { 0, 0, 0 } };
        Assert.AreEqual(1, _tictactoe.IsSolved(board));
    }
    
    [TestMethod]
    public void TwoWins_Column() {
        int[,] board = new int[,] { { 2, 1, 1 }, { 2, 1, 2 }, { 2, 0, 0 } };
        Assert.AreEqual(2, _tictactoe.IsSolved(board));
    }
    
    [TestMethod]
    public void NotFinished() {
        int[,] board = new int[,] { { 0, 0, 1 }, { 0, 0, 2 }, { 2, 0, 0 } };
        Assert.AreEqual(-1, _tictactoe.IsSolved(board));
    }
    
    [TestMethod]
    public void Draw() {
        int[,] board = new int[,] { { 1, 2, 1 }, { 2, 1, 2 }, { 2, 1, 2 } };
        Assert.AreEqual(0, _tictactoe.IsSolved(board));
    }
}