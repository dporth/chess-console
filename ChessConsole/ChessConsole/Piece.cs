using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ChessConsole
{
    public abstract class Piece
    {
        public GameColor pieceColor
        {
            private set;
            get;
        }
    }
}
