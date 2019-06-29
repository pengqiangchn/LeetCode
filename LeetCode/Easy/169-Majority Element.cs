using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution169
    {
        //最快速就是投票法
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    dic[nums[i]]++;
                }
                else
                {
                    dic.Add(nums[i], 1);
                }
            }

            int count = nums.Length / 2;
            int maxValue = int.MinValue;
            int maxValueKey = 0;
            foreach (var item in dic)
            {
                if (maxValue < item.Value)
                {
                    maxValue = item.Value;
                    maxValueKey = item.Key;
                }

                if (item.Value > count)
                {
                    return item.Key;
                }
            }

            return maxValueKey;
        }
    }
}
