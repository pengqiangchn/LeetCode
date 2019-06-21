using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    //这个题有问题，这里用的是list，当作偷懒使用了数据结构链表。
    //但是最快的 还是用自带的 stack 并且 有一个 minlist进行存储。跟我想的一样，只是刚刚用list实现报错了。
    public class Solution155
    {
        List<int> stack;
        int MIN = int.MaxValue;

        /** initialize your data structure here. */
        public Solution155()
        {
            stack = new List<int>();
        }

        public void Push(int x)
        {
            MIN = Math.Min(MIN, x);
            stack.Add(x);
        }

        public void Pop()
        {
            int x = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            if (MIN == x)
            {
                MIN = int.MaxValue;
                foreach (var item in stack)
                {
                    if (item < MIN)
                    {
                        MIN = item;
                    }
                }
            }
        }

        public int Top()
        {
            return stack[stack.Count - 1];
        }

        public int GetMin()
        {
            return MIN;
        }
    }
}
