namespace TicTacToe;

public class Player
{
    private string _playerInput = String.Empty;
    private static int _number = 0;

    public string PlayerInput
    {
        get => _playerInput;
        set
        {
            if (InputIsNotNull(value) && InputIsInteger(value) && InputIsWithinNumberRange(_number))
            {
                _playerInput = value;
            }
        }
    }
    public Player(string playerInput)
    {
        PlayerInput = playerInput;
    }

    private static bool InputIsNotNull(string? input)
    {
        return !string.IsNullOrWhiteSpace(input);
    }

    private static bool InputIsInteger(string input)
    {
        return int.TryParse(input, out _number);
    }

    private static bool InputIsWithinNumberRange(int input)
    {
        return input >= 0 && input <= 9;
    }
    
    
}