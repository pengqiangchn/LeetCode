using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution441Test
    {
        [Fact]
        public void ArrangeCoins()
        {
            int n = 2147483647;
            int expected = 65535;

            Solution441 s = new Solution441();

            int actual = s.ArrangeCoins(n);

            Assert.Equal(expected, actual);
        }
    }
}
