using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution383
    {
        //前面写的误解题目了。
        public bool CanConstruct(string ransomNote, string magazine)
        {
            int[] chars = new int[26];

            for (int i = 0; i < magazine.Length; i++)
            {
                chars[magazine[i] - 'a']++;
            }

            for (int i = 0; i < ransomNote.Length; i++)
            {
                chars[ransomNote[i] - 'a']--;
                if (chars[ransomNote[i] - 'a'] < 0)
                {
                    return false;
                }
            }

            return true;



            //if (string.IsNullOrWhiteSpace(ransomNote))
            //    return true;

            //if (magazine.Length < ransomNote.Length)
            //    return false;

            //for (int i = 0; i < magazine.Length; i++)
            //{
            //    if (magazine[i] == ransomNote[0] && i + ransomNote.Length - 1 < magazine.Length)
            //    {
            //        for (int j = 1; j < ransomNote.Length; j++)
            //        {
            //            if (magazine[i + j] != ransomNote[j])
            //            {
            //                break;
            //            }

            //            if (j == ransomNote.Length - 1)
            //            {
            //                return true;
            //            }
            //        }
            //    }
            //}

            //return false;
        }
    }
}
