using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution083Test
    {
        [Fact]
        public void DeleteDuplicates1()
        {
            //Arrange
            ListNode node1 = new ListNode(1);

            ListNode node2 = new ListNode(1);
            node1.next = node2;

            ListNode node3 = new ListNode(2);
            node2.next = node3;

            List<int> expected = new List<int>() { 1, 2 };

            //Act
            Solution083 s = new Solution083();
            ListNode actualNode = s.DeleteDuplicates(node1);
            List<int> actual = TestHelper.GetListNodeValueList(actualNode);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DeleteDuplicates2()
        {
            //Arrange
            ListNode head = TestHelper.CreateListNode(new List<int> { 1, 1, 2, 3, 3 });

            List<int> expected = new List<int>() { 1, 2, 3 };

            //Act
            Solution083 s = new Solution083();
            ListNode actualNode = s.DeleteDuplicates(head);
            List<int> actual = TestHelper.GetListNodeValueList(actualNode);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DeleteDuplicates3()
        {
            //Arrange
            ListNode head = TestHelper.CreateListNode(new List<int> { });

            List<int> expected = new List<int>() { };

            //Act
            Solution083 s = new Solution083();
            ListNode actualNode = s.DeleteDuplicates(head);
            List<int> actual = TestHelper.GetListNodeValueList(actualNode);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DeleteDuplicates4()
        {
            //Arrange
            ListNode head = TestHelper.CreateListNode(new List<int> { 1, 1, 1, 1, 1, 1 });

            List<int> expected = new List<int>() { 1 };

            //Act
            Solution083 s = new Solution083();
            ListNode actualNode = s.DeleteDuplicates(head);
            List<int> actual = TestHelper.GetListNodeValueList(actualNode);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
