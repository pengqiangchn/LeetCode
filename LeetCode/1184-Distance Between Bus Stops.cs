using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class Solution1184
    {
        public int DistanceBetweenBusStops(int[] distance, int start, int destination)
        {
            if (start == destination)
            {
                return 0;
            }

            int stops = 0;

            if (start < destination)
            {
                for (int i = start; i < destination; i++)
                {
                    stops += distance[i];
                }
            }
            else
            {
                for (int i = destination; i < start; i++)
                {
                    stops += distance[i];
                }

            }

            return Math.Min(distance.Sum() - stops, stops);
        }
    }
}
