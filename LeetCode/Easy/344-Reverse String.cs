using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution344
    {
        public void ReverseString(char[] s)
        {
            char temp = ' ';
            for (int i = 0; i <= s.Length - 1 - i; i++)
            {
                temp = s[i];
                s[i] = s[s.Length - 1 - i];
                s[s.Length - 1 - i] = temp;
            }
        }
    }
}
