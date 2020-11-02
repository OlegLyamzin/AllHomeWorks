using System;
using System.Reflection.Metadata;

namespace HomeWorks
{
    public class Variables
    {

        static public double SolveExpression(int a, int b)
        {
            if (a == b)
            {
                throw new Exception("Parameter a can't be equal b");
            }

            return (double)(5 * a + (b * b)) / (b - a);
        }

        static public int[] GetResultAndModuloOfDivision(int a, int b)
        {
            if (b == 0)
            {
                throw new Exception("Parameter b can't be 0");
            }
            int[] results = new int[2];
            results[0] = a / b;
            results[1] = a % b;
            return results;
        }

        static public double GetResultLinearEquation(int a, int b, int c)
        {
            if (a == 0)
            {
                throw new Exception("Parameter a can't be 0");
            }
            return (double)(c - b) / a;
        }

        static public string GetEquationOfLine(double x1, double y1, double x2, double y2)
        {
            if (x2 == x1)
            {
                throw new Exception("Parameter x1 can't be equal x2");
            }
            double a;
            double b;
            a = (y2 - y1) / (x2 - x1);
            b = y1 - (x1 * a);
            if (b < 0)
            {
                return $"y = {a}x - {-b}";
            }
            return $"y = {a}x + {b}";
        }
    }


}
