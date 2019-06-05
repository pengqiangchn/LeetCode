using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution020Test
    {
        [Theory]
        [InlineData("")]
        [InlineData("()")]
        [InlineData("()[]{}")]
        [InlineData("{[]}")]
        public void IsValid_TrueTest(string s)
        {
            //Arrange
            Solution020 s020 = new Solution020();

            //Act
            bool actual = s020.IsValid(s);

            //Assert
            Assert.True(actual);
        }

        [Theory]
        [InlineData("(]")]
        [InlineData("((")]
        [InlineData("){")]
        [InlineData("([)]")]
        public void IsValid_FalseTest(string s)
        {
            //Arrange
            Solution020 s020 = new Solution020();

            //Act
            bool actual = s020.IsValid(s);

            //Assert
            Assert.False(actual);
        }


    }
}
