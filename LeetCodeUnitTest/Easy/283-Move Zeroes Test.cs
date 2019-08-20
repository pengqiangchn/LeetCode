using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution283Test
    {
        [Fact]
        public void MoveZeroes1()
        {
            //Arrange
            int[] nums = new int[] { 0, 1, 0, 3, 12 };
            int[] expected = new int[] { 1, 3, 12, 0, 0 };

            Solution283 s = new Solution283();

            //Act 
            s.MoveZeroes(nums);

            //Assert
            Assert.Equal(expected, nums);
        }

        [Fact]
        public void MoveZeroes2()
        {
            //Arrange
            int[] nums = new int[] { 1, 2, 1, 2, 3, 4, 5, 0, 0, 0, 1, 4, 0, 2 };
            int[] expected = new int[] { 1, 2, 1, 2, 3, 4, 5, 1, 4, 2, 0, 0, 0, 0 };

            Solution283 s = new Solution283();

            //Act 
            s.MoveZeroes(nums);

            //Assert
            Assert.Equal(expected, nums);
        }

        [Fact]
        public void MoveZeroes3()
        {
            //Arrange
            int[] nums = new int[] { 0, 0, 0, 0, 0, 0 };
            int[] expected = new int[] { 0, 0, 0, 0, 0, 0 };

            Solution283 s = new Solution283();

            //Act 
            s.MoveZeroes(nums);

            //Assert
            Assert.Equal(expected, nums);
        }

        [Fact]
        public void MoveZeroes4()
        {
            //Arrange
            int[] nums = new int[] { };
            int[] expected = new int[] { };

            Solution283 s = new Solution283();

            //Act 
            s.MoveZeroes(nums);

            //Assert
            Assert.Equal(expected, nums);
        }

    }
}
