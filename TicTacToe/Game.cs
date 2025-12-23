namespace TicTacToe;

public class Game
{
    public Player[] Player { get; private set; }
    public Map Map { get; private set; }
    public GameState GameState { get; private set; }
    private int MoveCounter { get; set; }
    private int TurnIndex { get; set; }
    public Player? Winner {get; set;}

    public Game(Player[] player, Map map)
    {
        Player = player;
        Map = map;
        GameState = GameState.InProgress;
        MoveCounter = 1;
        Winner = null;
    }

    public void GamePlay()
    {
        string gameOverText = "";
        while (true)
        {
            if (GameState == GameState.Won || GameState == GameState.Draw)
            {
                Console.WriteLine($"\nGame Over: {gameOverText}");
                GameRender();
                break;
            }
            Console.Clear();
            GameRender();
            (int, int) playerInput = PlayerInputConverter();
            Map.PlayTile(playerInput.Item1, playerInput.Item2, Player[TurnIndex].Glyph);
            bool hasWinner = Map.CheckWin(playerInput.Item1, playerInput.Item2,  Player[TurnIndex].Glyph);
            bool gameDraw = Map.CheckDraw(MoveCounter, hasWinner);
            MoveCounter++;
            if (hasWinner)
            {
                GameState = GameState.Won;
                gameOverText = $"Player {TurnIndex} Won!";
                Winner = Player[TurnIndex];
            }
            if (gameDraw)
            {
                gameOverText = "Game Draw!";
                GameState = GameState.Draw;
            }
            SwitchTurnIndicator();
        }
    }

    private (int, int) PlayerInputConverter()
    {
        int? numberInput = null;
        while (numberInput == null)
        {
            numberInput = Player[TurnIndex].TryConvertInput();
        }
        int number = numberInput.Value;
        int row = (number - 1) / Map.Cols;
        int col = (number - 1) % Map.Cols;
        return (row, col);
    }

    public void GameRender()
    {
        Console.WriteLine($"Game: {GameState}, Current Turn: {MoveCounter}");
        for (int i = 0; i < Map.Cols; i++)
        {
            for (int j = 0; j < Map.Rows; j++)
            {
                Console.Write($" |{Map.GetTile(i, j)}| ");
            }
            Console.WriteLine();
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