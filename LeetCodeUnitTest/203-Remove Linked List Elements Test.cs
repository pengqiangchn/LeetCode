using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution023Test
    {
        [Fact]
        public void RemoveElements1()
        {
            //Arrange
            ListNode head = TestHelper.CreateListNode(new List<int> { 1, 2, 6, 3, 4, 5, 6 });
            int val = 6;
            List<int> expected = new List<int> { 1, 2, 3, 4, 5 };

            //Act
            Solution203 s = new Solution203();
            List<int> actual = TestHelper.GetListNodeValueList(s.RemoveElements(head, val));

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RemoveElements2()
        {
            //Arrange
            ListNode head = TestHelper.CreateListNode(new List<int> { 1, 1, 1, 1 });
            int val = 1;
            List<int> expected = new List<int> { };

            //Act
            Solution203 s = new Solution203();
            List<int> actual = TestHelper.GetListNodeValueList(s.RemoveElements(head, val));

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RemoveElements3()
        {
            //Arrange
            ListNode head = TestHelper.CreateListNode(new List<int> { 1, 2, 6, 3, 4, 5, 6 });
            int val = 2;
            List<int> expected = new List<int> { 1, 6, 3, 4, 5, 6 };

            //Act
            Solution203 s = new Solution203();
            List<int> actual = TestHelper.GetListNodeValueList(s.RemoveElements(head, val));

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RemoveElements4()
        {
            //Arrange
            ListNode head = TestHelper.CreateListNode(new List<int> { });
            int val = 6;
            List<int> expected = new List<int> { };

            //Act
            Solution203 s = new Solution203();
            List<int> actual = TestHelper.GetListNodeValueList(s.RemoveElements(head, 6));

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
