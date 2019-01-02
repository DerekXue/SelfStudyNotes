using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            string para = "au";
            int ans = lengthOfLongestSubstring(para);
            Console.Write(ans);
            Console.ReadKey();
        }

        public static int lengthOfLongestSubstring(string s)
        {
            Dictionary<int, char> checkRepeat = new Dictionary<int, char>();
            List<int> maxLength = new List<int>();
            int counter = 0;
            int leftOver = 0;
            bool flag = true;
            bool outterFlag = true;
            if (s == "") return 0;
            else
                while (outterFlag)
                {

                    for (int i = leftOver; i < s.Length && flag == true; i++)
                    {
                        if (checkRepeat.ContainsValue(s[i]))
                        {
                            flag = false;
                            leftOver = keyByValue(checkRepeat,s[i]);
                        }
                        else
                        {
                            checkRepeat.Add(i, s[i]);
                            counter++;
                        }
                        if (i == s.Length - 1)
                        {
                            leftOver = i;
                        }
                    }


                    maxLength.Add(counter);

                    counter = 0;
                    checkRepeat.Clear();
                    flag = true;
                    if (leftOver == s.Length - 1)
                    {
                        outterFlag = false;
                    }
                }
            return maxLength.Max();
        }

        public static int keyByValue(Dictionary<int, char> dict, char c)
        {
            int key = 0;
            foreach(KeyValuePair<int,char> pair in dict)
            {
                if(pair.Value==c)
                {
                    key = pair.Key;
                    break;
                }
            }
            return key+1;
        }
        //for how to get key by value in c# list:
        //https://stackoverflow.com/questions/2444033/get-dictionary-key-by-value
    }
}
