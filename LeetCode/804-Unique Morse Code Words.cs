using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution804
    {
        public int UniqueMorseRepresentations(string[] words)
        {
            string[] str = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

            HashSet<string> hash = new HashSet<string>();

            foreach (var word in words)
            {
                string s = "";
                foreach (var w in word)
                {
                    s += (str[w - 'a']);
                }
                hash.Add(s);
            }

            return hash.Count;
        }
    }
}
