using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution028
    {
        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }

            if (haystack.Length < needle.Length)
            {
                return -1;
            }

            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack.Length - i < needle.Length)
                    return -1;

                if (haystack[i] == needle[0])
                {
                    for (int j = 0; j < needle.Length; j++)
                    {
                        if (haystack[i + j] != needle[j])
                        {
                            break;
                        }
                        else if (j == needle.Length - 1)
                        {
                            return i;
                        }
                    }
                }
            }

            return -1;
        }
    }
}
