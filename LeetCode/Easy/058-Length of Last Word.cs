using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution058
    {
        public int LengthOfLastWord(string s)
        {
            if (String.IsNullOrWhiteSpace(s) || s == " ")
            {
                return 0;
            }

            string[] array = s.Split(new char[] { ' ' });

            string last = array[array.Length - 1];

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (!string.IsNullOrWhiteSpace(array[i]))
                {
                    return array[i].Length;
                }
            }

            return 0;



        }
    }
}
