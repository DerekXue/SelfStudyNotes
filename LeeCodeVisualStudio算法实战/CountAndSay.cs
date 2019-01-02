using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            string ans = myCountAndSay(7);
            Console.Write(ans);
            Console.ReadKey();
        }

        public static string myCountAndSay(int n)
        {
            if (n < 1 || n > 30) return "";
            List<int> ans = new List<int> { };
            ans.Insert(0,1);
            for (int q = 0; q < n-1; q++)
            {
                for (int i = 0; i < ans.Count; i += 2)
                {
                    int counter = 0;
                    int j = i + 1;
                    while (j < ans.Count && ans[i] == ans[j])
                    {
                        j++;
                        counter++;
                    }
                    if (counter == 0) ans.Insert(i, 1);
                    else
                    {
                        ans[i] = counter + 1;
                        for(int r = i + 1; r < j-1; r++)
                        {
                            ans.RemoveAt(r);
                        }
                    }
                    //if (j < ans.Count && ans[i] == ans[j]) ans[i] = 2;
                    //else ans.Insert(i, 1);
                }
            }

            string str= string.Join(",", ans.ToArray()).Replace(",","");
            return str;
            //ans.Insert(0, n);
            //ans.Insert(0, "a");
            //1
            //11
            //21
            //1211
            //111221
            //312211
            //13112221
            //1113213211
            //31131211131221

            //3
            //13
            //1113
            //211113
            //12212113
            //112211122113

            //4
            //14
            //1114
            //211114
            //12212114
            //112211122114
        }

        public static string countAndSay(int n)
        {
            if (n == 1) return "1";
            if (n == 2) return "11";
            return say(countAndSay(n - 1));
        }
        private static string say(string s)
        {
            int i = 0, j = 0, cnt = 1;
            string ans = "";
            while (i < s.Length)
            {
                j = i + 1;
                if (j == s.Length)
                {
                    ans += cnt + s[i];
                    break;
                }
                if (s[i] == s[j])
                {
                    cnt++;
                    i++;
                }
                else
                {
                    ans += cnt + s[i];
                    cnt = 1;
                    i++;
                }
            }
            return ans;
        }
    }
    }

