using HomeWorks;
using NUnit.Framework;

namespace HomeWorksTests
{
    public class Variables
    {
        [TestCase(1, 2, 9.0)]
        [TestCase(9, 7, -47.0)]
        [TestCase(6, 2, -8.5)]
        public void SolveExpression(int a, int b, double expected)
        {
            double actual = HomeWorks.Variables.SolveExpression(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2,2)]
        public void SolveExpressionNegative(int a, int b)
        {
            try
            {
                HomeWorks.Variables.SolveExpression(a, b);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(11, 5, new int[] { 2, 1 })]
        [TestCase(15, 5, new int[] { 3, 0 })]
        [TestCase(17, 3, new int[] { 5, 2 })]
        public void GetResultAndModuloOfDivision(int a, int b, int[] expected)
        {
            int[] actual = HomeWorks.Variables.GetResultAndModuloOfDivision(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(17, 0)]
        public void GetResultAndModuloOfDivisionNegative(int a, int b)
        {
            try
            {
                HomeWorks.Variables.GetResultAndModuloOfDivision(a, b);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(6, 3, 12, 1.5)]
        [TestCase(5, 5, 15, 2.0)]
        [TestCase(8, 5, 29, 3.0)]
        public void GetResultLinearEquation(int a, int b, int c, double expected)
        {
            double actual = HomeWorks.Variables.GetResultLinearEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 5, 29)]
        public void GetResultLinearEquationNegative(int a, int b, int c)
        {
            try
            {
                HomeWorks.Variables.GetResultLinearEquation(a, b, c);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(6.0, -2.0, 3.0, 4.0, "y = -2x + 10")]
        [TestCase(2.0, 5.0, 7.0, 0.0, "y = -1x + 7")]
        [TestCase(4.0, 1.0, 12.0, 12.0, "y = 1,375x - 4,5")]
        public void GetEquationOfLine(double x1, double y1, double x2, double y2,string expected)
        {
            string actual = HomeWorks.Variables.GetEquationOfLine(x1, y1, x2, y2);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(4.0, 1.0, 4.0, 12.0)]
        public void GetEquationOfLineNegative(double x1, double y1, double x2, double y2)
        {
            try
            {
                HomeWorks.Variables.GetEquationOfLine(x1, y1, x2, y2);

            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

    }
}