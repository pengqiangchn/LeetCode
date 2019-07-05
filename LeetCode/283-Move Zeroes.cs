using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution283
    {
        //还有一个简单的方法，就是  覆盖前面元素 ，将0的空缺位置全部覆盖，然后重新赋值后面未处理的数据，均为0
        public void MoveZeroes(int[] nums)
        {
            int index = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    if (index == -1)
                    {
                        index = i;
                    }
                }
                else
                {
                    if (index != -1 && index < nums.Length)
                    {
                        nums[index] = nums[i];
                        nums[i] = 0;
                        index++;
                    }
                }
            }
        }
    }
}
