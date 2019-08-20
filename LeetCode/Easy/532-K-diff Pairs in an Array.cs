using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution532
    {
        public int FindPairs(int[] nums, int k)
        {
            if (k < 0)
                return 0;

            int count = 0;
            Dictionary<int, int> dic = new Dictionary<int, int>();

            List<int> list = new List<int>(nums);
            int num = 0;
            int Length = list.Count;

            for (int i = 0; i < Length; i++)
            {
                num = list[i];

                list.RemoveAt(i);

                if (list.IndexOf(num + k) > -1)
                {
                    //if (dic.ContainsKey(num) && dic[num] == num + k)
                    //    continue;

                    //if (dic.ContainsKey(num + k) && dic[num + k] == num)
                    //    continue;

                    if (!dic.ContainsKey(num) || dic[num] != num + k)
                    {
                        count++;
                        dic[num] = num + k;
                    }
                }
                list.Insert(i, num);
            }

            return count;
        }
    }
}
