using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution469
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            if (nums1.Length == 0)
                return nums1;

            List<int> list = new List<int>();

            Dictionary<int, int> dic = new Dictionary<int, int>() { };

            for (int i = 0; i < nums2.Length; i++)
            {
                int j = i + 1;
                for (; j < nums2.Length; j++)
                {
                    if (nums2[i] < nums2[j])
                    {
                        dic[nums2[i]] = nums2[j];
                        break;
                    }
                }
                if (j == nums2.Length)
                {
                    dic[nums2[i]] = -1;
                }
            }

            foreach (var num in nums1)
            {
                if (dic.ContainsKey(num))
                {
                    list.Add(dic[num]);
                }
            }

            return list.ToArray();
        }
    }
}
