using HomeWorks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorksTests
{
    class Arrays
    {
        [TestCase(new int[] { 34, 345, 76, 234, 76, 435 }, 34)]
        [TestCase(new int[] { 567, 46, 1, 0, 234, 42335 }, 0)]
        [TestCase(new int[] { 436, 4, 21, 4, 0, 0 }, 0)]
        public void GetMinimum(int[] array, int expected)
        {
            int actual = HomeWorks.Arrays.GetMinimum(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 34, 345, 76, 234, 76, 435 }, 435)]
        [TestCase(new int[] { 567, 46, 1, 0, 234, 42335 }, 42335)]
        [TestCase(new int[] { 436, 4, 21, 4, 0, 0 }, 436)]
        public void GetMaximum(int[] array, int expected)
        {
            int actual = HomeWorks.Arrays.GetMaximum(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 34, 345, 76, 234, 76, 435 }, 0)]
        [TestCase(new int[] { 567, 46, 1, 0, 234, 42335 }, 3)]
        [TestCase(new int[] { 436, 4, 21, 4, 0, 0 }, 4)]
        public void GetIndexOfMinimum(int[] array, int expected)
        {
            int actual = HomeWorks.Arrays.GetIndexOfMinimum(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 34, 345, 76, 234, 76, 435 }, 5)]
        [TestCase(new int[] { 567, 46, 1, 0, 234, 42335 }, 5)]
        [TestCase(new int[] { 436, 4, 21, 4, 0, 0 }, 0)]
        public void GetIndexOfMaximum(int[] array, int expected)
        {
            int actual = HomeWorks.Arrays.GetIndexOfMaximum(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 34, 345, 76, 234, 76, 435 }, 1014)]
        [TestCase(new int[] { 0, 1 }, 1)]
        [TestCase(new int[] { 0, 0, 1 }, 0)]
        public void GetSumElementsWithOddIndex(int[] array, int expected)
        {
            int actual = HomeWorks.Arrays.GetSumElementsWithOddIndex(array);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 34, 345, 76, 234, 76, 435 }, new int[] { 435, 76, 234, 76, 345, 34 })]
        [TestCase(new int[] { 0, 1 }, new int[] { 1, 0 })]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6 }, new int[] { 6, 5, 4, 3, 2, 1, 0 })]
        public void Reverse(int[] array, int[] expected)
        {
            int[] actual = HomeWorks.Arrays.Reverse(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 34, 345, 76, 234, 76, 435 }, 2)]
        [TestCase(new int[] { 567, 46, 1, 0, 234, 42335 }, 3)]
        [TestCase(new int[] {  0 }, 0)]
        public void GetQuantityOfOddElements(int[] array, int expected)
        {
            int actual = HomeWorks.Arrays.GetQuantityOfOddElements(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 34, 345, 76, 234, 76, 435 }, new int[] { 234,76,435,34,345,76 })]
        [TestCase(new int[] { 0, 1 }, new int[] { 1, 0 })]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6 }, new int[] { 4,5,6,3,0,1,2 })]
        public void SwapHalfArray(int[] array,int[] expected)
        {
            int[] actual = HomeWorks.Arrays.SwapHalfArray(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 34, 345, 76, 234, 76, 435 }, new int[] { 34, 76,76,234,345,435 })]
        [TestCase(new int[] { 0, 1 }, new int[] { 0, 1 })]
        [TestCase(new int[] { 4, 5, 6, 3, 0, 1, 2 }, new int[] { 0, 1, 2, 3, 4, 5, 6 })]
        public void SortBubble(int[] array, int[] expected)
        {
            int[] actual = HomeWorks.Arrays.SortBubble(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 34, 345, 76, 234, 76, 435 }, new int[] { 435,345,234,76,76,34 })]
        [TestCase(new int[] { 0, 1 }, new int[] { 1,0 })]
        [TestCase(new int[] { 4, 5, 6, 3, 0, 1, 2 }, new int[] { 6,5,4,3,2,1,0})]
        public void SortInsert(int[] array, int[] expected)
        {
            int[] actual = HomeWorks.Arrays.SortInsert(array);
            Assert.AreEqual(expected, actual);
        }
    }
}
