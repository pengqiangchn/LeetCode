using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution41
    {
        public int FirstMissingPositive(int[] nums)
        {
            //将大于长度的数和 负数置为0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                    nums[i] = nums.Length + 1;
                }
            }

            //将存在的小数进行负数标记
            for (int i = 0; i < nums.Length; i++)
            {
                int index = Math.Abs(nums[i]) - 1;
                if (index >= 0 && index < nums.Length && nums[index] >= 0)
                {
                    if (nums[index] == 0)
                    {
                        nums[index] = -(nums.Length + 1);
                    }
                    else
                    {
                        nums[index] = -nums[index];
                    }
                }
            }

            int n = 0;

            for (; n < nums.Length; n++)
            {
                if (nums[n] >= 0)
                {
                    break;
                }
            }

            return n == 0 ? 1 : ++n;
        }
    }
}
