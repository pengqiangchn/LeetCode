using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution268
    {
        public int MissingNumber(int[] nums)
        {
            //需使用额外常数空间。不是n空间。。
            int sum = 0;
            sum = (0 + nums.Length) * (nums.Length + 1) / 2;
            for (int i = 0; i < nums.Length; i++)
            {
                sum -= nums[i];
            }

            return sum;







            //HashSet<int> hash = new HashSet<int>();
            //int max = int.MinValue;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (!hash.Contains(nums[i]))
            //    {
            //        hash.Add(nums[i]);
            //    }

            //    max = Math.Max(max, nums[i]);
            //}

            //for (int i = 0; i <= max + 1; i++)
            //{
            //    if (!hash.Contains(i))
            //        return i;
            //}

            //return -1;
        }
    }
}
