using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution171
    {
        //解法过于复杂。 其实只需要高位得出结果以后，乘以26，再加低位  循环即可；
        public int TitleToNumber(string s)
        {
            int num = 0;

            if (string.IsNullOrWhiteSpace(s))
                return num;


            for (int i = 0; i < s.Length; i++)
            {
                num += (s[i] - 'A' + 1) * (int)Math.Pow(26, (s.Length - i - 1));
            }

            return num;

        }
    }
}
