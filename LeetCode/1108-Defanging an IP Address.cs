using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution1108
    {
        public string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
        }
    }
}
