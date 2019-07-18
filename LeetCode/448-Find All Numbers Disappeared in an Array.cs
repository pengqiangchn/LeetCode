using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution448
    {
        //看了快速解后，才发现 自己想复杂了。想着去循环走圈的方式 将对应的数据进行排查，这样的话其实也超过了O(n),
        //最好的方式就是 负数形式，检查下标，如果存在，则将下标对应的数据置为负数，这样的话 只需要循环一次，就能得到 >0的值就是 没有下标的值
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            IList<int> list = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int index = nums[i];
                while (index != -1 && nums[index - 1] > 0)
                {
                    int temp = nums[index - 1];
                    nums[index - 1] = -1;
                    index = temp;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    list.Add(i + 1);
                }
            }

            return list;
        }
    }
}
