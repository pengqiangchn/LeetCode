using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution1160_2
    {
        public int CountCharacters(string[] words, string chars)
        {
            //字符
            Dictionary<char, int> dicChar = new Dictionary<char, int>();

            Dictionary<int, List<string>> dicStrList = new Dictionary<int, List<string>>();

            HashSet<int> hash = new HashSet<int>();

            int count = 0;
            int remain = chars.Length;
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

            //贪心 排序最大字符串
            foreach (var word in words)
            {
                hash.Add(word.Length);
                if (dicStrList.ContainsKey(word.Length))
                {
                    dicStrList[word.Length].Add(word);
                }
                else
                {
                    dicStrList[word.Length] = new List<string>() { word };
                }
            }
            List<int> list = new List<int>(hash);
            list.Sort();
            list.Reverse();

            //开始比较
            foreach (var i in list)
            {
                if (remain < i)
                {
                    break;
                }

                //获取最大的字符串比较
                List<string> slist = dicStrList[i];

                foreach (var str in slist)
                {
                    bool success = true;
                    //检查是否存在，逐个去减数字，如果失败了 后面将数字都加回来。。
                    int j = 0;
                    for (; j < str.Length; j++)
                    {
                        if (dicChar.ContainsKey(str[j]) && dicChar[str[j]] > 0)
                        {
                            dicChar[str[j]]--;
                        }
                        else
                        {
                            success = false;
                            break;
                        }
                    }

                    //如果不存在，则重新加回来。。
                    if (!success)
                    {
                        for (int k = 0; k < j; k++)
                        {
                            dicChar[str[k]]++;
                        }
                    }
                    else
                    {
                        count += str.Length;
                        remain -= str.Length;
                    }
                }
            }

            return count;
        }
    }
}
