using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution905
    {
        public int[] SortArrayByParity(int[] A)
        {
            if (A.Length < 2)
                return A;

            int right = A.Length - 1;
            int left = 0;
            int temp = 0;
            while (left < right)
            {
                if (A[left] % 2 == 1)
                {
                    //找到从右到左偶数
                    while (left < right && A[right] % 2 == 1)
                    {
                        right--;
                    }
                    temp = A[left];
                    A[left] = A[right];
                    A[right] = temp;
                }
                left++;
            }

            return A;
        }
    }
}
