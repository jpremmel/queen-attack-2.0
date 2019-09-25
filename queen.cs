using System;

namespace Chess
{
  class Queen
  {
    private int _row;
    private int _col;
    public Queen(int row, int col)
    {
      _row = row;
      _col = col;
    }

    public int GetRow()
    {
      return _row;
    }

    public int GetCol()
    {
      return _col;
    }

    public bool CanAttack(int x, int y)
    {
      bool canAttack = false;

      if (x == _row || y == _col)
      {
        canAttack = true;
      }
      else if (Math.Abs((x - _row)/(y - _col)) == 1)
      {
        canAttack = true;
      }
      return canAttack;
    }

  }
  
}