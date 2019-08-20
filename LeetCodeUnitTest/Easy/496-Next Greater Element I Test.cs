using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution496Test
    {
        [Fact]
        public void NextGreaterElement()
        {
            int[] nums1 = new int[] { 4, 1, 2 };
            int[] nums2 = new int[] { 1, 3, 4, 2 };

            int[] expected = new int[] { -1, 3, -1 };

            Solution469 s = new Solution469();

            int[] actual = s.NextGreaterElement(nums1, nums2);

            Assert.Equal(expected, actual);

        }
    }
}
