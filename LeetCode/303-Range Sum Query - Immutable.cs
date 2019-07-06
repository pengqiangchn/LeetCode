using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution303
    { 
        //使用字典，然后将每个编号进行保存，
        //这样的话就只使用一次就能够算出所有的值，以后多次调用也不需要重复计算了
        private int[] _nums;
        public Solution303(int[] nums)
        {
            _nums = nums;
        }

        public int SumRange(int i, int j)
        {
            if (j >= _nums.Length)
                return 0;
            int sum = 0;

            for (int index = i; index <= j; index++)
            {
                sum += _nums[index];
            }
            return sum;
        }
    }
}
