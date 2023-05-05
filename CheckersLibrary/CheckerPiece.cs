using System;
using System.Collections.Generic;
using System.Drawing;

namespace CheckersGame
{
    public class CheckerPiece
    {
        public int X { get; set; }
        public int Y { get; set; }
        public CheckerColor Color { get; set; }
        public bool IsKing { get; set; }

        public CheckerPiece(int x, int y, CheckerColor color, bool isKing = false)
        {
            X = x;
            Y = y;
            Color = color;
            IsKing = isKing;
        }

        public void Move(int newX, int newY)
        {
            X = newX;
            Y = newY;
        }

        public void MakeKing()
        {
            IsKing = true;
        }
    }

    