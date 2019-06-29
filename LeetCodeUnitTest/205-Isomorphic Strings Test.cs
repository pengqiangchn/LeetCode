using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution205Test
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("egg", "add")]
        [InlineData("paper", "title")]
        public void IsIsomorphicTrue(string str, string t)
        {
            //Arrange
            Solution205 s = new Solution205();

            //Act
            bool actual = s.IsIsomorphic(str, t);

            //Assert
            Assert.True(actual);
        }

        [Theory]
        [InlineData("foo", "bar")]
        public void IsIsomorphicFalse(string str, string t)
        {
            //Arrange
            Solution205 s = new Solution205();

            //Act
            bool actual = s.IsIsomorphic(str, t);

            //Assert
            Assert.False(actual);
        }

    }
}
