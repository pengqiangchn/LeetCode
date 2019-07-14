using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution412
    {
        //可以直接使用IList进行，那样写法就简单些
        public IList<string> FizzBuzz(int n)
        {
            string[] array = new string[n];
            for (int i = 0; i < n; i++)
            {
                if ((i + 1) % 3 == 0 && (i + 1) % 5 == 0)
                {
                    array[i] = "FizzBuzz";
                }
                else if ((i + 1) % 3 == 0)
                {
                    array[i] = "Fizz";
                }
                else if ((i + 1) % 5 == 0)
                {
                    array[i] = "Buzz";
                }
                else
                {
                    array[i] = (i + 1).ToString();
                }
            }

            return array;
        }
    }
}
