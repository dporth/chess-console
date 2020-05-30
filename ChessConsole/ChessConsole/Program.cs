using System;
using System.Collections.Generic;

namespace ChessConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Tuple<int, int>> list = new List<Tuple<int, int>>();
            list.Add(Tuple.Create(1,1));

            IEnumerable<Tuple<int, int>> en = list;
            Pieces.Pawn p = new Pieces.Pawn(ChessBoardColor.Black, en);
            Console.WriteLine(p.pieceColor);
            Console.WriteLine(String.Join(", ", p.pieceMoveType));

        }
    }
}
