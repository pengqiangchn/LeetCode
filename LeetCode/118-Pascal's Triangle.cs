using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution118
    {
        //跟最快的类似，只是在中间的for循环中，最快的那个算法，去掉了0判断和末尾判断。
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> listArray = new List<IList<int>>();

            if (numRows <= 0)
                return listArray;

            listArray.Add(new List<int>() { 1 });
            if (numRows == 1)
                return listArray;

            listArray.Add(new List<int>() { 1, 1 });
            if (numRows == 2)
                return listArray;

            for (int i = 3; i <= numRows; i++)
            {
                List<int> list = new List<int>();
                for (int j = 0; j < i; j++)
                {
                    if (j == 0 || j == i - 1)
                    {
                        list.Add(1);
                    }
                    else
                    {

                        list.Add(listArray[i - 2][j] + listArray[i - 2][j - 1]);
                    }
                }
                listArray.Add(list);
            }

            return listArray;
        }
    }
}
