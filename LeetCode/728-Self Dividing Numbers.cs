using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution728
    {
        public IList<int> SelfDividingNumbers(int left, int right)
        {
            IList<int> list = new List<int>();

            for (int i = left; i <= right; i++)
            {
                if (i % 10 == 0)
                    continue;

                if (i < 10)
                {
                    list.Add(i);
                }
                else
                {
                    int num = i;
                    while (num != 0)
                    {
                        int temp = num % 10;
                        if (temp == 0)
                        {
                            break;
                        }

                        if (i % temp == 0)
                        {
                            num = num / 10;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (num == 0)
                    {
                        list.Add(i);
                    }
                }
            }

            return list;
        }
    }
}
