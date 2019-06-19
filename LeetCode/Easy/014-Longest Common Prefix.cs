using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution014
    {
        public string LongestCommonPrefix(string[] strs)
        {
            string common = "";

            if (strs.Length > 0)
            {
                //默认第一个全部字母为公共前缀
                common = strs[0];
                for (int i = 1; i < strs.Length; i++)
                {
                    common = getCommonStr(common, strs[i]);
                }
            }

            return common;
        }

        //获取公共前缀
        private string getCommonStr(string common, string value)
        {
            string ret = "";

            for (int i = 0; i < common.Length; i++)
            {
                if (value.Length < i + 1)
                {
                    break;
                }

                if (common[i] == value[i])
                {
                    ret = ret + common[i];
                }
                else
                {
                    break;
                }
            }

            return ret;
        }


    }


}
