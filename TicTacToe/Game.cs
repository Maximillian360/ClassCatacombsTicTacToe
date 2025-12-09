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
                break;
            }
            
        }
    }

    public (int, int) PlayerInputConverter()
    {
        int row = (Player[TurnIndex].PlayerConvertedInput - 1) / Map.Cols;
        int col = (Player[TurnIndex].PlayerConvertedInput - 1) % Map.Cols;
        return (row, col);
    }

    public void GameRender()
    {
        
    }
    
    public void SwitchTurnIndicator() => TurnIndex = (TurnIndex == 0) ? 1 : 0;
    
}

public enum GameState
{
    InProgress,
    Won,
    Draw
}