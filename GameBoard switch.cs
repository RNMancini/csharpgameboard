Using System;
public class Program
{
  public static void Main()
  {
    //Console.WriteLine("Hello");
    GameBoardticTacToeBoard = new GameBoard(3,3);
    GameBoard connect4Board = new GameBoard(6, 7);
    //GameBoard.drawBoard(3, 3);
    ticTacToeBoard.drawboard();
  }
}

public class GameBoard(int height, int width)
{
  public int height {get; set;}
  public int width {get; set;}

  public GameBoard(int height, int width)
  {
    for (int row = 0)
  }
}