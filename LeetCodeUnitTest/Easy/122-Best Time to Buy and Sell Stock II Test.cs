using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution122Test
    {
        [Fact]
        public void MaxProfit1()
        {
            //Arrange 
            int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };
            int expected = 7;

            //Act
            Solution122 s = new Solution122();
            int actual = s.MaxProfit(prices);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MaxProfit2()
        {
            //Arrange 
            int[] prices = new int[] { 1, 2, 3, 4, 5 };
            int expected = 4;

            //Act
            Solution122 s = new Solution122();
            int actual = s.MaxProfit(prices);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MaxProfit3()
        {
            //Arrange 
            int[] prices = new int[] { 7, 6, 4, 3, 1 };
            int expected = 0;

            //Act
            Solution122 s = new Solution122();
            int actual = s.MaxProfit(prices);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
