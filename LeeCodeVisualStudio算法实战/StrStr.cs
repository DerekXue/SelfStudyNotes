using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            string haystack= "xuehaige";
            string needle = "zai";
            int ans=StrStr(haystack, needle);
            Console.Write(ans);
            Console.ReadKey();
        }

        public static int StrStr(string haystack, string needle)
        {
            if (needle == "")
            {
                return 0;
            }
            else
            {
                int haystackLength = haystack.Length;
                for (int q = 0; q < haystack.Length; q += 1)
                {
                    bool flag = true;
                    for (int i = 0; i < needle.Length; i++)
                    {
                        int j = q+i;
                        if (j >= haystackLength) return -1;
                        else if (haystack[j] != needle[i]) flag = false;
                    }
                    if (flag)
                    {
                        return q;
                    }
                }
                return -1;
            }
            

            


        }
    }
}
