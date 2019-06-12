using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution069Test
    {
        [Fact]
        public void MySqrt1()
        {
            //Arrange
            int x = 4;
            int expected = 2;

            //Act
            Solution069 s = new Solution069();
            int actual = s.MySqrt(x);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void MySqrt2()
        {
            //Arrange
            int x = 8;
            int expected = 2;

            //Act
            Solution069 s = new Solution069();
            int actual = s.MySqrt(x);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void MySqrt3()
        {
            //Arrange
            int x = 9898172;
            int expected = 3146;

            //Act
            Solution069 s = new Solution069();
            int actual = s.MySqrt(x);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void MySqrt4()
        {
            //Arrange
            int x = 0;
            int expected = 0;

            //Act
            Solution069 s = new Solution069();
            int actual = s.MySqrt(x);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void MySqrt5()
        {
            //Arrange
            int x = 18;
            int expected = 4;

            //Act
            Solution069 s = new Solution069();
            int actual = s.MySqrt(x);

            //Assert
            Assert.Equal(expected, actual);

        }


        [Fact]
        public void MySqrt6()
        {
            //Arrange
            int x = 188;
            int expected = 13;

            //Act
            Solution069 s = new Solution069();
            int actual = s.MySqrt(x);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void MySqrt7()
        {
            //Arrange
            int x = 1888;
            int expected = 43;

            //Act
            Solution069 s = new Solution069();
            int actual = s.MySqrt(x);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void MySqrt8()
        {
            //Arrange
            int x = 2147395599;
            int expected = 46339;

            //Act
            Solution069 s = new Solution069();
            int actual = s.MySqrt(x);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void MySqrt9()
        {
            //Arrange
            int x = 2147395600;
            int expected = 46340;

            //Act
            Solution069 s = new Solution069();
            int actual = s.MySqrt(x);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
