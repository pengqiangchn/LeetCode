using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution350
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            List<int> list = new List<int>();
            int[] num1 = nums1.Length < nums2.Length ? nums1 : nums2;
            int[] num2 = nums1.Length < nums2.Length ? nums2 : nums1;

            for (int i = 0; i < num1.Length; i++)
            {
                if (dic.ContainsKey(num1[i]))
                {
                    dic[num1[i]]++;
                }
                else
                {
                    dic[num1[i]] = 1;
                }
            }

            for (int i = 0; i < num2.Length; i++)
            {
                if (dic.ContainsKey(num2[i]))
                {
                    list.Add(num2[i]);
                    if (--dic[num2[i]] <= 0)
                    {
                        dic.Remove(num2[i]);
                        if (dic.Count == 0)
                        {
                            break;
                        }
                    }
                }
            }

            return list.ToArray();

        }
    }
}
