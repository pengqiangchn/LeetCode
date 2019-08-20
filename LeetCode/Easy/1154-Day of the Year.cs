using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution1154
    {
        //可以使用数组计算 然后闰年+1； 
        public int DayOfYear(string date)
        {
            DateTime dt = Convert.ToDateTime(date);

            return dt.DayOfYear;
        }
    }
}
