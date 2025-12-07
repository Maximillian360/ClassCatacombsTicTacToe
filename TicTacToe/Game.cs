namespace TicTacToe;

public class Game
{
    private Player Player { get; set; }
    private Map Map { get; set; }

    Game(Player player, Map map)
    {
        Player = player;
        Map = map;
    }

    public void Play(Player player1, Player player2)
    {
        //Check if valid move (TileIsInside, TileIsOccupied
    }

    public (int, int) PlayerInputConverter()
    {
        //Implement player's input from numbers 1-9 to (x, y)
        while (true)
        {
            //placeholder
        }
       
    }
}