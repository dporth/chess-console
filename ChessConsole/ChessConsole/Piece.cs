using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ChessConsole
{
    public abstract class Piece
    {
        public ChessGameColor pieceColor
        {
            private set;
            get;
        }

        public ChessBoardCoordinate pieceCoordinate
        {
            private set;
            get;
        }
    }
}
