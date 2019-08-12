using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution557
    {
        public string ReverseWords(string s)
        {
            string ss = "";
            foreach (var str in s.Split(" "))
            {
                char[] cs = str.ToCharArray();

                Array.Reverse(cs);

                ss += new string(cs) + " ";
            }

            return ss.Trim();
        }
    }
}
