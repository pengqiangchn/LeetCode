using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution009
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            string strX = x.ToString();
            char[] strReverse = strX.ToCharArray();
            Array.Reverse(strReverse);
            if (strX == new string(strReverse))
                return true;
            else
                return false;

        }

        //public bool IsPalindrome(int x)
        //{
        //    if (x < 0)
        //        return false;

        //    string strX = x.ToString();
        //    int lenght = strX.Length - 1;
        //    for (int i = 0; i < lenght; i++)
        //    {
        //        if (strX[i] != strX[lenght--])
        //        {
        //            return false;
        //        }
        //    }

        //    return true;

        //}
    }
}
