using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution027Test
    {
        [Fact]
        public void RemoveElement()
        {
            //Arrange
            Solution027 s = new Solution027();

            int[] nums = new int[] { 3, 2, 2, 3 };
            int val = 3;

            int length = 2;
            int[] expected = new int[] { 2, 2 };

            //Act
            int actual = s.RemoveElement(nums, val);

            List<int> list = new List<int>();
            for (int i = 0; i < actual; i++)
            {
                list.Add(nums[i]);
            }
            int[] array = list.ToArray();

            //Assert
            Assert.Equal(length, actual);
            Assert.Equal(expected, array);

        }

        [Fact]
        public void RemoveElement2()
        {
            //Arrange
            Solution027 s = new Solution027();

            int[] nums = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            int val = 2;

            int length = 5;
            int[] expected = new int[] { 0, 1, 3, 0, 4 };

            //Act
            int actual = s.RemoveElement(nums, val);

            List<int> list = new List<int>();
            for (int i = 0; i < actual; i++)
            {
                list.Add(nums[i]);
            }
            int[] array = list.ToArray();

            //Assert
            Assert.Equal(length, actual);
            Assert.Equal(expected, array);

        }

        [Fact]
        public void RemoveElement3()
        {
            //Arrange
            Solution027 s = new Solution027();

            int[] nums = new int[] {  };
            int val = 123;

            int length = 0;
            int[] expected = new int[] {  };

            //Act
            int actual = s.RemoveElement(nums, val);

            List<int> list = new List<int>();
            for (int i = 0; i < actual; i++)
            {
                list.Add(nums[i]);
            }
            int[] array = list.ToArray();

            //Assert
            Assert.Equal(length, actual);
            Assert.Equal(expected, array);

        }

    }
}
