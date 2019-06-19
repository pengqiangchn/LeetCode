using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution038Test
    {
        [Fact]
        public void CountAndSay1()
        {
            //Arrange 
            int n = 1;
            string expected = "1";

            //Act
            Solution038 s = new Solution038();
            string actual = s.CountAndSay(n);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CountAndSay4()
        {
            //Arrange 
            int n = 4;
            string expected = "1211";

            //Act
            Solution038 s = new Solution038();
            string actual = s.CountAndSay(n);

            //Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void CountAndSay6()
        {
            //Arrange 
            int n = 6;
            string expected = "312211";

            //Act
            Solution038 s = new Solution038();
            string actual = s.CountAndSay(n);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
