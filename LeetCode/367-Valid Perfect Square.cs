using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution367
    {
        public bool IsPerfectSquare(int num)
        {
            if (num <= 0)
                return false;

            long head = 0;
            long end = num;
            while (end - head > 1)
            {
                if (num > head * head)
                {
                    head = (head + end) / 2;
                }
                else if (num < head * head)
                {
                    end = head;
                    head = head / 2;
                }
                else
                {
                    return true;
                }
            }

            return num == head * head || num == end * end;
        }
    }
}
