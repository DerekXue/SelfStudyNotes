using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//data structure used : HashSet
namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            string para = "qrsvbspk";
            int ans = lengthOfLongestSubstring(para);
            Console.Write(ans);
            Console.ReadKey();
        }

        public static int lengthOfLongestSubstring(string s)
        {
            HashSet<char> check = new HashSet<char>();
            List<int> count = new List<int>();
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (check.Contains(s[i]))
                {
                    count.Add(check.Count());
                    while (check.Contains(s[i]))
                    {
                        check.Remove(s[j++]);
                    }
                    check.Add(s[i]);
                }
                else
                {
                    check.Add(s[i]);
                }
            }
            count.Add(check.Count());
            return count.Max();
        }

        public static int LengthOfLongestSubstring(string s)
        {

            int longest = 0;
            int i = 0, j = 0;
            HashSet<char> pool = new HashSet<char>();

            while (j < s.Length)
            {

                if (!pool.Contains(s[j]))
                {
                    pool.Add(s[j++]);
                    longest = Math.Max(longest, pool.Count);
                }
                else
                {

                    while (pool.Contains(s[j]))
                    {
                        pool.Remove(s[i++]);
                    }
                }
            }

            return longest;

        }
    }
}
