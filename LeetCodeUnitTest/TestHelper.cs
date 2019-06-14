using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeUnitTest
{
    /// <summary>
    /// 测试辅助工具
    /// </summary>
    public static class TestHelper
    {
        /// <summary>
        /// 获取ListNode所有值，方便得到测试结果
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static List<int> GetListNodeValueList(ListNode node)
        {
            List<int> listValue = new List<int>();
            while (node != null)
            {
                listValue.Add(node.val);
                node = node.next;
            }

            return listValue;
        }

        /// <summary>
        /// 创建测试列表
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static ListNode CreateListNode(List<int> list)
        {
            if (list.Count == 0)
            {
                return null;
            }

            ListNode head = new ListNode(list[0]);
            ListNode node = head;
            for (int i = 1; i < list.Count; i++)
            {
                ListNode next = new ListNode(list[i]);
                node.next = next;
                node = next;
            }

            return head;
        }


    }
}
