using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution724
    {
        public int PivotIndex(int[] nums)
        {
            if (nums.Length < 3)
                return -1;

            int right = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                right += nums[i];
            }

            if (right == 0)
                return 0;

            int left = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                right -= nums[i];
                if (left == right)
                    return i;
                left += nums[i];
            }

            return -1;

        }
    }
}
