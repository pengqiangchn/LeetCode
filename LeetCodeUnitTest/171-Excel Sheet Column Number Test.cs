using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution171Test
    {
        [Fact]
        public void TitleToNumber1()
        {
            //Arrange
            string str = "A";
            int expected = 1;

            //Act
            Solution171 s = new Solution171();
            int actual = s.TitleToNumber(str);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TitleToNumber2()
        {
            //Arrange
            string str = "AB";
            int expected = 28;

            //Act
            Solution171 s = new Solution171();
            int actual = s.TitleToNumber(str);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TitleToNumber3()
        {
            //Arrange
            string str = "ZY";
            int expected = 701;

            //Act
            Solution171 s = new Solution171();
            int actual = s.TitleToNumber(str);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TitleToNumber4()
        {
            //Arrange
            string str = "AZSOAS";
            int expected = 24106881;

            //Act
            Solution171 s = new Solution171();
            int actual = s.TitleToNumber(str);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
