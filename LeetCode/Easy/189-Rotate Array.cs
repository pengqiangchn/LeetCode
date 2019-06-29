using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution189
    {
        public void Rotate(int[] nums, int k)
        {
            if (k % nums.Length == 0)
                return;

            k = k % nums.Length;
            ////俩个循环的话太慢了
            //for (int i = 0; i < k; i++)
            //{
            //    for (int j = nums.Length - 1; j > 0; j--)
            //    {
            //        temp = nums[(j + 1) % nums.Length];
            //        nums[(j + 1) % nums.Length] = nums[j];
            //        nums[j] = temp;
            //    }
            //}

            Array.Reverse(nums);
            Array.Reverse(nums, 0, k);
            Array.Reverse(nums, k, nums.Length - k);


        }
    }
}
