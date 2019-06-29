using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution202Test
    {
        [Theory]
        [InlineData(1)]
        [InlineData(19)]
        public void IsHappyTrue(int n)
        {
            //Arrange
            Solution202 s = new Solution202();

            //Act
            bool actual = s.IsHappy(n);

            //Assert
            Assert.True(actual);

        }

        [Theory]
        [InlineData(0)]
        [InlineData(2)]
        [InlineData(20)]
        public void IsHappyFalse(int n)
        {
            //Arrange
            Solution202 s = new Solution202();

            //Act
            bool actual = s.IsHappy(n);

            //Assert
            Assert.False(actual);

        }
    }
}
