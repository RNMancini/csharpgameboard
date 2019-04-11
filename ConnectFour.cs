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

  public void drawboard()
  {
    for (int row = 0; row < height; row++)
    {
      for (int part = 0; part < 3; part++)
      {
        for (int column = 0; column < width; column++)
        {
          switch ()
          {
            case 0:
              Console.Write("+-+");
              break;
            case 1:
              Console.Write("| |");
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

  public class Game
  {
    public String[,] board { get; set; }
    //public String player1;
    //public String player2;
    //public int[][] playerOne;
  }
  public static class ConnectFour
  {
    public static int height = 6;
    public static int width = 7;

    public static void drawBoard()
  }

}