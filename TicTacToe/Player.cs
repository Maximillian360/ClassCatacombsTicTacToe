namespace TicTacToe;

public class Player
{
    public CellState Glyph { get; private set; }
    public Player(CellState playerGlyph =  CellState.None)
    {
        Glyph = playerGlyph;
    }
    public int? TryConvertInput()
    {
        string? input = "";
        Console.WriteLine("Please enter a number between 1 and 9.");
        input = Console.ReadLine();
        int number;
        if (string.IsNullOrEmpty(input))
        {
            return null;
            throw new ArgumentNullException(nameof(input), $"Input cannot be null or empty.");
        }
        input = input.Trim();
        if (!int.TryParse(input, out number))
        {
            return null;
            throw new FormatException($"Input must be an integer.");
        }
        if (number < 1 || number > 9)
        {
            return null;
            throw new ArgumentOutOfRangeException(nameof(input), $"Input must be between 1 and 9.");
        }
        return number;
    }


}


public enum CellState
{
    None,
    X,
    O
}