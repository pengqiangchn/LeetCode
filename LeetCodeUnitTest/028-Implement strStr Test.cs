using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution028Test
    {
        [Fact]
        public void StrStrFindTest()
        {
            //Arrange
            int expected = 2;
            Solution028 s = new Solution028();

            //Act
            int actual = s.StrStr("hello", "ll");

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void StrStrFindTest2()
        {
            //Arrange
            int expected = 0;
            Solution028 s = new Solution028();

            //Act
            int actual = s.StrStr("a", "a");

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void StrStrFindTest3()
        {
            //Arrange
            int expected = 4;
            Solution028 s = new Solution028();

            //Act
            int actual = s.StrStr("mississippi", "issip");

            //Assert
            Assert.Equal(expected, actual);

        }
        
        [Fact]
        public void StrStrFindTest4()
        {
            //Arrange
            int expected = 6;
            Solution028 s = new Solution028();

            //Act
            int actual = s.StrStr("mississippi", "sipp");

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData("", "")]
        [InlineData("aaaaa", "")]
        public void StrStrNeedleZeroTest(string haystack, string needle)
        {
            //Arrange
            int expected = 0;
            Solution028 s = new Solution028();

            //Act
            int actual = s.StrStr(haystack, needle);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("123as", "21")]
        [InlineData("aaa", "aaaa")]
        [InlineData("aaaaa", "bba")]
        public void StrStrNoFindTest(string haystack, string needle)
        {
            //Arrange
            int expected = -1;
            Solution028 s = new Solution028();

            //Act
            int actual = s.StrStr(haystack, needle);

            //Assert
            Assert.Equal(expected, actual);

        }


    }
}
