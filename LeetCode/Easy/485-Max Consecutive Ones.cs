using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution485
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int max = 0;
            int count = 0;
            foreach (var num in nums)
            {
                if (num == 1)
                {
                    count++;
                }
                else
                {
                    max = Math.Max(max, count);
                    count = 0;
                }
            }

            max = Math.Max(max, count);


            return max;
        }
    }
}
