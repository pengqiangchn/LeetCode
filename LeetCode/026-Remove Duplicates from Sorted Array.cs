using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution026
    {
        public static int RemoveDuplicates(int[] nums)
        {
            int ret = nums.Length;
            if (ret < 2)
            {
                return ret;
            }

            for (int i = 1; i < ret;)
            {
                //如果相等则把第二个数字往后移动，移动到当前删除节点的位置
                if (nums[i - 1] == nums[i])
                {
                    //如果当前小于删除后长度，则认为可以移动
                    if (i < ret - 1)
                    {
                        //往后挪
                        for (int j = i; j < ret - 1; j++)
                        {
                            //换位置
                            int tmp = nums[j];
                            nums[j] = nums[j + 1];
                            nums[j + 1] = tmp;
                        }

                        //更新长度
                        ret -= 1;
                    }
                    else if (i == ret - 1)
                    {
                        //更新长度
                        ret -= 1;
                    }
                }
                else
                {
                    i++;
                }
            }

            return ret;
        }

    }
}