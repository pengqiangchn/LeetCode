using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution258
    {
        public int AddDigits(int num)
        {
            if (num < 9)
                return num;

            if (num % 9 != 0)
            {
                return num % 9;
            }
            else
            {
                return 9;
            }
        }
    }
}
