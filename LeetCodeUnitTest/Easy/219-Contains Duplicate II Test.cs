using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution219Test
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 1 }, 3)]
        [InlineData(new int[] { 1, 0, 1, 1 }, 1)]
        [InlineData(new int[] { 99, 99 }, 2)]
        public void ContainsNearbyDuplicateTrue(int[] nums, int k)
        {
            //Arrange
            Solution219 s = new Solution219();

            //Act 
            bool actual = s.ContainsNearbyDuplicate(nums, k);

            //Assert
            Assert.True(actual);

        }
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 1, 2, 3 }, 2)]
        public void ContainsNearbyDuplicateFalse(int[] nums, int k)
        {
            //Arrange
            Solution219 s = new Solution219();

            //Act 
            bool actual = s.ContainsNearbyDuplicate(nums, k);

            //Assert
            Assert.False(actual);

        }

    }
}
