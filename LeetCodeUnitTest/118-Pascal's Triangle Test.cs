using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution118Test
    {
        [Fact]
        public void Generate1()
        {
            //Arrange 
            int numRows = 1;
            IList<IList<int>> expected = new List<IList<int>>()
            {
                new List<int>() { 1 }
            };

            //Act
            Solution118 s = new Solution118();
            IList<IList<int>> actual = s.Generate(numRows);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Generate2()
        {
            //Arrange 
            int numRows = 2;
            IList<IList<int>> expected = new List<IList<int>>()
            {
                new List<int>() { 1 },
                new List<int>() { 1, 1 }
            };

            //Act
            Solution118 s = new Solution118();
            IList<IList<int>> actual = s.Generate(numRows);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Generate3()
        {
            //Arrange 
            int numRows = 3;
            IList<IList<int>> expected = new List<IList<int>>()
            {
                new List<int>() { 1 },
                new List<int>() { 1, 1 },
                new List<int>() { 1, 2, 1 }
            };

            //Act
            Solution118 s = new Solution118();
            IList<IList<int>> actual = s.Generate(numRows);

            //Assert
            Assert.Equal(expected, actual);

        }


        [Fact]
        public void Generate4()
        {
            //Arrange 
            int numRows = 4;
            IList<IList<int>> expected = new List<IList<int>>()
            {
                new List<int>() { 1 },
                new List<int>() { 1, 1 },
                new List<int>() { 1, 2, 1 },
                new List<int>() { 1, 3, 3, 1 }
            };

            //Act
            Solution118 s = new Solution118();
            IList<IList<int>> actual = s.Generate(numRows);

            //Assert
            Assert.Equal(expected, actual);

        }


        [Fact]
        public void Generate5()
        {
            //Arrange 
            int numRows = 5;
            IList<IList<int>> expected = new List<IList<int>>()
            {
                new List<int>() { 1 },
                new List<int>() { 1, 1 },
                new List<int>() { 1, 2, 1 },
                new List<int>() { 1, 3, 3, 1 },
                new List<int>() { 1, 4, 6, 4, 1 }
            };

            //Act
            Solution118 s = new Solution118();
            IList<IList<int>> actual = s.Generate(numRows);

            //Assert
            Assert.Equal(expected, actual);

        }


        [Fact]
        public void Generate0()
        {
            //Arrange 
            int numRows = 0;
            IList<IList<int>> expected = new List<IList<int>>() { };

            //Act
            Solution118 s = new Solution118();
            IList<IList<int>> actual = s.Generate(numRows);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
