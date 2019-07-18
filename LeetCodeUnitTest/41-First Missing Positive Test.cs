using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution041Test
    {
        [Fact]
        public void FirstMissingPositive()
        {
            int[] nums = new int[] { 3, 4, 0, 2 };
            int expected = 1;

            Solution41 s = new Solution41();

            int actual = s.FirstMissingPositive(nums);

            Assert.Equal(expected, actual);
        }
    }
}
