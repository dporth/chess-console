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
       
        public Boolean hasMoved
        {
            protected set;
            get;
        }

        public List<ChessBoardNotation> piecePossibleMoves
        {
            protected set;
            get;
        }

        public List<Tuple<int, int>> pieceMoveType
        {
            protected set;
            get;
        }

        public Piece(ChessBoardColor color, Square startingSquare)
        {
            pieceColor = color;
            pieceSquare = startingSquare;
        }

        override
        public String ToString()
        {
            return " ";
        }
    }
}
