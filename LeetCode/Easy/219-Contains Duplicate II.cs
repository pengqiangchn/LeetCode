using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution219
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            //双循环 效率太慢
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = i + 1; j <= i + k && j < nums.Length; j++)
            //    {
            //        if (nums[i] == nums[j])
            //        {
            //            return true;
            //        }
            //    }
            //}

            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    if (i - dic[nums[i]] <= k)
                    {
                        return true;
                    }
                    //else
                    //{
                    //    dic[nums[i]] = i;
                    //}
                }
                //else
                //{
                //    dic.Add(nums[i], i);
                //}

                dic[nums[i]] = i;
            }

            return false;
        }
    }
}
