using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks
{
    public class Conditions
    {
        static public int CompareAndCount(int a, int b)
        {
            if (a > b)
                return a + b;
            else if (a == b)
                return a * b;
            else
                return a - b;
        }

        static public int GetQuarter(int x, int y)
        {
            if (x > 0 && y > 0)
                return 1;
            else if (x < 0 && y > 0)
                return 2;
            else if (x < 0 && y < 0)
                return 3;
            else if (x > 0 && y < 0)
                return 4;
            else
                return 0;
        }

        static public int[] Sort(int a, int b, int c)
        {
            int[] sorted = new int[3];
            if (a < b && a < c)
            {
                if (b < c)
                {
                    sorted[0] = a;
                    sorted[1] = b;
                    sorted[2] = c;
                }
                else
                {

                    sorted[0] = a;
                    sorted[1] = c;
                    sorted[2] = b;
                }
            }
            else if (b < a && b < c)
            {
                if (a < c)
                {

                    sorted[0] = b;
                    sorted[1] = a;
                    sorted[2] = c;
                }
                else
                {

                    sorted[0] = b;
                    sorted[1] = c;
                    sorted[2] = a;
                }
            }
            else if (a < b)
            {

                sorted[0] = c;
                sorted[1] = a;
                sorted[2] = b;
            }
            else
            {

                sorted[0] = c;
                sorted[1] = b;
                sorted[2] = a;
            }
            return sorted;
        }

        static public double[] SolveQuadraticEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new Exception("Parameter can't be 0");
            }
            double disc;
            disc = b * b - 4 * a * c;

            if (disc < 0)
            {
                return new double[0];
            }
            else if (disc == 0)
            {
                return new double[] { (-b + Math.Sqrt(disc)) / (2 * a) };
            }
            else
            {
                return new double[]
                { (-b + Math.Sqrt(disc)) / (2 * a),
          (-b - Math.Sqrt(disc)) / (2 * a) };

            }
        }

        static public string GetWitingOfNumber(int a)
        {
            int tmp;
            string res = "";
            tmp = a % 10;
            switch (tmp)
            {
                case 1:
                    res = " один";
                    break;
                case 2:
                    res = " два";
                    break;
                case 3:
                    res = " три";
                    break;
                case 4:
                    res = " четыре";
                    break;
                case 5:
                    res = " пять";
                    break;
                case 6:
                    res = " шесть";
                    break;
                case 7:
                    res = " семь";
                    break;
                case 8:
                    res = " восемь";
                    break;
                case 9:
                    res = " девять";
                    break;

            }
            a = a / 10;
            if (a % 10 == 1)
            {
                switch (tmp)
                {
                    case 1:
                        res = "одиннадцать";
                        break;
                    case 2:
                        res = "двенадцать";
                        break;
                    case 3:
                        res = "тринадцать";
                        break;
                    case 4:
                        res = "четырнадцать";
                        break;
                    case 5:
                        res = "пятнадцать";
                        break;
                    case 6:
                        res = "шестнадцать";
                        break;
                    case 7:
                        res = "семнадцать";
                        break;
                    case 8:
                        res = "восемнадцать";
                        break;
                    case 9:
                        res = "девятнадцать";
                        break;
                    case 0:
                        res = "десять";
                        break;

                }
            }
            else
            {
                switch (a % 10)
                {

                    case 2:
                        res = "двадцать" + res;
                        break;
                    case 3:
                        res = "тридцать" + res;
                        break;
                    case 4:
                        res = "сорок" + res;
                        break;
                    case 5:
                        res = "пятьдесят" + res;
                        break;
                    case 6:
                        res = "шестьдесят" + res;
                        break;
                    case 7:
                        res = "семьдесят" + res;
                        break;
                    case 8:
                        res = "восемьдесят" + res;
                        break;
                    case 9:
                        res = "девяносто" + res;
                        break;

                }
            }
            return res;
        }
    }
}
