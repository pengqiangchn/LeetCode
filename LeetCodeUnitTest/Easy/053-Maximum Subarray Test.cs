using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution053Test
    {
        [Fact]
        public void MaxSubArray()
        {
            //Arrange
            int[] nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int expected = 6;

            //Act
            Solution053 s = new Solution053();
            int actual = s.MaxSubArray(nums);

            //Assert 
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MaxSubArray2()
        {
            //Arrange
            int[] nums = new int[] { -1 };
            int expected = -1;

            //Act
            Solution053 s = new Solution053();
            int actual = s.MaxSubArray(nums);

            //Assert 
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MaxSubArray3()
        {
            //Arrange
            int[] nums = new int[] { 0, -1, 1, 0 };
            int expected = 1;

            //Act
            Solution053 s = new Solution053();
            int actual = s.MaxSubArray(nums);

            //Assert 
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MaxSubArray4()
        {
            //Arrange
            int[] nums = new int[] { -2, 1 };
            int expected = 1;

            //Act
            Solution053 s = new Solution053();
            int actual = s.MaxSubArray(nums);

            //Assert 
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MaxSubArray5()
        {
            //Arrange
            int[] nums = new int[] { -1, 0, -2 };
            int expected = 0;

            //Act
            Solution053 s = new Solution053();
            int actual = s.MaxSubArray(nums);

            //Assert 
            Assert.Equal(expected, actual);
        }
    }
}
