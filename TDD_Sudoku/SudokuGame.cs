// See https://aka.ms/new-console-template for more information
internal class SudokuGame
{
    internal int[,] board = new int[9, 9];

    public SudokuGame()
    {
    }

    internal void Play()
    {
        var temp = GenerateBoard();
        if (temp)
        {
            PrintBoard();
        }
    }

    internal void PrintBoard()
    {
        for (var row = 0; row < 9; row++)
        {
            for (int col = 0; col < 9; col++)
            {
                Console.Write(board[row, col] + " ");
            }
            Console.WriteLine();
        }
    }

    private bool GenerateBoard()
    {
        for (var row = 0; row < 9; row++)
        {
            for (var col = 0; col < 9; col++)
            {
                if (board[row, col] == 0)
                {
                    for (var num = 1; num <= 9; num++)
                    {
                        if (IsValid(row, col, num))
                        {
                            board[row, col] = num;

                            if (GenerateBoard())
                            {
                                return true;
                            }

                            board[row, col] = 0;
                        }
                    }
                    return false;
                }
            }
        }
        return true;
    }

    private bool IsValid(int row, int col, int num)
    {
        for (int i = 0; i < 9; i++)
        {
            if (board[row, i] == num || board[i, col] == num)
            {
                return false;
            }
        }

        int boxStartRow = row - row % 3;
        int boxStartCol = col - col % 3;

        for (int i = boxStartRow; i < boxStartRow + 3; i++)
        {
            for (int j = boxStartCol; j < boxStartCol + 3; j++)
            {
                if (board[i, j] == num)
                {
                    return false;
                }
            }
        }

        return true;
    }
}