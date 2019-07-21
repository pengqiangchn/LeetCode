using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Sloution476
    {
        public int FindComplement(int num)
        {
            string str = Convert.ToString(num, 2).TrimStart('0');
            string com = "";
            foreach (var s in str)
            {
                if (s == '1')
                {
                    com += "0";
                }
                else
                {
                    com += "1";
                }
            }

            return Convert.ToInt32(com, 2);
        }
    }
}
