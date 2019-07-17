using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution349
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            List<int> num = new List<int>();
            HashSet<int> hash = new HashSet<int>();

            //哈希表自动去重
            foreach (var item in nums1)
            {
                hash.Add(item);
            }            

            foreach (var item in nums2)
            {
                if (hash.Contains(item))
                {
                    num.Add(item);
                    hash.Remove(item);
                    if (hash.Count == 0)
                        break;
                }
            }

            return num.ToArray();
        }
    }
}
