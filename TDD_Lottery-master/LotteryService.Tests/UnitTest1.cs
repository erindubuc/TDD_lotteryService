using NUnit.Framework;
using LotteryService;
using System;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        LotteryNumbers _testService = new LotteryNumbers();

        [Test]
        public void Return_Array()
        {
            int[]lotteryNumbers0 = new int[0];
            var output = _testService.SortNumbers(lotteryNumbers0);
            Assert.AreEqual(new int[0],output);
        }

        [Test]
        public void Return_OneNumSorted()
        {
            int[] lotteryNumbers1 = new int[1];

            // store what I expect in a test result into a variable
            var actual = _testService.SortNumbers(lotteryNumbers1);
            Assert.AreEqual(new int[1], actual);
        }

        [Test]
        public void Return_TwoNumsSorted()
        {
            int[] lotteryNums2 = new int[2] { 5, 1 };
            int[] actual = _testService.SortNumbers(lotteryNums2);
            Assert.AreEqual(new int[2] { 1, 5 }, actual);
        }

        [Test]
        public void Return_ThreeNumsSorted()
        {
            int[] lotteryNumbers3 = new int[3] { 10, 5, 1 };
            int[] actual = _testService.SortNumbers(lotteryNumbers3);
            Assert.AreEqual(new int[3] { 1, 5, 10 }, actual);
        }

        [Test]
        public void Return_TenNumsSorted()
        {
            int[] lotteryNums4 = new int[10] { 37, 10, 4, 7, 81, 8, 12, 14, 18, 23 };
            int[] actual = _testService.SortNumbers(lotteryNums4);
            Assert.AreEqual(new int[10] { 4, 7, 8, 10, 12, 14, 18, 23, 37, 81 }, actual);
        }

        /*
        [Test]
        public void Return_TwoNumsSorted()
        {
            int[] lotteryNumbers2 = new int[2] { 5, 1 };
            int[] actual = _testService.SortNumbers(lotteryNumbers2);
            Assert.AreEqual(new int[2] { 1, 5 }, actual);
        }

        [Test]
        public void Return_ThreeNumsSorted()
        {
            int[] lotteryNumbers3 = new int[3] { 5, 1, 10 };
            int[] actual = _testService.SortNumbers(lotteryNumbers3);
            //Make it fail first by passing wrong order
            //Assert.AreEqual(new int[3] { 5, 1, 10 }, actual);
            Assert.AreEqual(new int[3] { 1, 5, 10 }, actual);
        }

        [Test]
        public void Return_TenNumsSorted()
        {
            int[] lotteryNums4 = new int[10] { 37, 10, 4, 7, 81, 8, 12, 14, 18, 23 };
            int[] actual = _testService.SortNumbers(lotteryNums4);
            Assert.AreEqual(new int[10] { 4, 7, 8, 10, 12, 14, 18, 23, 37, 81 }, actual);
        }
        */
    }
}