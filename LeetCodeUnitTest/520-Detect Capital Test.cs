using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution520Test
    {
        [Fact]
        public void DetectCapitalUse()
        {
            string word = "Google";

            Solution520 s = new Solution520();
            bool actual = s.DetectCapitalUse(word);

            Assert.True(actual);

        }
    }
}
