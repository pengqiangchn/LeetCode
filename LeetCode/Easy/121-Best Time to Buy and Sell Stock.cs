using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution121
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 0)
                return 0;

            int maxPrice = prices[prices.Length - 1];
            int tempSub = 0;
            int maxSub = 0;

            for (int i = prices.Length - 2; i >= 0; i--)
            {
                tempSub = maxPrice - prices[i];
                if (tempSub > 0)
                {
                    if (tempSub > maxSub)
                    {
                        maxSub = tempSub;
                    }
                }
                else
                {
                    maxPrice = prices[i];
                }
            }

            return maxSub;
        }
    }
}
