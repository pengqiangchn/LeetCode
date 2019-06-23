using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution168
    {
        //看了最快解法，发现可以使用字母'A'作为基准 去加余数。
        public string ConvertToTitle(int n)
        {
            if (n < 1)
                return "";

            string letters = " ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string title = "";
            int index = 0;
            while (n != 0)
            {
                index = n % 26;
                if (index == 0)
                {
                    index = 26;
                }
                title = letters[index] + title;
                n = (n - index) / 26;
            }

            return title;
        }
    }
}
