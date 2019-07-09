using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution367Test
    {
        [Theory]
        [InlineData(1)]
        [InlineData(4)]
        [InlineData(9)]
        [InlineData(16)]
        [InlineData(2147395600)]
        public void IsPerfectSquareTrue(int num)
        {
            Solution367 s = new Solution367();
            bool actual = s.IsPerfectSquare(num);

            Assert.True(actual);

        }

        [Theory]
        [InlineData(0)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(8)]
        [InlineData(12)]
        public void IsPerfectSquareFalse(int num)
        {
            Solution367 s = new Solution367();
            bool actual = s.IsPerfectSquare(num);

            Assert.False(actual);

        }
    }
}
