using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution020
    {
        public bool IsValid(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return true;
            }
            else if (s.Length < 2)
            {
                return false;
            }

            Stack<char> parentheses = new Stack<char>();
            Dictionary<char, char> map = new Dictionary<char, char>();
            map.Add('(', ')');
            map.Add('[', ']');
            map.Add('{', '}');
            //如果是左边符号，则保存到列表中，如果是右边符号，则检查当前最后一个左边符号是否匹配
            //如果不匹配则 不闭合， 则返回 false；
            foreach (var item in s)
            {
                if (item == '(' || item == '[' || item == '{')
                {
                    parentheses.Push(item);
                }
                else
                {
                    if (parentheses.Count > 0)
                    {
                        char left = parentheses.Pop();
                        if (item != map[left])
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            if (parentheses.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
