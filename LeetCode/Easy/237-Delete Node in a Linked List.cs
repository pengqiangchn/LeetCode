using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution237
    {
        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}
