namespace TicTacToe;

public class Map
{
    // public Tile[,] Board {get; set;}
    private readonly CellState[,] _board;
    public int Rows {get; set;}
    public int Cols {get; set;}


    public Map()
    {
        Rows = 3;
        Cols = 3;
        _board = new CellState[Rows, Cols];
    }

    public bool TileIsInside(int row, int col)
    {
        return row >= 0 && row < Rows && col >= 0 && col < Cols;
    }

    public CellState? GetTile(int row, int col)
    {
        return TileIsInside(row, col) ? _board[row, col] : null;
    }
    
    public void PlayTile(int row, int col, CellState glyph)
    {
        if (!TileIsInside(row, col))
        {
            Console.WriteLine("Out of bounds.");
            return;
        }
        if (GetTile(row, col) != CellState.None)
        {
            Console.WriteLine("Tile is occupied.");
            return;
        }
        _board[row, col] = glyph;
        
    }
    public bool CheckWin(int row, int col, CellState glyph)
    {
        bool rowWin = true;
        bool colWin = true;
        bool diagonalWin = true;
        bool antiDiagonalWin = true;
        for (int i = 0; i < Rows; i++)
        {
            if (_board[row, i] != glyph) rowWin = false;
            if (_board[i, col] != glyph) colWin = false;
            if (diagonalWin && _board[i, i] != glyph) diagonalWin = false;
            if (antiDiagonalWin && _board[i, Rows - 1 - i] != glyph) antiDiagonalWin = false;
        }
        return rowWin || colWin ||  diagonalWin || antiDiagonalWin;
    }
    
    public bool CheckDraw(int moveCounter, bool hasWinner)
    {
        return moveCounter == 9 && !hasWinner;
    }

   
}