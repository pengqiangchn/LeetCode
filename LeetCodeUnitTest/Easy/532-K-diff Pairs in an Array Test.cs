﻿using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution532Test
    {
        [Fact]
        public void FindPairs()
        {
            int[] nums = new int[] { 2, 9, 0, 8, 9, 6, 5, 9, 8, 1, 9, 6, 9, 2, 8, 8, 7, 5, 7, 8, 8, 3, 7, 4, 1, 1, 6, 2, 9, 9, 3, 9, 2, 4, 6, 5, 6, 5, 1, 5, 9, 9, 8, 1, 4, 3, 2, 8, 5, 3, 5, 4, 5, 7, 0, 0, 7, 6, 4, 7, 2, 4, 9, 3, 6, 6, 5, 0, 0, 0, 8, 9, 9, 6, 5, 4, 6, 2, 1, 3, 2, 5, 0, 1, 4, 2, 6, 9, 5, 4, 9, 6, 0, 8, 3, 8, 0, 0, 2, 1 };
            int k = 1;

            Solution532 s = new Solution532();
            int actual = s.FindPairs(nums, k);

            Assert.Equal(9, actual);

        }
    }
}
