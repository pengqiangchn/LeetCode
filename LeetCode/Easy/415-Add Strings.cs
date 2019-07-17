using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution415
    {
        //可以使用StringBuilder  这样处理string快一些；
        public string AddStrings(string num1, string num2)
        {
            Stack<int> s = new Stack<int>();
            int index1 = num1.Length - 1;
            int index2 = num2.Length - 1;
            int temp = 0;

            while (index1 >= 0 || index2 >= 0)
            {
                if (index1 >= 0)
                {
                    temp += num1[index1--] - '0';
                }

                if (index2 >= 0)
                {
                    temp += num2[index2--] - '0';
                }

                s.Push(temp % 10);
                temp /= 10;
            }

            if (temp > 0)
                s.Push(temp);

            string str = "";
            while (s.Count > 0)
            {
                str += s.Pop().ToString();
            }

            return str;
        }
    }
}
