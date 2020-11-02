using System;
using HomeWorks;

namespace AllHomeWorks
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(Conditions.GetWitingOfNumber(25));
      double a = Variables.SolveExpression(3, 7);
            int[] ab = Arrays2D.GetIndexOfMaximum(new int[,]
                          {
                        {4,  43,234,23, 43,32,3 },
                        {435,4, 87, 657,34,65,678 },
                        {456,34,564,324,45,23,45 }
                          });
    }

  }
}
