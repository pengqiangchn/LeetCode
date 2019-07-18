using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution448Test
    {
        [Fact]
        public void FindDisappearedNumbers()
        {
            int[] nums = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };
            IList<int> expected = new List<int>() { 5, 6 };

            Solution448 s = new Solution448();

            IList<int> actual = s.FindDisappearedNumbers(nums);

            Assert.Equal(expected, actual);
        }
    }
}
