using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution345
    {
        public string ReverseVowels(string s)
        {
            char[] cs = s.ToCharArray();
            int head = 0, end = cs.Length - 1;
            char c = ' ';

            while (end >= head)
            {
                if (IsVowels(s[head]))
                {
                    if (IsVowels(s[end]))
                    {
                        c = cs[head];
                        cs[head] = cs[end];
                        cs[end] = c;
                        head++;
                        end--;
                    }
                    else
                    {
                        end--;
                    }
                }
                else
                {
                    head++;
                }
            }

            return new string(cs);
        }

        public bool IsVowels(char c)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'|| c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                return true;
            else
                return false;
        }

    }
}
