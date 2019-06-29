using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution203
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            //先判断头
            while (head != null && head.val == val)
            {
                head = head.next;
            }

            if (head == null)
            {
                return null;
            }

            ListNode node = head;
            //再判断尾部
            while (node != null)
            {
                //尾部会出现重复多次都是想同的，循环判断
                while (node.next != null && node.next.val == val)
                {
                    node.next = node.next.next;
                }

                //去掉值后，往后挪，然后再判断
                node = node.next;
            }

            return head;
        }
    }
}
