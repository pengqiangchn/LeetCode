using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution1078
    {
        public string[] FindOcurrences(string text, string first, string second)
        {
            List<string> list = new List<string>();
            string[] arr = text.Split(" ");

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == first)
                {
                    if (i + 1 < arr.Length && arr[i + 1] == second)
                    {
                        if (i + 2 < arr.Length)
                        {
                            list.Add(arr[i + 2]);
                        }
                    }
                }
            }

            return list.ToArray();

        }
    }
}
