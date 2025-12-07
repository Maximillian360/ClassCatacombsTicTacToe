namespace TicTacToe;

public class Player
{
    private int _playerConvertedInput = -1;
    private string _playerStringInput = String.Empty;
    public string PlayerStringInput 
    { 
        get => _playerStringInput; 
        set
        {
            _playerStringInput = value?.Trim() ?? String.Empty;
            TryConvertInput(_playerStringInput);
        }
    }

    public int PlayerConvertedInput
    {
        get => _playerConvertedInput;
    }

    public bool TryConvertInput(string? input)
    {
        int number = -1;
        if (string.IsNullOrEmpty(input)) return false;
        input = input.Trim();
        if (!int.TryParse(input, out number)) return false;
        if (number < 1 || number > 9) return false;
        _playerConvertedInput = number;
        return true;

    }

    public Player(string initialPlayerInput)
    {
        PlayerStringInput = initialPlayerInput;
    }
}
    
