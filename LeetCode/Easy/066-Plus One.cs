using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution066
    {
        public int[] PlusOne(int[] digits)
        {
            List<int> value = new List<int>();

            int temp = 0;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                temp = digits[i] + 1;
                value.Add(temp % 10);
                if (temp < 10 && i != 0)
                {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        value.Add(digits[j]);
                    }
                    break;
                }
                else if (temp > 9 && i == 0)
                {
                    value.Add(1);
                }

            }

            value.Reverse();

            return value.ToArray();
        }
    }
}
