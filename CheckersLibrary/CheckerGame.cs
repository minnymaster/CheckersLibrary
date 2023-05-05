public class CheckerGame
{
    public CheckersBoard Board { get; set; }
    public CheckerColor CurrentPlayer { get; set; }

    public CheckerGame()
    {
        Board = new CheckersBoard();
        CurrentPlayer = CheckerColor.Red;
    }

    public bool MakeMove(CheckerPiece piece, int newX, int newY)
    {
        if (Board.IsValidMove(piece, newX, newY))
        {
            Board.MovePiece(piece, newX, newY);

            if (Board.GetPossibleMoves(piece).Count > 0 && Board.IsValidMove(piece, newX, newY + (piece.Color == CheckerColor.Red ? -2 : 2)))
            {
                return false;
            }

            if (piece.Color == CheckerColor.Red)
            {
                CurrentPlayer = CheckerColor.Black;
            }
            else
            {
                CurrentPlayer = CheckerColor.Red;
            }

            return true;
        }

        return false;
    }

    public bool IsGameOver()
    {
        int redCount = 0;
        int blackCount = 0;

        for (int x = 0; x < 8; x++)
        {
            for (int y = 0; y < 8; y++)
            {
                CheckerPiece piece = Board.Board[x, y];

                if (piece != null)
                {
                    if (piece.Color == CheckerColor.Red)
                    {
                        redCount++;
                    }
                    else
                    {
                        blackCount++;
                    }
                }
            }
        }

        return redCount == 0 || blackCount == 0;
    }
}