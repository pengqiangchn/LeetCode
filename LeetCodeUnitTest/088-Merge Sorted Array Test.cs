using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution088Test
    {
        [Fact]
        public void Merge1()
        {
            //Arrange
            int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int[] nums2 = new int[] { 2, 5, 6 };
            int n = 3;

            int[] expected = new int[] { 1, 2, 2, 3, 5, 6 };

            //Act
            Solution088 s = new Solution088();
            s.Merge(nums1, m, nums2, n);

            //Assert
            Assert.Equal(expected, nums1);
        }


        [Fact]
        public void Merge2()
        {
            //Arrange
            int[] nums1 = new int[] { 0, 0, 0, 0, 0, 0 };
            int m = 0;
            int[] nums2 = new int[] { 0, 0, 0 };
            int n = 0;

            int[] expected = new int[] { 0, 0, 0, 0, 0, 0 };

            //Act
            Solution088 s = new Solution088();
            s.Merge(nums1, m, nums2, n);

            //Assert
            Assert.Equal(expected, nums1);
        }


        [Fact]
        public void Merge3()
        {
            //Arrange
            int[] nums1 = new int[] { 1, 1, 1, 2, 2, 2, 0, 0, 0 };
            int m = 6;
            int[] nums2 = new int[] { 3, 3, 5 };
            int n = 3;

            int[] expected = new int[] { 1, 1, 1, 2, 2, 2, 3, 3, 5 };

            //Act
            Solution088 s = new Solution088();
            s.Merge(nums1, m, nums2, n);

            //Assert
            Assert.Equal(expected, nums1);
        }

        [Fact]
        public void Merge4()
        {
            //Arrange
            int[] nums1 = new int[] { 1, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int m = 2;
            int[] nums2 = new int[] { 3, 3, 5, 6, 8, 11, 33 };
            int n = 7;

            int[] expected = new int[] { 1, 3, 3, 5, 6, 8, 10, 11, 33, 0, 0, 0, 0 };

            //Act
            Solution088 s = new Solution088();
            s.Merge(nums1, m, nums2, n);

            //Assert
            Assert.Equal(expected, nums1);
        }

    }
}
