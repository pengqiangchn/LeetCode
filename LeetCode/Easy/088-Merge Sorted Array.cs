using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution088
    {
        //虽然通过了，但是用了两个循环 所以速度慢
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int index1 = 0;
            int index2 = 0;
            int last = m;
            int length = m + n;

            while (index1 < length)
            {
                if (index2 >= n)
                {
                    break;
                }

                if (m <= 0 || (nums1[index1] > nums2[index2]))
                {
                    for (int i = last; i > index1; i--)
                    {
                        nums1[i] = nums1[i - 1];
                    }

                    nums1[index1] = nums2[index2];
                    last++;
                    index2++;
                }
                else
                {
                    m--;
                }
                index1++;

            }

        }
    }
}
