using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution067
    {
        public string AddBinary(string a, string b)
        {
            int count = 0;
            if (a.Length > b.Length)
            {
                count = a.Length;
            }
            else
            {
                count = b.Length;
            }

            string rtn = "";
            char temp = '0';

            int aIndex = a.Length - 1;
            int bIndex = b.Length - 1;
            for (int i = 0; i < count; i++)
            {
                if (aIndex < 0)
                {
                    int tc = temp + b[bIndex];
                    if (tc == 98)
                    {
                        rtn += '0';
                        temp = '1';
                    }
                    else if (tc == 97)
                    {
                        rtn += '1';
                        temp = '0';
                    }
                    else
                    {
                        rtn += '0';
                        temp = '0';
                    }
                    bIndex--;
                    continue;
                }


                if (bIndex < 0)
                {
                    int tc = temp + a[aIndex];
                    if (tc == 98)
                    {
                        rtn += '0';
                        temp = '1';
                    }
                    else if (tc == 97)
                    {
                        rtn += '1';
                        temp = '0';
                    }
                    else
                    {
                        rtn += '0';
                        temp = '0';
                    }
                    aIndex--;
                    continue;
                }

                int c = a[aIndex] + b[bIndex] + temp;
                if (c == 147)
                {
                    rtn += "1";
                    temp = '1';
                }
                else if (c == 146)
                {
                    rtn += "0";
                    temp = '1';
                }
                else if (c == 145)
                {
                    rtn += "1";
                    temp = '0';
                }
                else
                {
                    rtn += "0";
                    temp = '0';
                }

                aIndex--;
                bIndex--;
            }

            if (temp == '1')
            {
                rtn += "1";
            }

            char[] arr = rtn.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
