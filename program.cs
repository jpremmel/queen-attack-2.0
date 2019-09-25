using System;
using Chess;
class Program
{
  static void Main()
  {
    Console.WriteLine("Enter the current row for the queen:");
    int queenRow = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the current column for the queen:");
    int queenCol = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the current row for the pawn:");
    int pawnRow = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the current column for the pawn:");
    int pawnCol = int.Parse(Console.ReadLine());

    // //Jacqueline's abandoned attempt at drying up the code above//
    // int queenRow = 0;
    // int queenCol = 0;
    // int pawnRow = 0;
    // int pawnCol = 0;
    // int[] coordinates = { queenRow, queenCol, pawnRow, pawnCol };
    // Dictionary<string, int> chessCoords = new Dictionary<string, int>() { {"queenRow", 0}, {"queenCol", 0}, {"pawnRow", 0}, {"pawnCol", 0}};
    // string[,] chessSetup = new string[,] { {"queen", "row"}, {"queen", "column"}, {"pawn", "row"}, {"pawn", "column"}};
    // for (int i = 0; i < 4; i++)
    // {
    //   Console.WriteLine("Enter the current " + chessSetup[i, 0] + " " + chessSetup[i, 1]);
    //   chessCoords = int.Parse(Console.ReadLine());
    // }

    if (queenRow == pawnRow && queenCol == pawnCol)
    {
      Console.WriteLine("The queen and the pawn cannot be on the same space, try again.");
      Main();
    }
    else
    {
      Queen queen = new Queen(queenRow, queenCol);
      bool attacked = queen.CanAttack(pawnRow, pawnCol);

      if (attacked)
      {
        Console.WriteLine("The queen can attack the pawn.");
      }
      else 
      {
        Console.WriteLine("The queen cannot attack the  pawn.");
     }
    }
  }
}