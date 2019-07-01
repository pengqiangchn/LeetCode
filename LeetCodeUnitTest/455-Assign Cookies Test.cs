using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution455Test
    {
        [Fact]
        public void FindContentChildren1()
        {
            //Arrange
            int[] g = new int[] { 1, 2, 3 };
            int[] s = new int[] { 1, 1 };

            int expected = 1;

            //Act
            Solution455 so = new Solution455();
            int actual = so.FindContentChildren(g, s);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void FindContentChildren2()
        {
            //Arrange
            int[] g = new int[] { 1, 2 };
            int[] s = new int[] { 1, 2, 3 };

            int expected = 2;

            //Act
            Solution455 so = new Solution455();
            int actual = so.FindContentChildren(g, s);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void FindContentChildren3()
        {
            //Arrange
            int[] g = new int[] { 4, 1, 3, 5 };
            int[] s = new int[] { 1, 3, 2 };

            int expected = 2;

            //Act
            Solution455 so = new Solution455();
            int actual = so.FindContentChildren(g, s);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void FindContentChildren4()
        {
            //Arrange
            int[] g = new int[] { 1, 2, 3 };
            int[] s = new int[] { 3 };

            int expected = 1;

            //Act
            Solution455 so = new Solution455();
            int actual = so.FindContentChildren(g, s);

            //Assert
            Assert.Equal(expected, actual);

        }


    }
}
