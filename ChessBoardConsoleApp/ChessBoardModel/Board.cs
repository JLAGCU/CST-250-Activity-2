using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardModel
{
    public class Board
    {
        public int Size { get; set; }

        public Cell[,] theGrid;

        public Board(int s)
        {
            Size = s;

            theGrid = new Cell[Size, Size];
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j] = new Cell(i, j);
                }
            }
        }

        private bool IsValidCell(int row, int col)
        {
            return row >= 0 && row < Size && col >= 0 && col < Size;
        }


        public void MarkNextLegalMoves(Cell currentCell, string chessPiece)
        {
                for (int r = 0; r < Size; r++)
                {
                    for (int c = 0; c < Size; c++)
                    {
                        theGrid[r, c].LegalNextMove = false;
                    }
                }

                switch (chessPiece)
                {
                    case "Knight":
                        int[] rowOffsets = { -2, -2, -1, -1, 1, 1, 2, 2 };
                        int[] colOffsets = { -1, 1, -2, 2, -2, 2, -1, 1 };

                        for (int i = 0; i < rowOffsets.Length; i++)
                        {
                            int newRow = currentCell.RowNumber + rowOffsets[i];
                            int newCol = currentCell.ColumnNumber + colOffsets[i];

                            if (IsValidCell(newRow, newCol))
                            {
                                theGrid[newRow, newCol].LegalNextMove = true;
                            }
                        }
                        break;

                    case "King":
                        int[] rowOffsetsKing = { -1, -1, -1, 0, 0, 1, 1, 1 };
                        int[] colOffsetsKing = { -1, 0, 1, -1, 1, -1, 0, 1 };

                        for (int i = 0; i < rowOffsetsKing.Length; i++)
                        {
                            int newRow = currentCell.RowNumber + rowOffsetsKing[i];
                            int newCol = currentCell.ColumnNumber + colOffsetsKing[i];

                            if (IsValidCell(newRow, newCol))
                            {
                                theGrid[newRow, newCol].LegalNextMove = true;
                            }
                        }
                        break;
                    case "Rook":
                        // Check upward moves
                        for (int r = currentCell.RowNumber - 1; r >= 0; r--)
                        {
                            if (!IsValidCell(r, currentCell.ColumnNumber))
                                break;

                            theGrid[r, currentCell.ColumnNumber].LegalNextMove = true;
                        }

                        // Check downward moves
                        for (int r = currentCell.RowNumber + 1; r < Size; r++)
                        {
                            if (!IsValidCell(r, currentCell.ColumnNumber))
                                break;

                            theGrid[r, currentCell.ColumnNumber].LegalNextMove = true;
                        }

                        // Check left moves
                        for (int c = currentCell.ColumnNumber - 1; c >= 0; c--)
                        {
                            if (!IsValidCell(currentCell.RowNumber, c))
                                break;

                            theGrid[currentCell.RowNumber, c].LegalNextMove = true;
                        }

                        // Check right moves
                        for (int c = currentCell.ColumnNumber + 1; c < Size; c++)
                        {
                            if (!IsValidCell(currentCell.RowNumber, c))
                                break;

                            theGrid[currentCell.RowNumber, c].LegalNextMove = true;
                        }
                        break;
                    case "Bishop":
                        // Check upward-left moves
                        for (int r = currentCell.RowNumber - 1, c = currentCell.ColumnNumber - 1; r >= 0 && c >= 0; r--, c--)
                        {
                            if (!IsValidCell(r, c))
                                break;

                            theGrid[r, c].LegalNextMove = true;
                        }

                        // Check upward-right moves
                        for (int r = currentCell.RowNumber - 1, c = currentCell.ColumnNumber + 1; r >= 0 && c < Size; r--, c++)
                        {
                            if (!IsValidCell(r, c))
                                break;

                            theGrid[r, c].LegalNextMove = true;
                        }

                        // Check downward-left moves
                        for (int r = currentCell.RowNumber + 1, c = currentCell.ColumnNumber - 1; r < Size && c >= 0; r++, c--)
                        {
                            if (!IsValidCell(r, c))
                                break;

                            theGrid[r, c].LegalNextMove = true;
                        }

                        // Check downward-right moves
                        for (int r = currentCell.RowNumber + 1, c = currentCell.ColumnNumber + 1; r < Size && c < Size; r++, c++)
                        {
                            if (!IsValidCell(r, c))
                                break;

                            theGrid[r, c].LegalNextMove = true;
                        }
                        break;
                    case "Queen":
                        // Check vertical moves (upward and downward)
                        for (int r = currentCell.RowNumber - 1; r >= 0; r--)
                        {
                            if (!IsValidCell(r, currentCell.ColumnNumber))
                                break;

                            theGrid[r, currentCell.ColumnNumber].LegalNextMove = true;
                        }

                        for (int r = currentCell.RowNumber + 1; r < Size; r++)
                        {
                            if (!IsValidCell(r, currentCell.ColumnNumber))
                                break;

                            theGrid[r, currentCell.ColumnNumber].LegalNextMove = true;
                        }

                        // Check horizontal moves (leftward and rightward)
                        for (int c = currentCell.ColumnNumber - 1; c >= 0; c--)
                        {
                            if (!IsValidCell(currentCell.RowNumber, c))
                                break;

                            theGrid[currentCell.RowNumber, c].LegalNextMove = true;
                        }

                        for (int c = currentCell.ColumnNumber + 1; c < Size; c++)
                        {
                            if (!IsValidCell(currentCell.RowNumber, c))
                                break;

                            theGrid[currentCell.RowNumber, c].LegalNextMove = true;
                        }

                        // Check diagonal moves (up-left)
                        for (int r = currentCell.RowNumber - 1, c = currentCell.ColumnNumber - 1; r >= 0 && c >= 0; r--, c--)
                        {
                            if (!IsValidCell(r, c))
                                break;

                            theGrid[r, c].LegalNextMove = true;
                        }

                        // Check diagonal moves (up-right)
                        for (int r = currentCell.RowNumber - 1, c = currentCell.ColumnNumber + 1; r >= 0 && c < Size; r--, c++)
                        {
                            if (!IsValidCell(r, c))
                                break;

                            theGrid[r, c].LegalNextMove = true;
                        }

                        // Check diagonal moves (down-left)
                        for (int r = currentCell.RowNumber + 1, c = currentCell.ColumnNumber - 1; r < Size && c >= 0; r++, c--)
                        {
                            if (!IsValidCell(r, c))
                                break;

                            theGrid[r, c].LegalNextMove = true;
                        }

                        // Check diagonal moves (down-right)
                        for (int r = currentCell.RowNumber + 1, c = currentCell.ColumnNumber + 1; r < Size && c < Size; r++, c++)
                        {
                            if (!IsValidCell(r, c))
                                break;

                            theGrid[r, c].LegalNextMove = true;
                        }
                        break;
                    default:
                        break;
                }
        }
    }
}
