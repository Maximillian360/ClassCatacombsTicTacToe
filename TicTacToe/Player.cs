namespace TicTacToe;

public class Player
{
    private string _playerStringInput = String.Empty;
    private static int _number = 0;

    public string PlayerStringInput
    {
        get => _playerStringInput;
        set
        {
            if (InputIsNotNull(value) && InputIsInteger(value) && InputIsWithinNumberRange(_number))
            {
                _playerStringInput = value;
            }
        }
    }

    public int PlayerInputConverted
    {
        get => _number; 
        
    }
    public Player(string playerStringInput)
    {
        PlayerStringInput = playerStringInput;
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