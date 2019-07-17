using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution290
    {
        public bool WordPattern(string pattern, string str)
        {
            if (string.IsNullOrWhiteSpace(pattern) || string.IsNullOrWhiteSpace(str))
                return false;

            Dictionary<char, int> dicP = new Dictionary<char, int>();
            Dictionary<string, int> dicS = new Dictionary<string, int>();

            int[] iArray = new int[pattern.Length];
            int pIndex = 1;
            for (int i = 0; i < pattern.Length; i++)
            {
                if (!dicP.ContainsKey(pattern[i]))
                {
                    dicP[pattern[i]] = pIndex++;
                }


                iArray[i] = dicP[pattern[i]];
            }

            string[] sArray = str.Split(' ');

            if (iArray.Length != sArray.Length)
            {
                return false;
            }

            int sIndex = 1;
            for (int i = 0; i < sArray.Length; i++)
            {
                if (!dicS.ContainsKey(sArray[i]))
                {
                    dicS[sArray[i]] = sIndex++;
                }

                if (iArray[i] != dicS[sArray[i]])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
