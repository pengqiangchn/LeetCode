using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class Solution507
    {
        public bool CheckPerfectNumber(int num)
        {
            //int sum = 0;
            //for (int i = num / 2; i > 0; i--)
            //{
            //    if (num % i == 0)
            //    {
            //        sum += i;
            //        if (sum > num)
            //        {
            //            return false;
            //        }
            //        else if (sum == num)
            //        {
            //            return true;
            //        }
            //    }
            //}

            //return false;
            if (num == 1)
                return false;

            int sum = 1; int i = 2;
            for (; i < Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                    sum += (num / i);
                }

            }

            if (i * i == num)
            {
                sum += i;
            }

            return sum == num;

        }
    }
}
