using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution434
    {
        public int CountSegments(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return 0;
            s = s.Trim();

            int count = 0;
            bool perChar = false;

            foreach (var c in s)
            {
                if (c != ' ')
                {
                    if (!perChar)
                    {
                        perChar = true;
                        count++;
                    }
                }
                else
                {
                    perChar = false;
                }
            }

            return count;
        }
    }
}
