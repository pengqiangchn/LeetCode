using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution204Test
    {
        [Fact]
        public void CountPrimes1()
        {
            //Arrange
            int n = 0;
            int expected = 0;

            //Act
            Solution204 s = new Solution204();
            int actual = s.CountPrimes(n);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CountPrimes2()
        {
            //Arrange
            int n = 1;
            int expected = 0;

            //Act
            Solution204 s = new Solution204();
            int actual = s.CountPrimes(n);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CountPrimes3()
        {
            //Arrange
            int n = 2;
            int expected = 0;

            //Act
            Solution204 s = new Solution204();
            int actual = s.CountPrimes(n);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CountPrimes4()
        {
            //Arrange
            int n = 10;
            int expected = 4;

            //Act
            Solution204 s = new Solution204();
            int actual = s.CountPrimes(n);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CountPrimes5()
        {
            //Arrange
            int n = 11474836;
            int expected = 755764;

            //Act
            Solution204 s = new Solution204();
            int actual = s.CountPrimes(n);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
