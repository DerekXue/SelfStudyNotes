using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//for more on dynamic programing : https://www.youtube.com/watch?v=Fi5INvcmDos
namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            longestParlindrome("");
            Console.ReadKey();
        }

        public static string longestParlindrome(string s)
        {
            bool[,] twoDimensionArray = new bool[s.Length,s.Length];//use dynamic programming method

            if (s == "") return "";

            //for (int i = 0, j = 0; i < s.Length&&j < s.Length;i++,j++)
            //{
            //    twoDimensionArray[i, j]= true;
            //}

            for (int i=0;i<s.Length;i++)
            {
                for(int j=0;j<s.Length;j++)
                {
                    if(i==j)
                    {
                        twoDimensionArray[i, j] = true;
                    }
                    else if(i>j)
                    {
                        twoDimensionArray[i, j] = false;
                    }
                    else if (j == i + 1 && s[i] == s[j])
                    {
                        twoDimensionArray[i, j] = true;
                    }

                }
            }

            for (int k = 2; k < s.Length; k++) //k这里控制长度在2以上后的检查顺寻，见图
            {
                for (int i = 0; i + k < s.Length; i++)
                {
                        int j = i + k;
                        if (s[i] == s[j] && twoDimensionArray[i + 1, j - 1])
                        {
                            twoDimensionArray[i, j] = true;
                        }
                    }
                }
            

            List<int> length = new List<int>();
            List<int> index = new List<int>();

            for(int i = 0; i < s.Length; i++)
            {
                for(int j=0;j<s.Length;j++)
                {
                    if(twoDimensionArray[i,j]==true)
                    {
                        length.Add(j - i+1);
                        index.Add(i);
                    }
                }
            }

            int maxLength = length.Max<int>();
            int ansIndex = length.FindIndex(a => a.Equals(maxLength));
            int startIndex = index[ansIndex];

            string answer = s.Substring(startIndex, maxLength);
            return answer;
        }
    }
}
