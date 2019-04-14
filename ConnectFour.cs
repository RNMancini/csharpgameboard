using System;

public class Program
{
  public static void Main()
  {
    //GameBoard myBoard = new GameBoard();
    //GameBoard secondBoard = new GameBoard();
    //myBoard.drawBoard(3, 3);
    //GameBoard.drawBoard(3, 3);
    //GameBoard.drawBoard(6, 7);

    GameBoard ticTacToe = new GameBoard(3, 3);
    GameBoard connect4 = new GameBoard(6, 7);
    //ticTacToe.drawboard();
    Game myGame = new Game(6, 7);
    connect4.drawBoard(myGame);
    Move myMove = new Move(new[] { 5, 3 }, "@");
    myGame.applyMove(myMove);
    Console.WriteLine();
    connect4.drawboard(myGame);
    Move oopMove = new Move(new Move[] { 1, 6 }, "#");
    myGame.applyMove(oopMove);
    Console.WriteLine();
    connect4.drawboard(myGame);
  }
}

public class GameBoard
{
  public int height
  {
    get;
    set;
  }
  public int width
  {
    get;
    set;
  };

  public GameBoard(int height, int width)
  {
    this.height = height;
    this.width = width;
  }

  public void drawboard(Game aGame)
  {
    for (int row = 0; row < height; row++)
    {
      for (int part = 0; part < 3; part++)
      {
        for (int column = 0; column < width; column++)
        {
          switch (part)
          {
            case 0:
            case 1:
              Console.Write("|{0}|", aGame.board[row, column]);
              break;
            case 2:
              Console.Write("+-+");
              break;
          }
        }
        Console.WriteLine();
      }
    }
  }
}
public class Game
{
  public String[,] board
  {
    get;
    set;
  }
  public Game(int height, int width)
  {
    this.board = new String[height, width];
    for (int row = 0; row < height; row++)
    {
      for (int column = 0; column < width; column++)
      {
        this.board[row, column] = " ";
      }
    }
  }
  public void applyMove(Move move)
  {
    this.board[move.location[0], move.location[1]] = move.player;
  }

  public void debug_display()
  {
    for (int row = 0; row < this.board.GetLength(0); row++)
    {
      for (int column = 0; column < this.board.GetLength(1); column++)
      {
        Console.Write(board[row, column] == " " ? "." : board[row, column]);
      }
      Console.Write();
    }
  }
}

public class Move
{
  public int[] location
  {
    get;
    set;
  }
  public String player
  {
    get;
    set;
  }

  public Move(int[] location, String player)
  {
    this.location = location;
    this.player = player;
  }
}