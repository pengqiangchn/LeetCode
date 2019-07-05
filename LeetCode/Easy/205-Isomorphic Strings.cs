using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution205
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (string.IsNullOrWhiteSpace(s) && string.IsNullOrWhiteSpace(t))
            {
                return true;
            }

            Dictionary<char, int> dic = new Dictionary<char, int>();
            int[] order = new int[s.Length];
            int key = 1;

            //解构s字符串
            for (int i = 0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(s[i]))
                {
                    dic.Add(s[i], key++);
                }
                order[i] = dic[s[i]];
            }

            //判断字符串
            dic.Clear();
            key = 1;
            for (int i = 0; i < t.Length; i++)
            {
                if (!dic.ContainsKey(t[i]))
                {
                    dic.Add(t[i], key++);
                }

                if (dic[t[i]] != order[i])
                {
                    return false;
                }
            }


            return true;
        }
    }
}
