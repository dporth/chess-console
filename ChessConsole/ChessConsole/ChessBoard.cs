using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessConsole
{
    public class ChessBoard
    {
        private Square[,] boardSquares;
        private ChessBoardColor colorToMove;
        private List<Piece> whitePieces = new List<Piece>();
        private List<Piece> blackPieces = new List<Piece>();

        public ChessBoard()
        {
            initializeChessBoard();
            colorToMove = ChessBoardColor.White;
            findPossibleMoves();
        }

        public void move(String move)
        {
            if(validateMove(move))
            {
                var notations = Enum.GetNames(typeof(ChessBoardNotation));

                // Counter to access notations sequentially in notation array
                int notationCounter = 0;

                // Pawn move
                if (move.Length == '2')
                {
                    // Calculate possible moves for player's pawns
                    for (int i = 0; i < notations.Length / 8; i++)
                    {
                        for (int j = 0; j < notations.Length / 8; j++)
                        {
                            ChessBoardNotation notationEnum = (ChessBoardNotation)Enum.Parse(typeof(ChessBoardNotation), notations[notationCounter]);
                            if (boardSquares[i, j].squareNotation == notationEnum)
                            {

                            }
                        }
                    }
                }
            }
        }

        private void initializeChessBoard()
        {
            boardSquares = new Square[8, 8];
            // Get names from ChessBoardNotation enum
            var notations = Enum.GetNames(typeof(ChessBoardNotation));
            // Counter to access notations sequentially in notation array
            int notationCounter = 0;
            // Iterate over enum names
            // TODO: Find better way to get x, y length of 2D array
            for (int i = 0; i < notations.Length / 8; i++)
            {
                for (int  j = 0; j < notations.Length / 8; j++)
                {
                    // Square is white if sum of position in ChessBoard is even or zero
                    ChessBoardColor color;
                    if((i + j) % 2 == 0)
                    {
                        color = ChessBoardColor.White;
                    } else
                    {
                        color = ChessBoardColor.Black;
                    }
                    // Convert square's notation into ChessBoardNotation
                    ChessBoardNotation notationEnum = (ChessBoardNotation)Enum.Parse(typeof(ChessBoardNotation), notations[notationCounter]);
                    // Create new square with square's color and notation
                    Square newSquare = new Square(color, notationEnum);
                    // Add square to chess baord
                    boardSquares[i, j] = newSquare;
                    notationCounter += 1;
                }
            }

            // Add white pawns to chess board
            addPiece(1, 0, new Pieces.Pawn(ChessBoardColor.White, boardSquares[1, 0]));
            addPiece(1, 1, new Pieces.Pawn(ChessBoardColor.White, boardSquares[1, 1]));
            addPiece(1, 2, new Pieces.Pawn(ChessBoardColor.White, boardSquares[1, 2]));
            addPiece(1, 3, new Pieces.Pawn(ChessBoardColor.White, boardSquares[1, 3]));
            addPiece(1, 4, new Pieces.Pawn(ChessBoardColor.White, boardSquares[1, 4]));
            addPiece(1, 5, new Pieces.Pawn(ChessBoardColor.White, boardSquares[1, 5]));
            addPiece(1, 6, new Pieces.Pawn(ChessBoardColor.White, boardSquares[1, 6]));
            addPiece(1, 7, new Pieces.Pawn(ChessBoardColor.White, boardSquares[1, 7]));

            // Add black pawns to chess board
            addPiece(6, 0, new Pieces.Pawn(ChessBoardColor.Black, boardSquares[6, 0]));
            addPiece(6, 1, new Pieces.Pawn(ChessBoardColor.Black, boardSquares[6, 1]));
            addPiece(6, 2, new Pieces.Pawn(ChessBoardColor.Black, boardSquares[6, 2]));
            addPiece(6, 3, new Pieces.Pawn(ChessBoardColor.Black, boardSquares[6, 3]));
            addPiece(6, 4, new Pieces.Pawn(ChessBoardColor.Black, boardSquares[6, 4]));
            addPiece(6, 5, new Pieces.Pawn(ChessBoardColor.Black, boardSquares[6, 5]));
            addPiece(6, 6, new Pieces.Pawn(ChessBoardColor.Black, boardSquares[6, 6]));
            addPiece(6, 7, new Pieces.Pawn(ChessBoardColor.Black, boardSquares[6, 7]));
        }

        private void addPiece(int x, int y, Piece piece)
        {
            if(piece.pieceColor == ChessBoardColor.White)
            {
                whitePieces.Add(piece);
            } else
            {
                blackPieces.Add(piece);
            }

            boardSquares[x, y].squarePiece = piece;
        }

        // Finds the possible moves for all pieces on the board
        private void findPossibleMoves()
        {
            // Calculate possible moves for white
            for(int i = 0; i < whitePieces.Count; i++)
            {
                // For the specific piece calculate possible moves for each move type
                for (int j = 0; j < whitePieces.ElementAt(i).pieceMoveType.Count; j++)
                {
                    Square currentPieceSquare = whitePieces.ElementAt(i).pieceSquare;
                    ChessBoardNotation squareNotation = currentPieceSquare.squareNotation;
                    Tuple<int, int> currentMoveType = whitePieces.ElementAt(i).pieceMoveType.ElementAt(j);
                    // ASCII arithmetic to convert column letter to number, i.e. a = 1
                    int currentColumnNumber = squareNotation.ToString()[0] - 96;
                    int currentRowNumber = squareNotation.ToString()[1] - 48;
                    ChessBoardFileNumber newColumnLetter = (ChessBoardFileNumber)Enum.Parse(typeof(ChessBoardFileNumber), (currentColumnNumber + currentMoveType.Item2).ToString());
                    String newRowNumber = (currentRowNumber + currentMoveType.Item1).ToString();
                    ChessBoardNotation move = (ChessBoardNotation)Enum.Parse(typeof(ChessBoardNotation), newColumnLetter + newRowNumber);
                    if (Enum.IsDefined(typeof(ChessBoardNotation), move))
                    {
                        whitePieces.ElementAt(i).piecePossibleMoves.Add(move);
                    }

                }
            }
        }
        
        public String getMoves()
        {
            String retString = "";
            for(int i = 0; i < whitePieces.ElementAt(0).piecePossibleMoves.Count; i++)
            {
                retString += whitePieces.ElementAt(0).piecePossibleMoves.ElementAt(i);
            }
            return retString;
        }
        private Boolean validateMove(String move)
        {
            return true;
        }

        public override string ToString()
        {
            String retString = "";
            // TODO: Find better way to get x, y length of 2D array
            for (int i = 0; i < boardSquares.Length / 8; i++)
            {
                for(int j = 0; j < boardSquares.Length / 8; j++)
                {
                    Square tempSquare = boardSquares[i, j];
                    String squareColor = tempSquare.squareColor == ChessBoardColor.Black ? "B" : "W";
                    retString +=  squareColor + tempSquare.squarePiece + tempSquare.squareNotation + " | ";
                }
                retString += '\n';
            }
            return retString;
        }
    }
}
