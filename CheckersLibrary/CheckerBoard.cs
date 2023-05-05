public class CheckersBoard
{
    public CheckerPiece[,] Board { get; set; }

    public CheckersBoard()
    {
        Board = new CheckerPiece[8, 8];

        for (int x = 0; x < 8; x++)
        {
            for (int y = 0; y < 8; y++)
            {
                if ((x + y) % 2 != 0)
                {
                    if (y < 3)
                    {
                        Board[x, y] = new CheckerPiece(x, y, CheckerColor.Black);
                    }
                    else if (y > 4)
                    {
                        Board[x, y] = new CheckerPiece(x, y, CheckerColor.Red);
                    }
                }
            }
        }
    }

    public bool IsValidMove(CheckerPiece piece, int newX, int newY)
    {
        if (newX < 0 || newX > 7 || newY < 0 || newY > 7)
        {
            return false;
        }

        if (Board[newX, newY] != null)
        {
            return false;
        }

        int deltaX = Math.Abs(newX - piece.X);
        int deltaY = newY - piece.Y;

        if (deltaX == 1 && deltaY == piece.Color == CheckerColor.Red ? -1 : 1)
        {
            return true;
        }

        if (deltaX == 2 && deltaY == piece.Color == CheckerColor.Red ? -2 : 2)
        {
            int jumpedX = (newX + piece.X) / 2;
            int jumpedY = (newY + piece.Y) / 2;
            CheckerPiece jumpedPiece = Board[jumpedX, jumpedY];

            if (jumpedPiece != null && jumpedPiece.Color != piece.Color)
            {
                return true;
            }
        }

        return false;
    }

    public void MovePiece(CheckerPiece piece, int newX, int newY)
    {
        if (IsValidMove(piece, newX, newY))
        {
            Board[piece.X, piece.Y] = null;
            piece.Move(newX, newY);
            Board[newX, newY] = piece;

            if (newY == 0 || newY == 7)
            {
                piece.MakeKing();
            }
        }
    }

    public List<CheckerPiece> GetPossibleMoves(CheckerPiece piece)
    {
        List<CheckerPiece> moves = new List<CheckerPiece>();

        for (int x = piece.X - 2; x <= piece.X + 2; x++)
        {
            for (int y = piece.Y - 2; y <= piece.Y + 2; y++)
            {
                if (IsValidMove)
                {
                    moves.Add(new CheckerPiece(x, y, piece.Color));
                }
            }
        }

        moves.RemoveAll(p => p.X < 0 || p.X > 7 || p.Y < 0 || p.Y > 7);
        moves.RemoveAll(p => Board[p.X, p.Y] != null);
        moves.RemoveAll(p => Math.Abs(p.X - piece.X) != Math.Abs(p.Y - piece.Y));

        return moves;
    }
}
