using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution1103
    {
        public int[] DistributeCandies(int candies, int num_people)
        {
            int[] p = new int[num_people];
            int count = 1;
            int index = 0;
            while (candies > 0)
            {
                if (candies > count)
                {

                    p[index % num_people] += count;
                    candies -= count;
                    count++;
                }
                else
                {
                    p[index % num_people] += candies;
                    candies = 0;
                }
                index++;
            }


            return p;
        }
    }
}
