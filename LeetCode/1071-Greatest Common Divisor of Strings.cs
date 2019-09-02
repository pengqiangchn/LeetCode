using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class Solution1701
    {
        //应该使用辗转相除法
        public string GcdOfStrings(string str1, string str2)
        {
            string max, min;
            if (str1.Length >= str2.Length)
            {
                max = str1;
                min = str2;
            }
            else
            {
                max = str2;
                min = str1;
            }

            string s = new string(min.ToArray());
            while (s.Length > 0)
            {
                string temp = min.Replace(s, "");
                if (temp.Length == 0)
                {
                    string temp2 = max.Replace(s, "");
                    if (temp2.Length == 0)
                    {
                        return s;
                    }
                }
                s = s.Remove(s.Length - 1);
            }

            return "";
        }
    }
}
