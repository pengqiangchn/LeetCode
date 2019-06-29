using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution136Test
    {
        [Fact]
        public void SingleNumber1()
        {
            //Arrange
            int[] nums = new int[] { 2, 2, 1 };
            int expected = 1;

            //Act
            Solution136 s = new Solution136();
            int actual = s.SingleNumber(nums);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SingleNumber2()
        {
            //Arrange
            int[] nums = new int[] { 4, 1, 2, 1, 2 };
            int expected = 4;

            //Act
            Solution136 s = new Solution136();
            int actual = s.SingleNumber(nums);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SingleNumber3()
        {
            //Arrange
            int[] nums = new int[] { 1 };
            int expected = 1;

            //Act
            Solution136 s = new Solution136();
            int actual = s.SingleNumber(nums);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SingleNumber4()
        {
            //Arrange
            int[] nums = new int[] { 1, 2, 5, 4, 6, 7, 8, 7, 6, 8, 1, 2, 4 };
            int expected = 5;

            //Act
            Solution136 s = new Solution136();
            int actual = s.SingleNumber(nums);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
