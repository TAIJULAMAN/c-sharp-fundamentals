using System;

class LearnStringGrid
{
    static void Main()
    {
        string[,] board = {
            { "X", "O", "X" },
            { "O", "X", "O" },
            { "X", "O", "X" }
        };

        Console.WriteLine("Game Board:");

        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                Console.Write(board[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nCenter value: " + board[1, 1]);
    }
}