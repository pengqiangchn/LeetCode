using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution204
    {

        public int CountPrimes(int n)
        {
            bool[] isPrimes = new bool[n];
            //全部都为true；
            for (int i = 2; i < n; i++)
            {
                isPrimes[i] = true;
            }

            //将素数的倍数进行填充为 非素数
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                //如果不为素数，则不需要往后计算
                if (!isPrimes[i])
                    continue;

                for (int j = i * i; j < n; j += i)
                {
                    isPrimes[j] = false;
                }
            }

            int count = 0;
            //计算为true数量
            for (int i = 2; i < n; i++)
            {
                if (isPrimes[i])
                    count++;
            }

            return count;
        }

        ////双循环 超时。 使用数组看看
        //public int CountPrimes(int n)
        //{
        //    int count = 0;
        //    if (n < 2)
        //        return count;

        //    count++;
        //    if (n == 2)
        //        return count;

        //    for (int i = 3; i <= n; i++)
        //    {
        //        bool isPrimes = true;

        //        for (int j = 2; j <= Math.Sqrt(i); j++)
        //        {
        //            if (i % j == 0)
        //            {
        //                isPrimes = false;
        //                break;
        //            }
        //        }

        //        if (isPrimes)
        //        {
        //            count++;
        //        }
        //    }

        //    return count;
        //}
    }
}
