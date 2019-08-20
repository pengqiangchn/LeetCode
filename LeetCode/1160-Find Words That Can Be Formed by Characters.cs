using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution1160
    {
        public int CountCharacters(string[] words, string chars)
        {
            //字符
            Dictionary<char, int> dicChar = new Dictionary<char, int>();

            int count = 0;
            //计算字符个数；
            foreach (var c in chars)
            {
                if (dicChar.ContainsKey(c))
                {
                    dicChar[c]++;
                }
                else
                {
                    dicChar[c] = 1;
                }
            }

            foreach (var word in words)
            {
                Dictionary<char, int> dic = new Dictionary<char, int>(dicChar);

                bool success = true;
                foreach (var c in word)
                {
                    if (dic.ContainsKey(c) && dic[c] > 0)
                    {
                        dic[c]--;
                    }
                    else
                    {
                        success = false;
                        break;
                    }
                }

                if (success)
                {
                    count += word.Length;
                }

            }


            return count;
        }
    }
}
