using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class Solution1046
    {
        public int LastStoneWeight(int[] stones)
        {
            if (stones.Length == 1)
                return stones[0];

            Array.Sort(stones);
            //每次找完就排序；
            while (stones[stones.Length - 2] != 0)
            {
                stones[stones.Length - 1] = stones[stones.Length - 1] - stones[stones.Length - 2];
                stones[stones.Length - 2] = 0;

                Array.Sort(stones);
            }


            return stones[stones.Length - 1];
        }
    }
}
