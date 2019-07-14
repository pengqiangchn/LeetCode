using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution414Test
    {
        [Fact]
        public void ThirdMax1()
        {
            int[] nums = new int[] { 1, 1, 2 };
            int expected = 2;

            Solution414 s = new Solution414();

            int actual = s.ThirdMax(nums);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ThirdMax2()
        {
            int[] nums = new int[] { 1, 2, 2 };
            int expected = 2;

            Solution414 s = new Solution414();

            int actual = s.ThirdMax(nums);

            Assert.Equal(expected, actual);
        }
    }
}
