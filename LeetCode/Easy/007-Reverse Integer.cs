using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution007
    {
        public int Reverse(int x)
        {
            int result = 0;
            StringBuilder sb = new StringBuilder();
            decimal d = x;
            char[] charArray = Math.Abs(d).ToString().ToCharArray();
            Array.Reverse(charArray);

            if (x < 0)
            {
                sb.Append('-');
            }

            sb.Append(charArray);

            if (Int32.TryParse(sb.ToString(), out result))
            {
                return result;
            }
            else
            {
                return 0;
            }
        }
    }
}
