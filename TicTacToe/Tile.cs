namespace TicTacToe;

public class Tile
{
    // private int X { get; set; }
    // private int Y { get; set; }
    public char Glyph { get; private set; }
    public Tile(char glyph = '_')
    {
        Glyph = glyph;
    }
}