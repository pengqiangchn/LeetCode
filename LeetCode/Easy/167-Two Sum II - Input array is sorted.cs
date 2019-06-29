using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution167
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            if (numbers.Length < 2)
                return null;

            //俩个for 暴力解决；
            //一个for + 字典解决;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (dic.ContainsKey(numbers[i]))
                {
                    return new int[] { dic[numbers[i]] + 1, i + 1 };
                }
                int sub = target - numbers[i];
                if (!dic.ContainsKey(sub))
                {
                    dic.Add(sub, i);
                }
            }

            return null;
        }
    }
}
