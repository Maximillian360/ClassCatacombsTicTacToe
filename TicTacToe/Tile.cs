namespace TicTacToe;

public class Tile
{
    private int X { get; set; }
    private int Y { get; set; }
    public char Glyph { get; set; }
    public Tile(int x, int y, char glyph)
    {
        X = x;
        Y = y;
        Glyph = glyph;
    }
}