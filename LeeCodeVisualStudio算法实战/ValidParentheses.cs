using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//https://leetcode.com/problems/valid-parentheses/description/
namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string para = "(([]){})";
            bool answer = validParentheses(para);
            Console.Write(answer);
            Console.ReadKey();
        }

        public static bool validParentheses(string para)
        {
            int i = 0;
            int j = para.Length - 1;
            bool flag = true;

            if (para.Length % 2 == 0)
            {

                for (int q = 0; q < para.Length - 1;)
                {
                    if ((para[q] == '(' && para[q + 1] == ')') || (para[q] == '[' && para[q + 1] == ']') || (para[q] == '{' && para[q + 1] == '}'))
                    {
                        q += 2;
                    }
                    else
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    return true;
                }

                else
                {
                    while (i <= j)
                    {
                        if ((para[i] == '{' && para[j] == '}') || (para[i] == '(' && para[j] == ')') || (para[i] == '[' && para[j] == ']'))
                        {
                            i++;
                            j--;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    return true;

                }
            }
            else
            {
                return false;
            }
        }
    }
}
