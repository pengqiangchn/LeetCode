using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution771
    {
        public int NumJewelsInStones(string J, string S)
        {
            int count = 0;

            for (int i = 0; i < J.Length; i++)
            {
                for (int j = 0; j < S.Length; j++)
                {
                    if (J[i] == S[j])
                    {
                        count++;
                    }
                }
            }


            return count;

        }
    }
}
