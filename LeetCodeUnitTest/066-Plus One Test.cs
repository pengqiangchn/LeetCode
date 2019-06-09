using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution066Test
    {
        [Fact]
        public void PlusOne1()
        {
            //Arrange
            int[] value = new int[] { 1, 2, 3 };
            int[] expencted = new int[] { 1, 2, 4 };

            //Act
            Solution066 s = new Solution066();
            int[] actual = s.PlusOne(value);

            //Assert
            Assert.Equal(expencted, actual);

        }

        [Fact]
        public void PlusOne2()
        {
            //Arrange
            int[] value = new int[] { 4, 3, 2, 1 };
            int[] expencted = new int[] { 4, 3, 2, 2 };

            //Act
            Solution066 s = new Solution066();
            int[] actual = s.PlusOne(value);

            //Assert
            Assert.Equal(expencted, actual);

        }

        [Fact]
        public void PlusOne3()
        {
            //Arrange
            int[] value = new int[] { 0, 2, 3, 9 };
            int[] expencted = new int[] { 0, 2, 4, 0 };

            //Act
            Solution066 s = new Solution066();
            int[] actual = s.PlusOne(value);

            //Assert
            Assert.Equal(expencted, actual);

        }

        [Fact]
        public void PlusOne4()
        {
            //Arrange
            int[] value = new int[] { 0 };
            int[] expencted = new int[] { 1 };

            //Act
            Solution066 s = new Solution066();
            int[] actual = s.PlusOne(value);

            //Assert
            Assert.Equal(expencted, actual);

        }


        [Fact]
        public void PlusOne5()
        {
            //Arrange
            int[] value = new int[] { 9, 9, 9, 9 };
            int[] expencted = new int[] { 1, 0, 0, 0, 0 };

            //Act
            Solution066 s = new Solution066();
            int[] actual = s.PlusOne(value);

            //Assert
            Assert.Equal(expencted, actual);

        }

    }
}
