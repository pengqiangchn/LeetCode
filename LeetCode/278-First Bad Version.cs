using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution278
    {
        public int FirstBadVersion(int n)
        {
            long preIndex = 1;
            long endIndex = n;

            if (IsBadVersion(1))
                return 1;


            while (endIndex - preIndex > 1)
            {
                long index = (preIndex + endIndex) / 2;
                if (IsBadVersion((int)index))
                {
                    endIndex = index;
                }
                else
                {
                    preIndex = index;
                }
            }

            return (int)endIndex;
        }

        public bool IsBadVersion(int version)
        {
            return version >= 1702766719;
        }
    }
}
