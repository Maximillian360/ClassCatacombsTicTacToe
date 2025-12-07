namespace TicTacToe;

public class Game
{
    public Player Player { get; private set; }
    public Map Map { get; private set; }
    public GameState GameState { get; private set; }

    Game(Player player, Map map)
    {
        Player = player;
        Map = map;
        GameState = GameState.InProgress;
    }

    public void Play(Player player1, Player player2)
    {
        //Check if valid move (TileIsInside, TileIsOccupied
    }

    public (int, int) PlayerInputConverter()
    {
        //Implement player's input from numbers 1-9 to (x, y)
        int row = (Player.PlayerInputConverted - 1) / Map.Cols;
        int col = (Player.PlayerInputConverted - 1) % Map.Cols;
        return (row, col);
    }
}

public enum GameState
{
    InProgress,
    Won,
    Draw
}