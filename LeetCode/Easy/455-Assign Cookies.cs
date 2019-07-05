using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution455
    {
        public int FindContentChildren(int[] g, int[] s)
        {
            if (g.Length == 0 || s.Length == 0)
                return 0;
            //排序，从小到大
            Array.Sort(g);
            Array.Sort(s);

            //尺寸
            int sIndex = 0;

            //记录匹配数量
            int count = 0;

            //胃口值最小的，与最小饼干重量相匹配
            //如果不匹配， 则饼干重量增加，直至取到最小饼干重量匹配为主。
            for (int i = 0; i < g.Length; i++)
            {
                while (sIndex < s.Length)
                {
                    if (s[sIndex] >= g[i])
                    {
                        count++;
                        sIndex++;
                        break;
                    }
                    else
                    {
                        sIndex++;
                    }
                }

                if (sIndex >= s.Length)
                    break;
            }


            return count;
        }
    }
}
