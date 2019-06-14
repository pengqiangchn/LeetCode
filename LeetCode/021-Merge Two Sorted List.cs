using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution021
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
            {
                return null;
            }

            ListNode newNode = null;
            if (l1 == null)
            {
                newNode = l2;
            }
            else if (l2 == null)
            {
                newNode = l1;
            }
            else
            {
                newNode = compareValue(l1, l2);
            }


            return newNode;

        }

        private ListNode compareValue(ListNode l1, ListNode l2)
        {
            //如果其中一个节点为空了，则新节点的下个节点就是当前节点
            if (l1 == null)
            {
                return l2;
            }
            if (l2 == null)
            {
                return l1;
            }
            ListNode node = null;
            //进行比较
            if (l1.val <= l2.val)
            {
                node = new ListNode(l1.val);
                l1 = l1.next;
            }
            else
            {
                node = new ListNode(l2.val);
                l2 = l2.next;
            }

            var value = compareValue(l1, l2);
            node.next = value;
            return node;
        }

    }

    public class Solution021_2
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
            {
                return null;
            }

            //如果其中一个节点为空了，则新节点的下个节点就是当前节点
            if (l1 == null)
            {
                return l2;
            }
            if (l2 == null)
            {
                return l1;
            }
            ListNode node = null;
            //进行比较
            if (l1.val <= l2.val)
            {
                node = new ListNode(l1.val);
                l1 = l1.next;
            }
            else
            {
                node = new ListNode(l2.val);
                l2 = l2.next;
            }

            var value = MergeTwoLists(l1, l2);
            node.next = value;


            return node;

        }

    }
}
