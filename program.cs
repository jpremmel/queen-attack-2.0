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