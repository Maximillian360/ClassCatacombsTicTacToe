namespace TicTacToe;

public class Map
{
    public Tile[,] Board {get; set;}
    public int Rows {get; set;}
    public int Cols {get; set;}

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
}