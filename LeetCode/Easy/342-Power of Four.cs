using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution342
    {
        public bool IsPowerOfFour(int num)
        {
            return num > 0 && (num & (num - 1)) == 0 && (num - 1) % 3 == 0;
        }
    }
}
