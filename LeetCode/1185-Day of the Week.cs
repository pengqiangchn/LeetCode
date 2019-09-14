using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class Solution1185
    {
        public string DayOfTheWeek(int day, int month, int year)
        {
            DateTime dt = new DateTime(year, month, day);

            return dt.DayOfWeek.ToString();
        }
    }
}
