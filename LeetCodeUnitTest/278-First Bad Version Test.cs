using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution278Test
    {
        [Fact]
        public void FirstBadVersion()
        {
            //Arrange 
            int n = 2126753390;
            int expected = 1702766719;

            //Act 
            Solution278 s = new Solution278();
            int actual = s.FirstBadVersion(n);

            //Assert
            Assert.Equal(expected, actual);


        }
    }
}
