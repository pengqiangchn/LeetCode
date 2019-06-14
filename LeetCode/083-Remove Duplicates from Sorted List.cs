using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution083
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
                return null;
            //看了一些答案，这里其实不需要俩个指针，直接 next. next 也行
            ListNode first = head;
            ListNode next = first.next;

            while (next != null)
            {
                if (next.val == first.val)
                {
                    //如果当前的值与下一个相等
                    //则当前值的下一个节点 往后挪一位，并将下一个节点也挪到后一位再次比较
                    first.next = next.next;
                    next = first.next;
                }
                else
                {
                    //如果不相等，则坐标都往后移一位
                    first = next;
                    next = first.next;
                }
            }

            return head;
        }

    }
}
