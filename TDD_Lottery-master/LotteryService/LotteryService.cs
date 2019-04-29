using System;

namespace LotteryService
{
    public class LotteryNumbers
    {
        public int[] SortNumbers(int[] lotteryNums)
        {
            //throw new NotImplementedException();
            //Array.Sort(lotteryNums);
            for (int outerLoopLotteryNums = 0; outerLoopLotteryNums < lotteryNums.Length; outerLoopLotteryNums++)
            {
                for (int indexInLotteryNums = 0; indexInLotteryNums < lotteryNums.Length - 1; indexInLotteryNums++)
                {
                    if (lotteryNums[indexInLotteryNums] > lotteryNums[indexInLotteryNums + 1])
                    {
                        int temp = lotteryNums[indexInLotteryNums];
                        lotteryNums[indexInLotteryNums] = lotteryNums[indexInLotteryNums + 1];
                        lotteryNums[indexInLotteryNums + 1] = temp;
                        
                    }
 
                }

            }

            return lotteryNums;
        }   
    }
}

