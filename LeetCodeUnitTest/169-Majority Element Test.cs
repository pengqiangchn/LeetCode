using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution169Test
    {
        [Fact]
        public void MajorityElement1()
        {
            //Arrange 
            int[] nums = new int[] { 1, 2, 1 };
            int expected = 1;

            //Act
            Solution169 s = new Solution169();
            int actual = s.MajorityElement(nums);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MajorityElement2()
        {
            //Arrange 
            int[] nums = new int[] { 1, 2, 1, 2, 3, 4, 1, 2, 3, 4, 1, 1 };
            int expected = 1;

            //Act
            Solution169 s = new Solution169();
            int actual = s.MajorityElement(nums);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MajorityElement3()
        {
            //Arrange 
            int[] nums = new int[] { 2, 2, 1, 1, 1, 2, 2 };
            int expected = 2;

            //Act
            Solution169 s = new Solution169();
            int actual = s.MajorityElement(nums);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MajorityElement4()
        {
            //Arrange 
            int[] nums = new int[] { 6, 5, 5 };
            int expected = 5;

            //Act
            Solution169 s = new Solution169();
            int actual = s.MajorityElement(nums);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
