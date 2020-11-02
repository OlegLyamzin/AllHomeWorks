using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks
{
    public class Arrays2D
    {
        public static int[,] Copy(int[,] array)
        {
            int[,] copiedArray = new int[array.GetLength(0), array.GetLength(1)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    copiedArray[i, j] = array[i, j];
                }
            }
            return copiedArray;
        }
        public static int GetMinimum(int[,] array)
        {
            int[,] a = Copy(array);
            int minimum = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] < minimum)
                    {
                        minimum = a[i, j];
                    }
                }
            }
            return minimum;
        }
        public static int GetMaximum(int[,] array)
        {
            int[,] a = Copy(array);
            int maximum = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > maximum)
                    {
                        maximum = a[i, j];
                    }
                }
            }
            return maximum;
        }
        public static int[] GetIndexOfMinimum(int[,] array)
        {
            int[,] a = Copy(array);
            int minimumIndex1 = 0;
            int minimumIndex2 = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] < a[minimumIndex1, minimumIndex2])
                    {
                        minimumIndex1 = i;
                        minimumIndex2 = j;
                    }
                }
            }

            return new int[] { minimumIndex1, minimumIndex2 };
        }
        public static int[] GetIndexOfMaximum(int[,] array)
        {
            int[,] a = Copy(array);
            int maximumIndex1 = 0;
            int maximumIndex2 = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > a[maximumIndex1, maximumIndex2])
                    {
                        maximumIndex1 = i;
                        maximumIndex2 = j;
                    }
                }
            }

            return new int[] { maximumIndex1, maximumIndex2 };
        }
        public static int GetQuantityBiggerNumberWithNeighbours(int[,] array)
        {
            int[,] a = Copy(array);
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {

                    bool isBigger = true;
                    if ((i != 0 && a[i, j] < a[i - 1, j]) ||
                        (i != a.GetLength(0) - 1 && a[i, j] < a[i + 1, j]) ||
                        (j != 0 && a[i, j] < a[i, j - 1]) ||
                        (j != a.GetLength(1) - 1 && a[i, j] < a[i, j + 1])
                        )
                    {
                        isBigger = false;
                    }

                    if (isBigger)
                    {
                        sum++;
                        Console.WriteLine(i + " " + j + " " + a[i, j]);
                    }

                }
            }
            return sum;
        }
        public static int[,] Transpose(int[,] array)
        {
            int[,] b;
            b = new int[array.GetLength(1), array.GetLength(0)];
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    b[i, j] = array[j, i];

                }

            }
            return b;
        }
    }
}
