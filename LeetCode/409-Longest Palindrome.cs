using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution409
    {
        //这里只需要计数就行，用数组也是可以的。
        public int LongestPalindrome(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return 0;

            //查找所有字符，整理出现次数
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (var c in s)
            {
                if (dic.ContainsKey(c))
                {
                    dic[c]++;
                }
                else
                {
                    dic[c] = 1;
                }
            }

            //记录所有双数的字符
            int count = 0;
            foreach (var key in dic.Keys)
            {
                if (dic[key] / 2 > 0)
                {
                    count += dic[key] - dic[key] % 2;
                }
            }

            //如果未全部使用，可以再那一个单数作为中间轴；
            if (count < s.Length)
            {
                count++;
            }

            return count;
        }
    }
}
