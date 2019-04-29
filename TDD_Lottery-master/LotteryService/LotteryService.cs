using System;

namespace LotteryService
{
    public class LotteryNumbers
    {
        public int[] SortNumbers(int[] lotteryNums)
        {
            //throw new NotImplementedException();
            Array.Sort(lotteryNums);
            return lotteryNums;
        }
    }
}
