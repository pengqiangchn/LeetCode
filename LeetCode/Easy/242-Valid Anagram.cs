using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution242
    {
        //速度不快， 使用双数组，保存各自的数量，然后再数组比较个数，比较快，只运行了 3个n次；
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            char[] cs = s.ToCharArray();
            char[] ct = t.ToCharArray();
            Array.Sort(cs);
            Array.Sort(ct);

            for (int i = 0; i < cs.Length; i++)
            {
                if (cs[i] != ct[i])
                    return false;
            }

            return true;

        }
    }
}
