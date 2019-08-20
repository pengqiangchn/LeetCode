using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution500Test
    {
        [Fact]
        public void FindWords()
        {
            string[] words = new string[] { "Hello", "Alaska", "Dad", "Peace" };
            string[] expected = new string[] { "Alaska", "Dad" };

            Solution500 s = new Solution500();

            string[] actual = s.FindWords(words);

            Assert.Equal(expected, actual);
        }
    }
}
