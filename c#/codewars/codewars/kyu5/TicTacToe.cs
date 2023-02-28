namespace codewars.kyu5;

public class TicTacToe
{
    public int IsSolved(int[,] board)
    {
        for (var i = 0; i < 3; i++)
        {
            if (board[i, 0] == 0)
                continue;
            if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                return board[i, 0];
        }
        
        for (var i = 0; i < 3; i++)
        {
            if (board[0, i] == 0)
                continue;
            if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
                return board[0, i];
        }
        
        if (board[1, 1] != 0)
        {
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                return board[1, 1];
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                return board[1, 1];
        }
        
        for (var i = 0; i < 3; i++)
        {
            for (var j = 0; j < 3; j++)
            {
                if (board[i, j] == 0)
                    return -1;
            }
        }
        
        return 0;
    }
}