using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution441
    {
        public int ArrangeCoins(int n)
        {
            int i = (int)Math.Sqrt(2.0 * n);

            while (i <= n)
            {
                if ((long)(1 + i) * i / 2 == n)
                {
                    return i;
                }
                else if ((long)(1 + i) * i / 2 > n)
                {
                    return i - 1;
                }
                i++;
            }

            return i;
        }
    }
}
