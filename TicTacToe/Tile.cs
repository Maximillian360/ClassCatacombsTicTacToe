namespace TicTacToe;

public class Tile
{
    // private int X { get; set; }
    // private int Y { get; set; }
    public CellState Glyph { get; private set; }
    public Tile(CellState glyph = CellState.None)
    {
        Glyph = glyph;
    }
}