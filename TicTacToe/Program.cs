// See https://aka.ms/new-console-template for more information

using TicTacToe;


Console.WriteLine("Hello, World!");
Player player1 = new Player(CellState.X);
Player player2 = new Player(CellState.O);
Player[] players = {player1, player2 };
Map map = new Map();
Game game = new Game(players, map);
game.GamePlay();