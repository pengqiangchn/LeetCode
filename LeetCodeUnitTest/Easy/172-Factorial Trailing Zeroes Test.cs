using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution172Test
    {
        [Fact]
        public void TrailingZeroes1()
        {
            //Arrange
            int n = 3;
            int expected = 0;

            //Act
            Solution172 s = new Solution172();
            int actual = s.TrailingZeroes(n);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TrailingZeroes2()
        {
            //Arrange
            int n = 5;
            int expected = 1;

            //Act
            Solution172 s = new Solution172();
            int actual = s.TrailingZeroes(n);

            //Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void TrailingZeroes3()
        {
            //Arrange
            int n = 100;
            int expected = 24;

            //Act
            Solution172 s = new Solution172();
            int actual = s.TrailingZeroes(n);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TrailingZeroes4()
        {
            //Arrange
            int n = 358;
            int expected = 87;

            //Act
            Solution172 s = new Solution172();
            int actual = s.TrailingZeroes(n);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TrailingZeroes5()
        {
            //Arrange
            int n = 50;
            int expected = 12;

            //Act
            Solution172 s = new Solution172();
            int actual = s.TrailingZeroes(n);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TrailingZeroes6()
        {
            //Arrange
            int n = 1808548329;
            int expected = 452137076;

            //Act
            Solution172 s = new Solution172();
            int actual = s.TrailingZeroes(n);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
