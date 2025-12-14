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
        if (GetTile(row, col) != null)
        {
            Console.WriteLine("Tile is occupied.");
            return;
        }
        _board[row, col] = glyph;
        
        
        
        //TODO: This method actualizes a player's move. Validate first if move is within bounds and is unoccupied.
    }
    
    public bool CheckWinner(int row, int col)
    {
        //TODO: Determine if a move results in a win.
        
        return false;
    }
    
    public bool CheckDraw(int row, int col)
    {
        //TODO: Determine if a move results in a draw, where map is already filled but no win is flagged.
        return false;
    }

   
}