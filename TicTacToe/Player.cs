namespace TicTacToe;

public class Player
{
    // private int _playerConvertedInput = -1;
    // private string _playerStringInput = String.Empty;
    // public string PlayerStringInput 
    // { 
    //     get => _playerStringInput; 
    //     set
    //     {
    //         _playerStringInput = value?.Trim() ?? String.Empty;
    //         TryConvertInput(_playerStringInput);
    //     }
    // }
    //
    // public int PlayerConvertedInput
    // {
    //     get => _playerConvertedInput;
    // }

    public int TryConvertInput()
    {
        string? input = "";
        Console.WriteLine("Please enter a number between 1 and 9.");
        input = Console.ReadLine();
        int number = -1;
        if (string.IsNullOrEmpty(input))
        {
            throw new ArgumentNullException(nameof(input), $"Input cannot be null or empty.");
        }
        input = input.Trim();
        if (!int.TryParse(input, out number))
        {
            throw new FormatException($"Input must be an integer.");
        }
        if (number < 1 || number > 9)
        {
            throw new ArgumentOutOfRangeException(nameof(input), $"Input must be between 1 and 9.");
        }
        return number;
    }

    // public Player(string initialPlayerInput)
    // {
    //     PlayerStringInput = initialPlayerInput;
    // }
}