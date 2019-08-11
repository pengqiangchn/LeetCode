using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution961
    {
        //很多种解法，我写的算慢的。
        //因为有N个重复，所以 直接可以判断，相邻，或者中间差一位，就能找出。
        //或者用 hash 保存数字，一次循环。 我排序了以后就多次循环了，只要存在第二个 其实就是重复的数字了。
        public int RepeatedNTimes(int[] A)
        {
            Array.Sort(A);

            int temp = A[0];
            for (int i = 1; i < A.Length; i++)
            {
                if (temp == A[i])
                {
                    return temp;
                }
                else
                {
                    temp = A[i];
                }
            }

            return temp;
        }
    }
}
