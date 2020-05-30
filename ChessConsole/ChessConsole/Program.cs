using System;
using System.Collections.Generic;

namespace ChessConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create piece move type
            List<Tuple<int, int>> list = new List<Tuple<int, int>>();
            list.Add(Tuple.Create(1,1));

            IEnumerable<Tuple<int, int>> en = list;

            Square s = new Square(ChessBoardColor.Black, ChessBoardNotation.a2);

            Pieces.Pawn p = new Pieces.Pawn(ChessBoardColor.Black, en, s);
            Console.WriteLine(p.pieceColor);
            Console.WriteLine(String.Join(", ", p.pieceMoveType));
            Console.WriteLine(p.pieceSquare);

        }
    }
}
