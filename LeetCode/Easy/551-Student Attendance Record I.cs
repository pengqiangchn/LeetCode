using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution551
    {
        //可以直接使用 系统自带的函数 查找s中是否包含LLL。。
        public bool CheckRecord(string s)
        {
            int a = 0;
            int l = 0;

            bool ba = true;
            bool bl = true;

            foreach (var c in s)
            {
                if (ba && c == 'A')
                {
                    a++;
                    if (a > 1)
                    {
                        ba = false;
                    }
                }

                if (bl && c == 'L')
                {
                    l++;

                    if (l > 2)
                    {
                        bl = false;
                    }
                }
                else
                {
                    l = 0;
                }

                if (!ba || !bl)
                    return false;
            }

            return ba && bl;
        }
    }
}
