using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution1160Test
    {
        [Fact]
        public void CountCharacters()
        {

            Solution1160 s = new Solution1160();

            string[] words = new string[] { "cat", "bt", "hat", "tree" };
            string chars = "atach";
            int expected = 6;

            int actual = s.CountCharacters(words, chars);
            Assert.Equal(expected, actual);
            //Assert.InRange(
        }
    }
}
