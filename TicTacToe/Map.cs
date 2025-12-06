namespace TicTacToe;

public class Map
{
    Tile[,] Board {get; set;}
    int Rows {get; set;}
    int Cols {get; set;}

    public Map()
    {
        Rows = 3;
        Cols = 3;
        Board = new Tile[Rows, Cols];
    }

    public bool TileIsInside(int row, int col)
    {
        return row >= 0 && row < Rows && col >= 0 && col < Cols;
    }

    public Tile? GetTile(int row, int col)
    {
        return TileIsInside(row, col) ? Board[row, col] : null;
    }

    private bool TileIsOccupied(int row, int col)
    {
        return Board[row, col] != null;
    }
    
}