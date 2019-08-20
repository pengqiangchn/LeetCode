using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution415Test
    {
        [Fact]
        public void ThirdMax1()
        {
            string num1 = "123";
            string num2 = "312315412515";
            string expected = "312315412638";

            Solution415 s = new Solution415();

            string actual = s.AddStrings(num1, num2);

            Assert.Equal(expected, actual);
        }
    }
}
