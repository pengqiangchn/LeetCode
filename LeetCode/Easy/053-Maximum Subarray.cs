using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution053
    {
        //这个题目最快能用 动态规划。下次可以使用动态规划再解一遍

        public int MaxSubArray(int[] nums)
        {
            if (nums.Length == 0)
                return 0;


            //简单暴力的解法
            //类似冒泡 循环两次
            int max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                int temp = nums[i];
                if (max < temp)
                {
                    max = temp;
                }

                for (int j = i + 1; j < nums.Length; j++)
                {
                    temp += nums[j];
                    if (max < temp)
                    {
                        max = temp;
                    }
                }

            }


            return max;

        }
    }
}
