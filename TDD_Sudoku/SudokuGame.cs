// See https://aka.ms/new-console-template for more information
internal class SudokuGame
{
    public SudokuGame()
    {
    }

    internal void Play()
    {
        PrintBoard();
    }

    internal void PrintBoard()
    {
        int[,] board = new int[9, 9];

        for (int row = 0; row < 9; row++)
        {
            for (int col = 0; col < 9; col++)
            {
                Console.Write(board[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}