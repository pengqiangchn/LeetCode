using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution190Test
    {
        [Fact]
        public void reverseBits1()
        {
            //Arrange
            uint n = 43261596;
            uint expected = 964176192;

            //Act
            Solution190 s = new Solution190();
            uint actual = s.reverseBits(n);

            //Assert
            Assert.Equal(expected, actual);


        }

        [Fact]
        public void reverseBits2()
        {
            //Arrange
            uint n = 4294967293;
            uint expected = 3221225471;

            //Act
            Solution190 s = new Solution190();
            uint actual = s.reverseBits(n);

            //Assert
            Assert.Equal(expected, actual);


        }
    }
}
