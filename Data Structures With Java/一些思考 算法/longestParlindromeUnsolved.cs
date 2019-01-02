using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            string para = "222020221";
            string answ=longestParlindrome(para);
            Console.Write(answ);
            Console.Read();

        }
        public static string longestParlindrome(string s)
        {
            bool found = false;
            int firstIndex = 0;
            int lastIndex = 0;
            List<string> parlindrome = new List<string>();

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i - 1, q = i + 1; j >= 0 && q < s.Length;)
                {
                    if (s[j] == s[q])
                    {
                        found = true;
                        firstIndex = j;
                        lastIndex = q;
                        j = j - 1;
                        q = q + 1;
                    }
                    else if (s[j] == s[i]&&found!=true)
                    {
                        found = true;
                        firstIndex = j;
                        lastIndex = i;
                        break;
                    }
                    else if (s[q] == s[i]&&found != true)
                    {
                        found = true;
                        firstIndex = i;
                        lastIndex = q;
                        break;
                    }
                    else
                    {
                        break;
                    }

                }
                if (found)
                {
                    parlindrome.Add(s.Substring(firstIndex, lastIndex - firstIndex + 1));
                    found = false;
                } 
            }

            if(s.SequenceEqual(s.Reverse()))
            {
                return s;
            }

            else if (parlindrome.Count!=0||s!="")
            {
                parlindrome.Add(s[0].ToString());
                return parlindrome.OrderByDescending(x => x.Length).First();
            }
            else
            {
                return "";
            }
        }
    }
}
