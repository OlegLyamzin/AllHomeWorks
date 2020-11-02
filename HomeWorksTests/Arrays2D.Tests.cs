using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorksTests
{
    class Arrays2D
    {
        [TestCase(1, 1)]
        [TestCase(2, 3)]
        public void GetMinimum(int nMock, int expected)
        {
            int[,] array = GetArrayMock(nMock);
            int actual = HomeWorks.Arrays2D.GetMinimum(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 9)]
        [TestCase(2, 678)]
        public void GetMaximum(int nMock, int expected)
        {
            int[,] array = GetArrayMock(nMock);
            int actual = HomeWorks.Arrays2D.GetMaximum(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] { 0, 0 })]
        [TestCase(2, new int[] { 0, 6 })]
        public void GetIndexofMinimum(int nMock, int[] expected)
        {
            int[,] array = GetArrayMock(nMock);
            int[] actual = HomeWorks.Arrays2D.GetIndexOfMinimum(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] { 2, 2 })]
        [TestCase(2, new int[] { 1, 6 })]
        public void GetIndexofMaximum(int nMock, int[] expected)
        {
            int[,] array = GetArrayMock(nMock);
            int[] actual = HomeWorks.Arrays2D.GetIndexOfMaximum(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(2, 6)]
        public void GetQuantityBiggerNumberWithNeighbours(int nMock, int expected)
        {
            int[,] array = GetArrayMock(nMock);
            int actual = HomeWorks.Arrays2D.GetQuantityBiggerNumberWithNeighbours(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(2, 2)]
        public void Transpose(int nMock, int nExpectedMock)
        {
            int[,] array = GetArrayMock(nMock);
            int[,] expected = GetExpectedMock(nExpectedMock);
            int[,] actual = HomeWorks.Arrays2D.Transpose(array);
            Assert.AreEqual(expected, actual);
        }

        private int[,] GetExpectedMock(int n)
        {
            switch (n)
            {
                case 1:
                    return new int[,]
                    {
                        {1,4,7 },
                        {2,5,8 },
                        {3,6,9 }
                    };
                case 2:
                    return new int[,]
                    {
                        {4, 435,456},
                        { 43,4,34},
                        { 234,87,564},
                        { 23,657,324},
                        { 43,34,45},
                        { 32,65,23},
                        { 3,678,45}
                    };
                default:
                    throw new IndexOutOfRangeException();
            }
        }

        public int[,] GetArrayMock(int n)
        {
            switch (n)
            {
                case 1:
                    return new int[,]
                    {
                        {1,2,3 },
                        {4,5,6 },
                        {7,8,9 }
                    };
                case 2:
                    return new int[,]
                    {
                        {4,  43,234,23, 43,32,3 },
                        {435,4, 87, 657,34,65,678 },
                        {456,34,564,324,45,23,45 }
                    };
                default:
                    throw new IndexOutOfRangeException();
            }
        }
    }
}
