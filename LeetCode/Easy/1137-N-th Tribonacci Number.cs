using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution1137
    {
        public int Tribonacci(int n)
        {
            int a0 = 0;
            int a1 = 1;
            int a2 = 1;

            if (n == 0)
            {
                return a0;
            }

            if (n < 3)
            {
                return a1;
            }

            int temp = 0;
            for (int i = 3; i <= n; i++)
            {
                temp = a0 + a1 + a2;
                a0 = a1;
                a1 = a2;
                a2 = temp;
            }

            return temp;

        }
    }
}
