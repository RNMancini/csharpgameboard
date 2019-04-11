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
    ticTacToe.drawboard();
    Console.WriteLine();
    //ConnectFour.drawboard();
    connect4.drawBoard();
  }
}

public class GameBoard
{
  public int height;
  public int width;

  public GameBoard(int height, int width)
  {
    this.height = height;
    this.width = width;
  }

  public static void drawboard(int height, int width)
  {
    for (int row = 0; row < height; row++)
    {
      for (int column = 0; column < width; column++)
      {
        Console.WriteLine(".");
      }
      Console.WriteLine();
    }
  }
}

public class Game
{
  String[,] board { get; set; }
}
public static class ConnectFour
{
  public static int height = 6;
  public static int width = 7;

}

}