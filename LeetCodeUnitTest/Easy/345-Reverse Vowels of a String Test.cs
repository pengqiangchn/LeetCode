using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution345Test
    {
        [Fact]
        public void ReverseVowels1()
        {
            string str = "hello";
            string expected = "holle";

            Solution345 s = new Solution345();
            string actual = s.ReverseVowels(str);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReverseVowels2()
        {
            string str = "leetcode";
            string expected = "leotcede";

            Solution345 s = new Solution345();
            string actual = s.ReverseVowels(str);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReverseVowels3()
        {
            string str = "a1e13i1o2u";
            string expected = "u1o13i1e2a";

            Solution345 s = new Solution345();
            string actual = s.ReverseVowels(str);

            Assert.Equal(expected, actual);
        }
    }
}
