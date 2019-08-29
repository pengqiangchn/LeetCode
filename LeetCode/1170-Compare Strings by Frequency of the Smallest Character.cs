using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution1170
    {
        public int[] NumSmallerByFrequency(string[] queries, string[] words)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            Dictionary<string, int> dicCount = new Dictionary<string, int>();
            List<int> list = new List<int>();
            int[] array = new int[10];

            foreach (var word in words)
            {
                if (dic.ContainsKey(word))
                {
                    dicCount[word]++;
                }
                else
                {
                    dic[word] = GetMinCount(word);
                    dicCount[word] = 1;
                }
            }

            for (int i = 1; i < 10; i++)
            {
                int c = 0;
                foreach (var key in dic.Keys)
                {
                    if (i < dic[key])
                    {
                        c += dicCount[key];
                    }
                }
                array[i - 1] = c;
            }


            foreach (var str in queries)
            {
                int count = GetMinCount(str);
                list.Add(array[count - 1]);
            }

            return list.ToArray();
        }

        public int GetMinCount(string word)
        {
            //查找最小的次数
            char min = word[0];
            int count = 1;
            for (int i = 1; i < word.Length; i++)
            {
                if (word[i] < min)
                {
                    min = word[i];
                    count = 1;
                }
                else if (word[i] == min)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
