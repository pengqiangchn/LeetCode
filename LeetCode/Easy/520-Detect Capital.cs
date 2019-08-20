using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution520
    {
        public bool DetectCapitalUse(string word)
        {
            if (word.Length == 1)
            {
                return true;
            }

            bool isLower = false;
            if (word[0] >= 'a' && word[0] <= 'z')
            {
                isLower = true;
            }

            if (isLower && word[1] >= 'A' && word[1] <= 'Z')
            {
                return false;
            }

            if (!isLower && word[1] >= 'a' && word[1] <= 'z')
            {
                isLower = true;
            }

            for (int i = 2; i < word.Length; i++)
            {

                if (isLower)
                {
                    if (word[i] >= 'A' && word[i] <= 'Z')
                    {
                        return false;
                    }
                }
                else
                {
                    if (word[i] >= 'a' && word[i] <= 'z')
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
