using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution021Test
    {
        [Fact]
        public void MergeTwoSortedList()
        {
            //Arrange
            Solution021_2 s021 = new Solution021_2();
            ListNode l1 = new ListNode(1);
            ListNode l1ex2 = new ListNode(2);
            l1.next = l1ex2;
            ListNode l1ex3 = new ListNode(4);
            l1ex2.next = l1ex3;

            ListNode l2 = new ListNode(1);
            ListNode l2ex2 = new ListNode(3);
            l2.next = l2ex2;
            ListNode l2ex3 = new ListNode(4);
            l2ex2.next = l1ex3;

            ListNode expected = new ListNode(1);
            ListNode expectedex2 = new ListNode(1);
            expected.next = expectedex2;
            ListNode expectedex3 = new ListNode(2);
            expectedex2.next = expectedex3;
            ListNode expectedex4 = new ListNode(3);
            expectedex3.next = expectedex4;
            ListNode expectedex5 = new ListNode(4);
            expectedex4.next = expectedex5;
            ListNode expectedex6 = new ListNode(4);
            expectedex5.next = expectedex6;

            //Act
            ListNode actual = s021.MergeTwoLists(l1, l2);

            //Assert
            Assert.Equal(expected, expected);


        }

    }
}
