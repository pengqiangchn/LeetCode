using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution190
    {
        public uint reverseBits(uint n)
        {
            char[] bits = Convert.ToString(n, 2).PadLeft(32, '0').ToCharArray();
            Array.Reverse(bits);

            uint u = Convert.ToUInt32(new String(bits), 2);
            //string ss = Convert.ToString(n, 2);
            //string s = Convert.ToString(~n, 2);
            //uint u = ~n;

            return u;



        }
    }
}
