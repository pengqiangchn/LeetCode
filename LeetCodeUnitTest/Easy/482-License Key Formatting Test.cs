using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution482Test
    {
        [Fact]
        public void LicenseKeyFormatting()
        {
            string str = "---";
            int k = 3;
            string expected = "";

            Solution482 s = new Solution482();

            string actual = s.LicenseKeyFormatting(str, k);

            Assert.Equal(expected, actual);
        }
    }
}
