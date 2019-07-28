using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution506
    {
        public string[] FindRelativeRanks(int[] nums)
        {
            List<string> list = new List<string>();

            //Array.Sort(nums);

            //int count = 1;
            //for (int i = nums.Length - 1; i >= 0; i++)
            //{
            //    if (count == 1)
            //    {
            //        list.Add("Gold Medal");
            //    }
            //    else if (count == 2)
            //    {
            //        list.Add("Silver Medal");
            //    }
            //    else if (count == 3)
            //    {
            //        list.Add("Bronze Medal");
            //    }
            //    else
            //    {
            //        list.Add(count.ToString());
            //    }
            //    count++;
            //}

            if (nums.Length == 0)
                return new string[] { };

            if (nums.Length == 1)
            {
                return new string[] { "Gold Medal" };
            }

            if (nums.Length == 2)
            {
                return new string[] { "Gold Medal", "Silver Medal" };
            }

            list = new List<string>() { "Gold Medal", "Silver Medal", "Bronze Medal" };

            for (int i = 3; i < nums.Length; i++)
            {
                list.Add((i + 1).ToString());
            }

            return list.ToArray();
        }

    }
}
