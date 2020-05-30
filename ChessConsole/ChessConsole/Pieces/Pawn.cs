using System;
using System.Collections.Generic;
using System.Text;

namespace ChessConsole.Pieces
{
    public class Pawn : Piece
    {
       public Pawn(ChessBoardColor color, IEnumerable<Tuple<int, int>>  moves, Square startingSquare)
            : base(color, moves, startingSquare)
        {
            
        }
    }
}
