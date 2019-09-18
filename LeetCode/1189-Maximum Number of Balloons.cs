using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class Solution1189
    {
        public int MaxNumberOfBalloons(string text)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            dic['b'] = 0;
            dic['a'] = 0;
            dic['l'] = 0;
            dic['o'] = 0;
            dic['n'] = 0;

            //计算数量
            foreach (var c in text)
            {
                if (dic.ContainsKey(c))
                {
                    dic[c]++;
                }
            }
            //处理双数；
            dic['l'] = dic['l'] / 2;
            dic['o'] = dic['o'] / 2;

            int min = int.MaxValue;
            foreach (var key in dic.Keys)
            {
                min = Math.Min(min, dic[key]);
            }

            return min;
        }
    }
}
