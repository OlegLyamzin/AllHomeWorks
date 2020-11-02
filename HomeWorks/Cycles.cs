using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks
{
    public class Cycles
    {
        static public int RaiseToPower(int a, int b)
        {
            int c = 1;


            for (int i = 0; i < b; i++)
            {
                c *= a;
            }
            return c;
        }

        static public int[] GetDivisibleNumbers(int a)
        {
            int count = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % a == 0)
                {
                    count++;
                }
            }

            int[] numbers = new int[count];
            int j = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % a == 0)
                {
                    numbers[j] = i;
                    j++;
                }
            }
            return numbers;
        }

        static public int GetQuantitySmallerSquare(int a)
        {

            int c = 0;
            for (int i = 1; (i * i) < a; i++)
            {
                c++;
            }
            return c;
        }

        static public int GetGreatestDivisor(int a)
        {
            int b = 0;
            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    b = i;
                }
            }
            return b;
        }

        static public int GetSumOfDivisibleBy7(int from, int to)
        {
            int sum = 0;

            if (to < from)
            {
                int tmp = from;
                from = to;
                to = tmp;
            }

            for (int i = from; i <= to; i++)
            {
                if (i % 7 == 0)
                    sum += i;
            }
            return sum;
        }

        static public int GetFibonacciNumber(int n)
        {

            int x = 1;
            int prev1 = 1;
            int prev2 = 1;
            for (int i = 2; i < n; i++)
            {
                x = prev1 + prev2;
                prev1 = prev2;
                prev2 = x;
            }
            return x;
        }

        static public int GetGreatestCommonDivisor(int a, int b)
        {
            if (a < b)
            {
                int tmp = a;
                a = b;
                b = tmp;
            }

            if (a % b == 0)
            {
                return b;
            }
            else
            {
                while (a != 0 && b != 0)
                {
                    if (a > b)
                    {
                        a = a % b;
                    }
                    else
                    {
                        b = b % a;
                    }
                }
                return a + b;
            }
        }

        static public int GetCubicRoot(int n)
        {
            double startSegment;
            double endSegment;
            double midSegment;
            startSegment = 1;
            endSegment = n;
            midSegment = (startSegment + endSegment) / 2;
            for (int i = 0; i < 100; i++)
            {
                double fStartSegment;
                double fMidSegment;
                fStartSegment = Math.Pow(n, 1.0 / 3.0) - startSegment;
                fMidSegment = Math.Pow(n, 1.0 / 3.0) - midSegment;
                if (fMidSegment * fStartSegment <= 0)
                {
                    endSegment = midSegment;
                    midSegment = (startSegment + endSegment) / 2;
                }
                else
                {
                    startSegment = midSegment;
                    midSegment = (startSegment + endSegment) / 2;
                }
            }
            return (int)Math.Round(startSegment);
        }

        static public int GetQuantityOddDigits(int a)
        {
            int s = 0;
            while (a != 0)
            {
                if (a % 2 == 1)
                    s++;
                a /= 10;
            }
            return s;
        }

        static public int GetMirrorNumber(int a)
        {
            int b;
            int res = 0;
            int l = 0;
            b = a;
            while (b != 0)
            {
                l++;
                b /= 10;
            }
            for (int i = l; i > 0; i--)
            {
                res += (a % 10) * (int)Math.Pow(10, i - 1);
                a /= 10;
            }
            return res;
        }

        static public int GetQuantityEvenMoreOddDigits(int to)
        {
            int s = 0;
            for (int i = 1; i <= to; i++)
            {
                int a = i;
                int odd = 0;
                int even = 0;
                while (a != 0)
                {
                    if (a % 2 == 0)
                    {
                        even += a % 10;
                    }
                    else
                    {
                        odd += a % 10;
                    }
                    a /= 10;
                }
                if (even > odd)
                {
                    s++;
                }

            }
            return s;
        }

        static public bool IsNumbersWithSameDigits(int a, int b)
        {
            bool isExist = false;


            do
            {
                int c = a % 10;
                int bTemp = b;
                do
                {
                    if (bTemp % 10 == c)
                    {
                        isExist = true;
                    }
                    bTemp /= 10;
                } while (bTemp != 0);
                a /= 10;
            } while (a != 0);
            return isExist;
        }
    }
}
