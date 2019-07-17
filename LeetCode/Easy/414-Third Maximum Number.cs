using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution414
    {
        public int ThirdMax(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            HashSet<int> hash = new HashSet<int>();

            int first = int.MinValue;
            int second = int.MinValue;
            int third = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (hash.Contains(nums[i]))
                {
                    continue;
                }
                else
                {
                    hash.Add(nums[i]);

                    if (nums[i] > first)
                    {
                        third = second;
                        second = first;
                        first = nums[i];
                    }
                    else if (nums[i] > second)
                    {
                        third = second;
                        second = nums[i];
                    }
                    else if (nums[i] > third)
                    {
                        third = nums[i];
                    }
                }
            }

            if (hash.Count < 3)
            {
                return first;
            }
            else
            {
                return third;
            }
        }
    }
}
