using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution167Test
    {
        [Fact]
        public void TwoSum1()
        {
            //Arrange
            int[] numbers = new int[] { 2, 7, 11, 15 };
            int target = 9;

            int[] expected = new int[] { 1, 2 };

            //Act
            Solution167 s = new Solution167();
            int[] actual = s.TwoSum(numbers, target);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void TwoSum2()
        {
            //Arrange
            int[] numbers = new int[] { 1, 2, 7, 11, 15 };
            int target = 9;

            int[] expected = new int[] { 2, 3 };

            //Act
            Solution167 s = new Solution167();
            int[] actual = s.TwoSum(numbers, target);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void TwoSum3()
        {
            //Arrange
            int[] numbers = new int[] { 0, 2, 6, 8, 11, 15 };
            int target = 14;

            int[] expected = new int[] { 3, 4 };

            //Act
            Solution167 s = new Solution167();
            int[] actual = s.TwoSum(numbers, target);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void TwoSum4()
        {
            //Arrange
            int[] numbers = new int[] { 0, 2, 6, 8, 9, 11, 15 };
            int target = 9;

            int[] expected = new int[] { 1, 5 };

            //Act
            Solution167 s = new Solution167();
            int[] actual = s.TwoSum(numbers, target);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
