using System;
using System.Collections.Generic;
using System.Text;

namespace ChessConsole.Pieces
{
    public class Pawn : Piece
    {
       public Pawn(ChessBoardColor color, Square startingSquare)
            : base(color, startingSquare)
        {
            // Set move state
            hasMoved = false;
            piecePossibleMoves = new List<ChessBoardNotation>();
            if (color == ChessBoardColor.Black)
            {
                // set move type
                List<Tuple<int, int>> list = new List<Tuple<int, int>>();

                // standard one square move
                list.Add(Tuple.Create(-1, 0));
                // first move two square move
                list.Add(Tuple.Create(-2, 0));
                // capture and enpassant
                list.Add(Tuple.Create(-1, 1));
                list.Add(Tuple.Create(-1, -1));

                pieceMoveType = list;
            } else
            {
                List<Tuple<int, int>> list = new List<Tuple<int, int>>();

                // standard one square move
                list.Add(Tuple.Create(1, 0));
                // first move two square move
                list.Add(Tuple.Create(2, 0));
                // capture and enpassant
                list.Add(Tuple.Create(1, 1));
                list.Add(Tuple.Create(1, -1));

                pieceMoveType = list;
            }
        }

        override
        public String ToString() => "P";
    }
}
