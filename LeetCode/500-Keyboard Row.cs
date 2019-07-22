using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution500
    {
        //可以直接循环查找答案
        public string[] FindWords(string[] words)
        {
            List<string> list = new List<string>();
            HashSet<char> hash1 = new HashSet<char>() { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P' };
            HashSet<char> hash2 = new HashSet<char>() { 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L' };
            HashSet<char> hash3 = new HashSet<char>() { 'z', 'x', 'c', 'v', 'b', 'n', 'm', 'Z', 'X', 'C', 'V', 'B', 'N', 'M' };
            bool b1 = true, b2 = true, b3 = true;

            foreach (var word in words)
            {
                b1 = true; b2 = true; b3 = true;
                foreach (var c in word)
                {
                    if (b1 && !hash1.Contains(c))
                    {
                        b1 = false;
                    }

                    if (b2 && !hash2.Contains(c))
                    {
                        b2 = false;
                    }

                    if (b3 && !hash3.Contains(c))
                    {
                        b3 = false;
                    }

                    if (!b1 && !b2 && !b3)
                        break;
                }

                if (b1 || b2 || b3)
                    list.Add(word);
            }

            return list.ToArray();
        }
    }
}
