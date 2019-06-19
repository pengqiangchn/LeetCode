using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution069
    {
        public int MySqrt(int x)
        {
            if (x <= 0)
                return 0;

            //首先判断区间范围;
            int length = x.ToString().Length;
            int a = length / 2;
            int max = 1;
            for (int i = 0; i < a; i++)
            {
                max *= 10;
            }
            if (length % 2 > 0)
            {
                max *= 5;
            }

            if (max > 46341)
            {
                max = 46341;
            }

            //max *= max;
            int min = max / 2;
            int temp = 0;
            while (max > min)
            {
                if (x > min * min)
                {
                    temp = min;
                    min = (max + min) / 2;
                }
                else if (x < min * min)
                {
                    max = min;
                    min = (max + temp) / 2;
                    temp = 0;
                }
                else
                {
                    break;
                }

                if (x > min * min && max - min == 1)
                {
                    break;
                }
            }


            return min;
        }
    }
}
