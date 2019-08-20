using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution1128
    {
        public int NumEquivDominoPairs(int[][] dominoes)
        {
            //判断是否存在
            Dictionary<int, int> dic = new Dictionary<int, int>();
            //存储位置
            List<int> list = new List<int>();
            int index = 0;
            int count = 0;

            //创建次数索引
            foreach (var dominoe in dominoes)
            {
                int d1 = dominoe[0] * 10 + dominoe[1];
                int d2 = dominoe[1] * 10 + dominoe[0];
                if (dic.ContainsKey(d1) || dic.ContainsKey(d2))
                {
                    list[dic[d1]]++;
                }
                else
                {
                    dic[d1] = index;
                    dic[d2] = index;
                    list.Add(0);
                    index++;
                }
            }

            //汇总次数
            foreach (var dominoe in dominoes)
            {
                int d1 = dominoe[0] * 10 + dominoe[1];
                int d2 = dominoe[1] * 10 + dominoe[0];
                if (dic.ContainsKey(d1) || dic.ContainsKey(d2))
                {
                    if (list[dic[d1]] < -1)
                        continue;
                    count += list[dic[d1]];
                    list[dic[d1]]--;
                }
            }

            return count;
        }
    }
}
