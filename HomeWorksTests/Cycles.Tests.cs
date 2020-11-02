using HomeWorks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorksTests
{
    class Cycles
    {

        [TestCase(2, 2, 4)]
        [TestCase(5, 10, 9765625)]
        [TestCase(0, 2, 0)]
        [TestCase(10, 0, 1)]
        public void RaiseToPower(int a, int b, int expected)
        {
            int actual = HomeWorks.Cycles.RaiseToPower(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(333, new int[] { 333, 666, 999 })]
        [TestCase(173, new int[] { 173, 346, 519, 692, 865 })]
        [TestCase(250, new int[] { 250, 500, 750, 1000 })]
        public void GetDivisibleNumbers(int a, int[] expected)
        {
            int[] actual = HomeWorks.Cycles.GetDivisibleNumbers(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(26, 5)]
        [TestCase(6327, 79)]
        [TestCase(3845, 62)]
        public void GetQuantitySmallerSquare(int a, int expected)
        {
            int actual = HomeWorks.Cycles.GetQuantitySmallerSquare(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(69, 23)]
        [TestCase(750, 375)]
        [TestCase(999, 333)]
        public void GetGreatestDivisor(int a, int expected)
        {
            int actual = HomeWorks.Cycles.GetGreatestDivisor(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(346, 367, 1071)]
        [TestCase(367, 346, 1071)]
        [TestCase(7, -14, -14)]
        public void GetSumOfDivisibleBy7(int from, int to, int expected)
        {
            int actual = HomeWorks.Cycles.GetSumOfDivisibleBy7(from, to);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(38, 39088169)]
        [TestCase(19, 4181)]
        [TestCase(11, 89)]
        public void GetFibonacciNumber(int n, int expected)
        {
            int actual = HomeWorks.Cycles.GetFibonacciNumber(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(36, 54, 18)]
        [TestCase(34, 68, 34)]
        [TestCase(16, 56, 8)]
        public void GetGreatestCommonDivisor(int a, int b, int expected)
        {
            int actual = HomeWorks.Cycles.GetGreatestCommonDivisor(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(970299, 99)]
        [TestCase(91125, 45)]
        [TestCase(175616, 56)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void GetCubicRoot(int n,int expected)
        {
            int actual = HomeWorks.Cycles.GetCubicRoot(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(970299, 4)]
        [TestCase(91125, 4)]
        [TestCase(175616, 4)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 0)]
        public void GetQuantityOddDigits(int a,int expected)
        {
            int actual = HomeWorks.Cycles.GetQuantityOddDigits(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(970299, 992079)]
        [TestCase(91125, 52119)]
        [TestCase(175616, 616571)]
        [TestCase(0, 0)]
        [TestCase(111, 111)]
        [TestCase(2, 2)]
        public void GetMirrorNumber(int a, int expected)
        {
            int actual = HomeWorks.Cycles.GetMirrorNumber(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(24, 12)]
        [TestCase(174, 72)]
        [TestCase(5, 2)]
        public void GetQuantityEvenMoreOddDigits(int to, int expected)
        {
            int actual = HomeWorks.Cycles.GetQuantityEvenMoreOddDigits(to);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(24, 12, true)]
        [TestCase(174, 72, true)]
        [TestCase(0, 0, true)]
        [TestCase(5, 2, false)]
        [TestCase(3423, 76867, false)]
        public void IsNumbersWithSameDigits(int a, int b, bool expected)
        {
            bool actual = HomeWorks.Cycles.IsNumbersWithSameDigits(a, b);
            Assert.AreEqual(expected, actual);
        }


    }
}
