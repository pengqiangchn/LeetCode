using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution119Test
    {
        [Fact]
        public void GetRow0()
        {
            //Arrange
            int rowIndex = 0;
            IList<int> expected = new List<int>() { 1 };

            //Act
            Solution119 s = new Solution119();
            IList<int> actual = s.GetRow(rowIndex);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void GetRow1()
        {
            //Arrange
            int rowIndex = 1;
            IList<int> expected = new List<int>() { 1, 1 };

            //Act
            Solution119 s = new Solution119();
            IList<int> actual = s.GetRow(rowIndex);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void GetRow2()
        {
            //Arrange
            int rowIndex = 2;
            IList<int> expected = new List<int>() { 1, 2, 1 };

            //Act
            Solution119 s = new Solution119();
            IList<int> actual = s.GetRow(rowIndex);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void GetRow3()
        {
            //Arrange
            int rowIndex = 3;
            IList<int> expected = new List<int>() { 1, 3, 3, 1 };

            //Act
            Solution119 s = new Solution119();
            IList<int> actual = s.GetRow(rowIndex);

            //Assert
            Assert.Equal(expected, actual);

        }


        [Fact]
        public void GetRow4()
        {
            //Arrange
            int rowIndex = 4;
            IList<int> expected = new List<int>() { 1, 4, 6, 4, 1 };

            //Act
            Solution119 s = new Solution119();
            IList<int> actual = s.GetRow(rowIndex);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
