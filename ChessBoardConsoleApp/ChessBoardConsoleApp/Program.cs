using ChessBoardModel;
using System;

namespace ChessBoardConsoleApp
{
    class Program
    {
        static Board myBoard = new Board(8);
        static void Main(string[] args)
        {
            printGrid(myBoard);

            string chessPiece = selectChessPiece();

            Cell myLocation = setCurrentCell();

            myBoard.MarkNextLegalMoves(myLocation, chessPiece);

            printGrid(myBoard);

            Console.ReadLine();
        }

        static public string selectChessPiece()
        {
            Console.WriteLine("Select a chess piece: ");
            Console.WriteLine("1. Knight");
            Console.WriteLine("2. King");
            Console.WriteLine("3. Rook");
            Console.WriteLine("4. Bishop");
            Console.WriteLine("5. Queen");

            int choice;
            while (true)
            {
                Console.Out.Write("Enter your choice (1-5): ");
                string inputChoice = Console.ReadLine();

                if (int.TryParse(inputChoice, out choice))
                {
                    if (choice >= 1 && choice <= 5)
                    {
                        break;
                    }
                }

                Console.WriteLine("Invalid choice. Please enter a valid integer between 1 and 5.");
            }

            switch (choice)
            {
                case 1:
                    return "Knight";
                case 2:
                    return "King";
                case 3:
                    return "Rook";
                case 4:
                    return "Bishop";
                case 5:
                    return "Queen";
                default:
                    return "";
            }
        }

        static public void printGrid(Board myBoard)
        {
            Console.WriteLine("Here is the chessboard:");
            Console.WriteLine();
            Console.WriteLine("   A B C D E F G H");
            Console.WriteLine(" +-----------------+");

            for (int i = 0; i < myBoard.Size; i++)
            {
                Console.Write($"{i + 1}| ");
                for (int j = 0; j < myBoard.Size; j++)
                {
                    if (myBoard.theGrid[i, j].CurrentlyOccupied)
                    {
                        Console.Write("X ");
                    }
                    else if (myBoard.theGrid[i, j].LegalNextMove)
                    {
                        Console.Write("+ ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine("|");
            }

            Console.WriteLine(" +-----------------+");
        }

        static public Cell setCurrentCell()
        {
            int currentRow, currentCol;

            while (true)
            {
                Console.Out.Write("Enter your current row number (0-7): ");
                string inputRow = Console.ReadLine();

                Console.Out.Write("Enter your current column number (0-7): ");
                string inputCol = Console.ReadLine();

                if (int.TryParse(inputRow, out currentRow) && int.TryParse(inputCol, out currentCol))
                {
                    if (currentRow >= 0 && currentRow <= 7 && currentCol >= 0 && currentCol <= 7)
                    {
                        myBoard.theGrid[currentRow, currentCol].CurrentlyOccupied = true;
                        return myBoard.theGrid[currentRow, currentCol];
                    }
                }

                Console.WriteLine("Invalid input. Please enter valid integer values between 0 and 7 for row and column numbers.");
            }
        }
    }
}
