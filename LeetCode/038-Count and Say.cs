using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution038
    {
        public string CountAndSay(int n)
        {
            if (n == 1)
                return "1";

            string say = "";
            List<int> list = new List<int>() { 1 };
            List<int> newList = new List<int>();
            int temp = 0;
            int count = 0;

            for (int i = 1; i < n; i++)
            {
                temp = list[0];
                for (int j = 0; j < list.Count; j++)
                {
                    if (temp == list[j])
                    {
                        count++;
                    }
                    else
                    {
                        //添加并重数；
                        newList.Add(count);
                        newList.Add(temp);
                        temp = list[j];
                        count = 1;
                    }

                    //如果是最后一个数了，就添加
                    if (j == list.Count - 1)
                    {
                        newList.Add(count);
                        newList.Add(temp);
                    }
                }

                list = newList;
                count = 0;
                newList = new List<int>();
            }
            list.ForEach(s => say += s.ToString());

            return say;
        }
    }
}
