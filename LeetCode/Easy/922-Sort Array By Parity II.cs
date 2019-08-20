using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution922
    {
        public int[] SortArrayByParityII(int[] A)
        {
            if (A.Length < 3)
            {
                return A;
            }

            int index = 0;

            bool IsEven = true;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    IsEven = false;
                }
                else
                {

                }
            }


            return null;
        }
    }
}
