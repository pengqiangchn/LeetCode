using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution119
    {
        //看了解题，可以使用公式方法去计算各行的值。
        public IList<int> GetRow(int rowIndex)
        {
            IList<int> list = new List<int>();
            list.Add(1);
            if (rowIndex == 0)
                return list;
            list.Add(1);
            if (rowIndex == 1)
                return list;


            for (int i = 2; i <= rowIndex; i++)
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    list[j] = list[j] + list[j + 1];
                }
                list.Insert(0, 1);
            }

            return list;
        }
    }
}
