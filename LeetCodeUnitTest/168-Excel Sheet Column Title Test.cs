using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution168Test
    {
        [Fact]
        public void ConvertToTitle1()
        {
            //Arrange
            int n = 1;
            string expected = "A";

            //Act
            Solution168 s = new Solution168();
            string actual = s.ConvertToTitle(n);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void ConvertToTitle2()
        {
            //Arrange
            int n = 28;
            string expected = "AB";

            //Act
            Solution168 s = new Solution168();
            string actual = s.ConvertToTitle(n);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void ConvertToTitle3()
        {
            //Arrange
            int n = 701;
            string expected = "ZY";

            //Act
            Solution168 s = new Solution168();
            string actual = s.ConvertToTitle(n);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void ConvertToTitle4()
        {
            //Arrange
            int n = 9999;
            string expected = "NTO";

            //Act
            Solution168 s = new Solution168();
            string actual = s.ConvertToTitle(n);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
