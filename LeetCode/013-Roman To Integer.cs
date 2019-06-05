using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution013
    {
        public int RomanToInt(string s)
        {
            Dictionary<string, int> romanToIntDic = InitDic();
            List<string> specialList = new List<string> { "I", "X", "C" };

            int ret = 0;

            //循环每个字符，进行统计
            for (int i = 0; i < s.Length; i++)
            {
                string currentRmoan = s[i].ToString();
                //检查当前是否为特殊字符
                if (specialList.Contains(currentRmoan) && i < s.Length - 1)
                {
                    string secondRoman = s[i + 1].ToString();
                    if (CheckIsSpecialRoman(currentRmoan, secondRoman))
                    {
                        ret = ret + romanToIntDic[currentRmoan + secondRoman];
                        i++;
                        continue;
                    }
                }
                ret = ret + romanToIntDic[currentRmoan];
            }

            return ret;
        }

        /// <summary>
        /// 检查是否是特殊罗马字符
        /// </summary>
        /// <param name="roman"></param>
        /// <returns></returns>
        public bool CheckIsSpecialRoman(string current, string second)
        {
            bool ret = false;
            switch (current)
            {
                case "I":
                    if (second == "V" || second == "X")
                        ret = true;
                    break;

                case "X":
                    if (second == "L" || second == "C")
                        ret = true;
                    break;

                case "C":
                    if (second == "D" || second == "M")
                        ret = true;
                    break;
                default:
                    ret = false;
                    break;
            }
            return ret;
        }

        /// <summary>
        /// 初始化数字与罗马字母的对应
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, int> InitDic()
        {
            Dictionary<string, int> romanToIntDic = new Dictionary<string, int>();
            romanToIntDic.Add("I", 1);
            romanToIntDic.Add("IV", 4);
            romanToIntDic.Add("V", 5);
            romanToIntDic.Add("IX", 9);
            romanToIntDic.Add("X", 10);
            romanToIntDic.Add("XL", 40);
            romanToIntDic.Add("L", 50);
            romanToIntDic.Add("XC", 90);
            romanToIntDic.Add("C", 100);
            romanToIntDic.Add("CD", 400);
            romanToIntDic.Add("D", 500);
            romanToIntDic.Add("CM", 900);
            romanToIntDic.Add("M", 1000);

            return romanToIntDic;
        }

    }
}
