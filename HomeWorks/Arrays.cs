using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks
{
    public class Arrays
    {
        static public int[] Copy(int[] array)
        {
            int[] b = new int[array.Length];
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = array[i];
            }
            return b;
        }

        static public int GetMinimum(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }

        static public int GetMaximum(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

        static public int GetIndexOfMinimum(int[] array)
        {
            int minIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[minIndex])
                {
                    minIndex = i;
                }
            }

            return minIndex;
        }

        static public int GetIndexOfMaximum(int[] array)
        {
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        static public int GetSumElementsWithOddIndex(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 1)
                {
                    sum += array[i];
                }
            }
            return sum;
        }

        static public int[] Reverse(int[] array)
        {
            int[] a = Copy(array);
            for (int i = 0; i < (a.Length / 2); i++)
            {
                int indexFromEnd = a.Length - i - 1;
                int tmp = a[i];
                a[i] = a[indexFromEnd];
                a[indexFromEnd] = tmp;
            }
            return a;
        }

        static public int GetQuantityOfOddElements(int[] array)
        {
            int quantity = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    quantity++;
                }
            }
            return quantity;
        }

        static public int[] SwapHalfArray(int[] array)
        {
            int[] a = Copy(array);
            for (int i = 0; i < (a.Length / 2); i++)
            {
                int indexFromMiddle;

                if (a.Length % 2 == 0)
                    indexFromMiddle = a.Length / 2 + i;
                else
                    indexFromMiddle = a.Length / 2 + i + 1;

                int tmp = a[i];
                a[i] = a[indexFromMiddle];
                a[indexFromMiddle] = tmp;
            }
            return a;
        }

        static public int[] SortBubble(int[] array)
        {
            int[] a = Copy(array);
            for (int j = a.Length - 1; j > 0; j--)
            {
                int indexMin = j;
                for (int i = 0; i < j; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        int tmp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = tmp;
                    }
                }
            }
            return a;
        }

        static public int[] SortInsert(int[] array)
        {
            int[] a = Copy(array);
            for (int i = 1; i < a.Length; i++)
            {

                for (int j = i; j > 0 && a[j - 1] < a[j]; j--)
                {

                    int tmp = a[j];
                    a[j] = a[j - 1];
                    a[j - 1] = tmp;

                }
            }
            return a;
        }

    }
}
