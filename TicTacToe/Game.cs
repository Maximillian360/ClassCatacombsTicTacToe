namespace TicTacToe;

public class Game
{
    private Player Player { get; set; }

    Game(Player player)
    {
        Player = player;
    }
}