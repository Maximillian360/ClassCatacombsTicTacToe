namespace TicTacToe;

public class Player
{
    private string PlayerInput { get; set; }
    public Player(string playerInput)
    {
        //Validate here if PlayerInput is null or invalid
        PlayerInput = playerInput;
    }
    
}