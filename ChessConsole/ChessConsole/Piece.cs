using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ChessConsole
{
    public abstract class Piece
    {
        public ChessBoardColor pieceColor
        {
            private set;
            get;
        }

        public Square pieceSquare
        {
            protected set;
            get;
        }
       
        public IEnumerable<Tuple<int, int>> pieceMoveType
        {
            private set;
            get;
        }

        public Piece(ChessBoardColor color, IEnumerable<Tuple<int, int>> moves, Square square)
        {
            pieceColor = color;
            pieceMoveType = moves;
            pieceSquare = square;
        }

    }
}
