using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution122
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 0)
                return 0;
            int inPrice = int.MinValue;
            int sub = 0;
            for (int i = prices.Length - 1; i >= 0; i--)
            {
                if ((i > 0) && (prices[i] > prices[i - 1]))
                {
                    inPrice = Math.Max(inPrice, prices[i]);
                }
                else
                {
                    if (inPrice != int.MinValue)
                    {
                        sub += inPrice - prices[i];
                        inPrice = int.MinValue;
                    }
                }
            }

            return sub;

        }
    }
}
