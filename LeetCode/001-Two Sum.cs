using System.Collections;
using System.Collections.Generic;

namespace LeetCode
{
    public class Solution001
    {
        //001 TwoSum
        public int[] TwoSum_1(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[2] { i, j };
                    }
                }
            }

            return null;
        }

        public int[] TwoSum_2(int[] nums, int target)
        {
            Hashtable hashtable = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (hashtable.ContainsKey(complement))
                {
                    return new int[] { (int)hashtable[complement], i };
                }

                if (!hashtable.ContainsKey(nums[i]))
                {
                    hashtable.Add(nums[i], i);
                }

            }

            return null;
        }

        public int[] TwoSum_3(int[] nums, int target)
        {

            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    return new[] { dict[nums[i]], i };
                }
                dict[target - nums[i]] = i;
            }
            return null;
        }
    }
}
