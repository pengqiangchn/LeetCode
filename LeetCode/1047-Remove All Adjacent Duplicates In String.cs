using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class Solution1047
    {
        public string RemoveDuplicates(string S)
        {
            Stack<char> stack = new Stack<char>();
            foreach (var c in S)
            {
                if (stack.Count > 0 && stack.Peek() == c)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }
            }
            char[] cs = stack.ToArray();
            Array.Reverse(cs);

            return new string(cs);
        }
    }
}
