using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution136
    {
        //最快方法 使用位运算
        public int SingleNumber(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], 1);
                }
                else
                {
                    dic[nums[i]] = dic[nums[i]] + 1;
                }
            }

            foreach (var key in dic.Keys)
            {
                if (dic[key] == 1)
                    return key;
            }

            return nums[0];
        }
    }
}
