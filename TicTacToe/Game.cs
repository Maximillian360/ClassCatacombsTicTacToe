namespace TicTacToe;

public class Game
{
    public Player[] Player { get; private set; }
    public Map Map { get; private set; }
    public GameState GameState { get; private set; }
    private int MoveCounter { get; set; }
    private int TurnIndex { get; set; }

    Game(Player[] player, Map map)
    {
        Player = player;
        Map = map;
        GameState = GameState.InProgress;
        MoveCounter = 0;
    }

    public void Play(Player player1, Player player2)
    {
        while (true)
        {
            if (GameState == GameState.Won || GameState == GameState.Draw)
            {
                Console.WriteLine("Game over.");
                break;
            }
            
        }
    }

    public (int, int) PlayerInputConverter()
    {
        int row = (Player[TurnIndex].TryConvertInput() - 1) / Map.Cols;
        int col = (Player[TurnIndex].TryConvertInput() - 1) % Map.Cols;
        return (row, col);
    }

    public void GameRender()
    {
        for (int i = 0; i < Map.Cols; i++)
        {
            for (int j = 0; j < Map.Rows; j++)
            {
                Console.WriteLine($" |{Map.GetTile(i, j)}| ");
            }
        }
    }
    
    public void SwitchTurnIndicator() => TurnIndex = (TurnIndex == 0) ? 1 : 0;
    
}

public enum GameState
{
    InProgress,
    Won,
    Draw
}