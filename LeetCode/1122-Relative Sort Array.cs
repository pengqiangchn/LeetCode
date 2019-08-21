using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution1122
    {
        public int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            List<int> list = new List<int>();
            Array.Sort(arr1);

            foreach (var item in arr1)
            {
                if (dic.ContainsKey(item))
                {
                    dic[item]++;
                }
                else
                {
                    dic[item] = 1;
                }
            }

            foreach (var num in arr2)
            {
                if (dic.ContainsKey(num))
                {
                    int count = dic[num];
                    for (int i = 0; i < count; i++)
                    {
                        list.Add(num);
                    }
                    dic.Remove(num);
                }
            }

            foreach (var key in dic.Keys)
            {
                int count = dic[key];
                for (int i = 0; i < count; i++)
                {
                    list.Add(key);
                }
            }

            return list.ToArray();
        }
    }
}
