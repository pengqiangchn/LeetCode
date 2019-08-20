using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution1128Test
    {
        [Fact]
        public void NumEquivDominoPairs()
        {
            //Arrange
            int[][] nums = new int[][] { new int[] { 1, 2 }, new int[] { 2, 1 }, new int[] { 3, 4 } };
            int expected = 1;

            Solution1128 s = new Solution1128();

            //Act 
            int actual = s.NumEquivDominoPairs(nums);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
