using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution290Test
    {
        [Theory]
        [InlineData("s", "s")]
        [InlineData("ab", "happy hacking")]
        [InlineData("abba", "dog cat cat dog")]
        public void WordPatternTrue(string pattern, string str)
        {
            //Act
            Solution290 s = new Solution290();
            bool actual = s.WordPattern(pattern, str);

            //Assert
            Assert.True(actual);
        }

        [Theory]
        [InlineData("", "")]
        [InlineData("", "s")]
        [InlineData("s", "")]
        [InlineData("s  ", " ")]
        [InlineData(" ", "  ")]
        [InlineData("aaa", "aa aa aa aa")]
        [InlineData("abba", "dog cat cat fish")]
        [InlineData("aaaa", "dog cat cat dog")]
        [InlineData("abba", "dog dog dog dog")]
        public void WordPatternFalse(string pattern, string str)
        {
            //Act
            Solution290 s = new Solution290();
            bool actual = s.WordPattern(pattern, str);

            //Assert
            Assert.False(actual);
        }
    }
}
