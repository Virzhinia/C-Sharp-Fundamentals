using System;

namespace _02._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var boardSize = int.Parse(Console.ReadLine());
            var board = new char[boardSize, boardSize];

            for (int counterRow = 0; counterRow < boardSize; counterRow++)
            {
                var element = Console.ReadLine();
                for (int counterCol = 0; counterCol < boardSize; counterCol++)
                {
                    board[counterRow, counterCol] = element[counterCol];
                }
            }

            int maxRow = 0;
            int maxColumn = 0;
            int maxAttackedPositions = 0;
            int countOfRemovedKnights = 0;
            do
            {
            if(maxAttackedPositions>0)
                {
                    board[maxRow,maxColumn] = '0';
                    maxAttackedPositions = 0;
                    countOfRemovedKnights++;
                }

                int currentAttackPos = 0;

                for (int row = 0; row < boardSize; row++)
                {
                    for (int col = 0; col < boardSize; col++)
                    {
                        if(board[row,col] == 'K')
                        {
                            currentAttackPos = CalculateAttackedPositions(row, col, board);

                            if(currentAttackPos>maxAttackedPositions)
                            {
                                maxAttackedPositions = currentAttackPos;
                                maxRow = row;
                                maxColumn = col;
                            }
                        }
                    }
                }
            } while (maxAttackedPositions>0);

        }

         static int CalculateAttackedPositions(int row, int col, char[,] board)
        {
            var currentAtackPos = 0;
            if (IsPositionWithinBoard(row - 2, col - 1, board)) currentAtackPos++;
            if (IsPositionWithinBoard(row - 2, col - 1, board)) currentAtackPos++;
            if (IsPositionWithinBoard(row - 1, col - 1, board)) currentAtackPos++;
            if (IsPositionWithinBoard(row - 1, col - 1, board)) currentAtackPos++;
            if (IsPositionWithinBoard(row + 1, col - 1, board)) currentAtackPos++;
            if (IsPositionWithinBoard(row + 1, col + 2, board)) currentAtackPos++;
            if (IsPositionWithinBoard(row + 2, col - 1, board)) currentAtackPos++;
            if (IsPositionWithinBoard(row + 2, col + 1, board)) currentAtackPos++;

        }


        static bool IsPositionWithinBoard(int row, int col, int boardSize)
        {
            return row >= 0 && row < boardSize && col >= 0 && col < boardSize;
        }
    }
}
