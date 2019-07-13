using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution389
    {
        //还可以 直接使用 求和，因为只有字母，那么求和以后 t的和-s的和就是答案
        public char FindTheDifference(string s, string t)
        {
            int c = 0;
            for (int i = 0; i < s.Length; i++)
            {
                c ^= s[i];

                c ^= t[i];
            }

            c ^= t[t.Length - 1];

            return (char)c;


            //int i = 0;
            //foreach (var c in s)
            //{
            //    i ^= c;
            //}

            //foreach (var c in t)
            //{
            //    i ^= c;
            //}

            //return (char)i;
        }
    }
}
