using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution067Test
    {
        [Fact]
        public void AddBinary1()
        {
            //Arrange
            string a = "11";
            string b = "1";

            string excepted = "100";

            //Act
            Solution067 s = new Solution067();
            string actual = s.AddBinary(a, b);

            //Assert
            Assert.Equal(excepted, actual);

        }

        [Fact]
        public void AddBinary2()
        {
            //Arrange
            string a = "1010";
            string b = "1011";

            string excepted = "10101";

            //Act
            Solution067 s = new Solution067();
            string actual = s.AddBinary(a, b);

            //Assert
            Assert.Equal(excepted, actual);

        }

        [Fact]
        public void AddBinary3()
        {
            //Arrange
            string a = "0";
            string b = "0";

            string excepted = "0";

            //Act
            Solution067 s = new Solution067();
            string actual = s.AddBinary(a, b);

            //Assert
            Assert.Equal(excepted, actual);

        }

        [Fact]
        public void AddBinary4()
        {
            //Arrange
            string a = "01";
            string b = "0";

            string excepted = "01";

            //Act
            Solution067 s = new Solution067();
            string actual = s.AddBinary(a, b);

            //Assert
            Assert.Equal(excepted, actual);

        }

        [Fact]
        public void AddBinary5()
        {
            //Arrange
            string a = "10";
            string b = "0";

            string excepted = "10";

            //Act
            Solution067 s = new Solution067();
            string actual = s.AddBinary(a, b);

            //Assert
            Assert.Equal(excepted, actual);

        }


        [Fact]
        public void AddBinary6()
        {
            //Arrange
            string a = "11";
            string b = "0";

            string excepted = "11";

            //Act
            Solution067 s = new Solution067();
            string actual = s.AddBinary(a, b);

            //Assert
            Assert.Equal(excepted, actual);

        }

        [Fact]
        public void AddBinary7()
        {
            //Arrange
            string a = "100";
            string b = "110010";

            string excepted = "110110";

            //Act
            Solution067 s = new Solution067();
            string actual = s.AddBinary(a, b);

            //Assert
            Assert.Equal(excepted, actual);

        }
    }
}
