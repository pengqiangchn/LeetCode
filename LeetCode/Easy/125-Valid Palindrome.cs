using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution125
    {
        //可以不用tolower， 直接进行判断是否为大小写也行
        public bool IsPalindrome(string s)
        {
            s = s.Replace(" ", "").ToLower();
            int first = 0;
            int last = s.Length - 1;

            while (first <= last)
            {
                if (!(s[first] > 96 && s[first] < 123) && !(s[first] > 47 && s[first] < 58))
                {
                    first++;
                    continue;
                }
                if (!(s[last] > 96 && s[last] < 123) && !(s[last] > 47 && s[last] < 58))
                {
                    last--;
                    continue;
                }

                if (s[first] != s[last])
                {
                    return false;
                }
                else
                {
                    first++;
                    last--;
                    continue;
                }
            }

            return true;
        }

    }
}
