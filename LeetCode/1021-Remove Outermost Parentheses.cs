using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class Solution1021
    {
        public string RemoveOuterParentheses(string S)
        {
            string str = "";
            int count = 0;

            string ss = "";
            foreach (var c in S)
            {
                if (c == '(')
                {
                    if (count != 0)
                    {
                        ss += "(";
                    }
                    count++;
                }
                else
                {
                    count--;
                    if (count != 0)
                    {
                        ss += ")";
                    }
                }

                if (count == 0)
                {
                    str += ss;
                    ss = "";
                }
            }


            return str;
        }
    }
}
