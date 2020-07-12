using System;
using System.Collections.Generic;
using System.Text;

namespace ChessConsole
{
    public class Square
    {
        public Piece squarePiece
        {
            set;
            get;
        }

        public ChessBoardColor squareColor
        {
            private set;
            get;
        }

        public ChessBoardNotation squareNotation
        {
            private set;
            get;
        }

        public Square(ChessBoardColor color, ChessBoardNotation notation)
        {
            squareColor = color;
            squareNotation = notation;
            squarePiece = null;
        }
    }
}
