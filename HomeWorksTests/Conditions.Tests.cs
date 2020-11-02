using HomeWorks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorksTest
{
    class Conditions
    {
        [TestCase(5, 4, 9)]
        [TestCase(900, 345, 1245)]
        [TestCase(1, -30, -29)]
        [TestCase(5, 5, 25)]
        [TestCase(4, 4, 16)]
        [TestCase(1, 1, 1)]
        [TestCase(4, 5, -1)]
        [TestCase(10, 15, -5)]
        [TestCase(1, 13, -12)]
        public void  CompareAndCount(int a, int b, int expected)
        {
            int actual = HomeWorks.Conditions.CompareAndCount(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 7, 1)]
        [TestCase(900, 345, 1)]
        [TestCase(-5, 5, 2)]
        [TestCase(-4, 4, 2)]
        [TestCase(-4, -5, 3)]
        [TestCase(-10, -15, 3)]
        [TestCase(1, -13, 4)]
        [TestCase(133, -234, 4)]
        [TestCase(0, 13, 0)]
        [TestCase(-1, 0, 0)]
        public void GetQuarter(int x, int y, int expected)
        {
            int actual = HomeWorks.Conditions.GetQuarter(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 13, 0, new int[] {0,0,13 })]
        [TestCase(0, -13, 15, new int[] { -13, 0, 15 })]
        [TestCase(-10, 13, 15, new int[] { -10, 13, 15 })]
        public void Sort(int a, int b, int c, int[] expected)
        {
            int[] actual = HomeWorks.Conditions.Sort(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, 1, new double[] { -1 })]
        [TestCase(10, 2, 1, new double[0])]
        [TestCase(1, 6, 2.75, new double[] {  -0.5 ,- 5.5})]
        public void SolveQuadraticEquation(double a, double b, double c, double[] expected)
        {
            double[] actual = HomeWorks.Conditions.SolveQuadraticEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 1, 2)]
        [TestCase(0, 3, 7)]
        [TestCase(0, 4, 2)]
        public void SolveQuadraticEquationNegative(double a, double b, double c)
        {
            try
            {
                HomeWorks.Conditions.SolveQuadraticEquation(a, b, c);

            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(25, "двадцать пять")]
        [TestCase(99, "девяносто девять")]
        [TestCase(15, "пятнадцать")]
        [TestCase(20, "двадцать")]
        [TestCase(10, "десять")]
        public void GetWitingOfNumber(int a, string expected)
        {
            string actual = HomeWorks.Conditions.GetWitingOfNumber(a);
            Assert.AreEqual(expected, actual);
        }
    }
}
