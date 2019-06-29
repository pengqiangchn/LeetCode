using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution189Test
    {
        [Fact]
        public void Rotate1()
        {
            //Arrange
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int k = 3;

            int[] expected = new int[] { 5, 6, 7, 1, 2, 3, 4 };

            //Act
            Solution189 s = new Solution189();
            s.Rotate(nums, k);

            //Assert
            Assert.Equal(expected, nums);
        }

        [Fact]
        public void Rotate2()
        {
            //Arrange
            int[] nums = new int[] { -1, -100, 3, 99 };
            int k = 2;

            int[] expected = new int[] { 3, 99, -1, -100 };

            //Act
            Solution189 s = new Solution189();
            s.Rotate(nums, k);

            //Assert
            Assert.Equal(expected, nums);
        }

        [Fact]
        public void Rotate3()
        {
            //Arrange
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int k = 7;

            int[] expected = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            //Act
            Solution189 s = new Solution189();
            s.Rotate(nums, k);

            //Assert
            Assert.Equal(expected, nums);
        }

        [Fact]
        public void Rotate4()
        {
            //Arrange
            int[] nums = new int[] { 1, 2 };
            int k = 3;

            int[] expected = new int[] { 2, 1 };

            //Act
            Solution189 s = new Solution189();
            s.Rotate(nums, k);

            //Assert
            Assert.Equal(expected, nums);
        }
    }
}
