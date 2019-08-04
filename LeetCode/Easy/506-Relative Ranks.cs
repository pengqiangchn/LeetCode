using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution506
    {
        public string[] FindRelativeRanks(int[] nums)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            List<int> numsList = new List<int>(nums);
            numsList.Sort();
            numsList.Reverse();

            List<string> list = new List<string>();

            for (int i = 0; i < numsList.Count; i++)
            {
                if (i == 0)
                {
                    dic[numsList[i]] = "Gold Medal";
                }
                else if (i == 1)
                {
                    dic[numsList[i]] = "Silver Medal";
                }
                else if (i == 2)
                {
                    dic[numsList[i]] = "Bronze Medal";
                }
                else
                {
                    dic[numsList[i]] = (i + 1).ToString();
                }
            }

            foreach (var num in nums)
            {
                list.Add(dic[num]);
            }

            return list.ToArray();
        }

    }
}
