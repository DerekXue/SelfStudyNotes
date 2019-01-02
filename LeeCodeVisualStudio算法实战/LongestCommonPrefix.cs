using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//https://leetcode.com/problems/longest-common-prefix/description/
namespace ConsoleApp4
{
    class Program
    {
        public static string longestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return "";
            string prefix = strs[0];//use the strs[0] as mark
            for(int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                //keep slice the mark back to front until it match any part of strs[i]
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (string.IsNullOrEmpty(prefix)) return "";//if at end don't match return ""
                }
            }
            return prefix;
        }
        static void Main(string[] args)
        {
            string[] para = { "dog", "doom", "dogh" };
            string answer=longestCommonPrefix(para);
            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}
