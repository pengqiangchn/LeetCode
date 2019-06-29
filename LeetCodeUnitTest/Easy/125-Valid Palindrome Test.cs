using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution125Test
    {
        [Theory]
        [InlineData("")]
        [InlineData("..")]
        [InlineData("A man, a plan, a canal: Panama")]
        public void IsPalindromeTrue(string str)
        {
            //Arrange
            //bool expected = true;

            //Act 
            Solution125 s = new Solution125();
            bool actual = s.IsPalindrome(str);

            //Assert
            Assert.True(actual);
        }

        [Theory]
        [InlineData("1121")]
        [InlineData(" 1231 1231")]
        [InlineData("race a car")]
        public void IsPalindromeFalse(string str)
        {
            //Arrange
            //bool expected = true;

            //Act 
            Solution125 s = new Solution125();
            bool actual = s.IsPalindrome(str);

            //Assert
            Assert.False(actual);
        }

    }
}
