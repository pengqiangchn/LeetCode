using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _299_Bulls_and_Cows
    {
        public string GetHint(string secret, string guess)
        {
            int bulls = 0, cows = 0;
            List<char> sc = new List<char>();
            List<char> gc = new List<char>();


            for (int i = 0; i < secret.Length; i++)
            {
                if (secret[i] == guess[i])
                {
                    bulls += 1;
                }
                else
                {
                    sc.Add(secret[i]);
                    gc.Add(guess[i]);
                }
            }

            for (int i = 0; i < sc.Count; i++)
            {
                int index = gc.IndexOf(sc[i]);
                if (index > -1)
                {
                    cows += 1;
                    gc[index] = ' ';
                }
            }


            return $"{bulls}A{cows}B";
        }
    }
}
