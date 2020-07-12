using System;
using System.Collections.Generic;
using System.Linq;

namespace ChessConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            ChessBoard cb = new ChessBoard();
            Console.WriteLine("Starting Chess Game!");
            Console.WriteLine(cb);
            Console.WriteLine(cb.getMoves());
            /*
            String moveInput = "";
            Console.Write("Enter your move in standard move notation. Type quit() to stop: ");
            while(moveInput != "quit()")
            {
                moveInput = Console.ReadLine();
                Console.WriteLine(cb.move(moveInput));

            }
            
            Console.WriteLine((ChessBoardFileNumber)Enum.Parse(typeof(ChessBoardFileNumber), "2"));
            int test = ChessBoardNotation.a1.ToString()[0] - 96; // should equal 1
            int test2 = ChessBoardNotation.a1.ToString()[1] - 48;
            Console.WriteLine(test2);
            Tuple<int, int> tup = new Tuple<int, int> (1, 1);
            ChessBoardFileNumber newColumnLetter = (ChessBoardFileNumber)Enum.Parse(typeof(ChessBoardFileNumber), (test + tup.Item1).ToString()); // should be 'b'
            String newRowNumber = (test2 + tup.Item2).ToString();
            Console.WriteLine(newColumnLetter);
            Console.WriteLine(newRowNumber);

            Console.WriteLine(Enum.IsDefined(typeof(ChessBoardNotation), newColumnLetter + newRowNumber) ? "yes" : "no");*/


        }
    }
}
