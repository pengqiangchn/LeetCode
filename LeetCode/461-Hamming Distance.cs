using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class Solution461
    {
        public int HammingDistance(int x, int y)
        {
            int count = 0;
            int z = x ^ y;
            //可以使用Linq 写个 纳姆达表达式
            string zs = Convert.ToString(z, 2);
            foreach (var s in zs)
            {
                if (s == '1')
                    count++;
            }

            return count;
        }
    }
}
