using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution070
    {
        public int ClimbStairs(int n)
        {
            //变相的斐波那契数列
            //int value = Fibonacci(n);

            //斐波那契使用递归太慢了
            int value = 0;
            int f1 = 1;
            int f2 = 2;
            if (n == 1)
                return f1;

            if (n == 2)
                return f2;

            for (int i = 0; i < n - 2; i++)
            {
                value = f1 + f2;
                f1 = f2;
                f2 = value;
            }


            return value;
        }

        ////太慢了
        //public int Fibonacci(int n)
        //{
        //    if (n == 0)
        //        return 1;

        //    if (n == 1)
        //        return 1;

        //    if (n >= 2)
        //    {
        //        return Fibonacci(n - 1) + Fibonacci(n - 2);
        //    }

        //    return 0;
        //}
    }
}
