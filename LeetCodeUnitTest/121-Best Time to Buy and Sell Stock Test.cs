using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution121Test
    {
        [Fact]
        public void MaxProfit1()
        {
            //Arrange 
            int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };
            int expected = 5;

            //Act
            Solution121 s = new Solution121();
            int actual = s.MaxProfit(prices);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void MaxProfit2()
        {
            //Arrange 
            int[] prices = new int[] { 7, 6, 4, 3, 1 };
            int expected = 0;

            //Act
            Solution121 s = new Solution121();
            int actual = s.MaxProfit(prices);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void MaxProfit3()
        {
            //Arrange 
            int[] prices = new int[] { };
            int expected = 0;

            //Act
            Solution121 s = new Solution121();
            int actual = s.MaxProfit(prices);

            //Assert
            Assert.Equal(expected, actual);

        }


        [Fact]
        public void MaxProfit4()
        {
            //Arrange 
            int[] prices = new int[] { 1, 2, 3, 1, 2, 3, 6, 5, 3, 2, 0, 8, 3, 1, 2, 3 };
            int expected = 8;

            //Act
            Solution121 s = new Solution121();
            int actual = s.MaxProfit(prices);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void MaxProfit6()
        {
            //Arrange 
            int[] prices = new int[] { -2, 2, 5, 20, 11, 0, 22, 0, 0, 0, 0 };
            int expected = 24;

            //Act
            Solution121 s = new Solution121();
            int actual = s.MaxProfit(prices);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
