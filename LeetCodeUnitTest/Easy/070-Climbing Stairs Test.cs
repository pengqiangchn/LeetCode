using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution070Test
    {
        [Fact]
        public void ClimbStairs1()
        {
            //Arrange
            int n = 1;
            int expected = 1;

            //Act
            Solution070 s = new Solution070();
            int actual = s.ClimbStairs(n);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ClimbStairs2()
        {
            //Arrange
            int n = 2;
            int expected = 2;

            //Act
            Solution070 s = new Solution070();
            int actual = s.ClimbStairs(n);

            //Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void ClimbStairs3()
        {
            //Arrange
            int n = 3;
            int expected = 3;

            //Act
            Solution070 s = new Solution070();
            int actual = s.ClimbStairs(n);

            //Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void ClimbStairs4()
        {
            //Arrange
            int n = 4;
            int expected = 5;

            //Act
            Solution070 s = new Solution070();
            int actual = s.ClimbStairs(n);

            //Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void ClimbStairs5()
        {
            //Arrange
            int n = 5;
            int expected = 8;

            //Act
            Solution070 s = new Solution070();
            int actual = s.ClimbStairs(n);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ClimbStairs6()
        {
            //Arrange
            int n = 6;
            int expected = 13;

            //Act
            Solution070 s = new Solution070();
            int actual = s.ClimbStairs(n);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ClimbStairs44()
        {
            //Arrange
            int n = 44;
            int expected = 1134903170;

            //Act
            Solution070 s = new Solution070();
            int actual = s.ClimbStairs(n);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
