using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution058Test
    {
        [Fact]
        public void LengthOfLastWord1()
        {
            //Arrange 
            string str = "Hello World";
            int expected = 5;

            //Act
            Solution058 s = new Solution058();
            int actual = s.LengthOfLastWord(str);


            //Assert 
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LengthOfLastWord2()
        {
            //Arrange 
            string str = "He llo Worl d";
            int expected = 1;

            //Act
            Solution058 s = new Solution058();
            int actual = s.LengthOfLastWord(str);


            //Assert 
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LengthOfLastWord3()
        {
            //Arrange 
            string str = " ";
            int expected = 0;

            //Act
            Solution058 s = new Solution058();
            int actual = s.LengthOfLastWord(str);


            //Assert 
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LengthOfLastWord4()
        {
            //Arrange 
            string str = "   ";
            int expected = 0;

            //Act
            Solution058 s = new Solution058();
            int actual = s.LengthOfLastWord(str);


            //Assert 
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LengthOfLastWord5()
        {
            //Arrange 
            string str = "a ";
            int expected = 1;

            //Act
            Solution058 s = new Solution058();
            int actual = s.LengthOfLastWord(str);


            //Assert 
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LengthOfLastWord6()
        {
            //Arrange 
            string str = "b a    ";
            int expected = 1;

            //Act
            Solution058 s = new Solution058();
            int actual = s.LengthOfLastWord(str);


            //Assert 
            Assert.Equal(expected, actual);
        }
    }
}
