using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution202
    {
        public bool IsHappy(int n)
        {
            HashSet<int> hash = new HashSet<int>();

            //当n不为1时，循环查找
            while (n != 1)
            {
                int sum = 0;

                //如果数据存在，说明循环了，可以不为欢乐数
                if (hash.Contains(n))
                {
                    return false;
                }
                else
                {
                    hash.Add(n);
                }

                while (n != 0)
                {
                    sum += (n % 10) * (n % 10);
                    n = n / 10;
                }

                n = sum;
            }

            return true;
        }
    }
}
