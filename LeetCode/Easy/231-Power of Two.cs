using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution231
    {
        public bool IsPowerOfTwo(int n)
        {
            //使用位运算
            return n > 0 && ((n & (n - 1)) == 0);

            //if (n < 0)
            //    return false;

            //string str = Convert.ToString(n, 2);
            //int count = 0;
            //foreach (var item in str)
            //{
            //    if (item == '1')
            //    {
            //        count++;
            //    }

            //    if (count > 1)
            //        break;
            //}

            //return count == 1;
        }
    }
}
