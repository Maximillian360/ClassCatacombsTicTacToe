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
            Console.WriteLine("Input cannot be null or empty!");
            return null;
        }
        input = input.Trim();
        if (!int.TryParse(input, out number))
        {
            Console.WriteLine("Input must be an integer.");
            return null;
        }
        if (number < 1 || number > 9)
        {
            Console.WriteLine("Input must be between 1 and 9.");
            return null;
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