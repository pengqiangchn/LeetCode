using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution172
    {

        public int TrailingZeroes(int n)
        {
            //数有多少个5整除;

            int count = 0;
            //通过了但是速度太慢
            //int x = 1;
            //for (int i = 5; i <= n; i += 5)
            //{
            //    if (i % 5 == 0)
            //    {
            //        x = i;
            //        while (x != 0)
            //        {
            //            count++;
            //            x = x / 5;
            //            if (x % 5 != 0)
            //            {
            //                x = 0;
            //            }
            //        }
            //    }
            //}
            while (n >= 5)
            {
                count += n / 5;
                n = n / 5;
            }

            return count;
        }
    }
}
