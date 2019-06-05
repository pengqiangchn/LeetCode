using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = -123;
            string s = i.ToString();
            char[] c = s.ToCharArray();
            Array.Reverse(c);

            Console.WriteLine(c);



            Console.ReadKey();

        }
    }
}