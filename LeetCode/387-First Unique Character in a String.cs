using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution387
    {
        public int FirstUniqChar(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            Dictionary<char, int> index = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    dic[s[i]]++;
                }
                else
                {
                    dic[s[i]] = 1;
                }

                if (!index.ContainsKey(s[i]))
                {
                    index[s[i]] = i;
                }
            }

            foreach (var key in dic.Keys)
            {
                if (dic[key] == 1)
                {
                    return index[key];
                }
            }

            return -1;
        }
    }
}
