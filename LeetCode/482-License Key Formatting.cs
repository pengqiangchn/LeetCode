using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution482
    {
        public string LicenseKeyFormatting(string S, int K)
        {
            List<char> listc = new List<char>();
            int count = 0;
            for (int i = S.Length - 1; i >= 0; i--)
            {
                if (S[i] != '-')
                {
                    if (S[i] >= 'a' && S[i] <= 'z')
                    {
                        listc.Add((char)(S[i] + 'A' - 'a'));
                    }
                    else
                    {
                        listc.Add(S[i]);
                    }

                    count++;

                    if (count == K)
                    {
                        listc.Add('-');
                        count = 0;
                    }
                }
            }

            if (listc.Count > 0 && listc[listc.Count - 1] == '-')
                listc.RemoveAt(listc.Count - 1);

            listc.Reverse();
            return new string(listc.ToArray());
        }
    }
}
