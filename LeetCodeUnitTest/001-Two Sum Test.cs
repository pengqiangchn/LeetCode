using LeetCode;
using System;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution001Test
    {
        [Fact]
        public void TwoSumTest()
        {
            Solution001 s001 = new Solution001();

            int[] value = new int[] { 2, 7, 11, 15 };
            int[] expected = new int[] { 0, 1};

            int[] actual = s001.TwoSum_1(value, 9);
            Assert.Equal(expected, actual);
            //Assert.InRange(
        }
    }
}
