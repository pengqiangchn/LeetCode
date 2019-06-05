using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution035Test
    {
        [Fact]
        public void SearchInsert1()
        {
            //Arrange
            int[] nums = new int[] { 1, 3, 5, 6 };
            int target = 5;

            int expected = 2;
            Solution035 s = new Solution035();

            //Act
            int actual = s.SearchInsert(nums, target);

            //Assert 
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SearchInsert2()
        {
            //Arrange
            int[] nums = new int[] { 1, 3, 5, 6 };
            int target = 2;

            int expected = 1;
            Solution035 s = new Solution035();

            //Act
            int actual = s.SearchInsert(nums, target);

            //Assert 
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SearchInsert3()
        {
            //Arrange
            int[] nums = new int[] { 1, 3, 5, 6 };
            int target = 7;

            int expected = 4;
            Solution035 s = new Solution035();

            //Act
            int actual = s.SearchInsert(nums, target);

            //Assert 
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SearchInsert4()
        {
            //Arrange
            int[] nums = new int[] { 1, 3, 5, 6 };
            int target = 0;

            int expected = 0;
            Solution035 s = new Solution035();

            //Act
            int actual = s.SearchInsert(nums, target);

            //Assert 
            Assert.Equal(expected, actual);
        }
    }
}
