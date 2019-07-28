using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution509
    {
        public int Fib(int N)
        {
            int f1 = 1, f2 = 1, f3 = 0;
            if (N == 0)
                return 0;
            if (N <= 2)
            {
                return 1;
            }

            for (int i = 0; i < N - 2; i++)
            {
                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
            }

            return f3;
        }
    }
}
