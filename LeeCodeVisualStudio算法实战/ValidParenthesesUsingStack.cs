using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//https://miafish.wordpress.com/2015/01/24/leetcode-oj-c-valid-parentheses/
namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            string arr = "(([]){})";
            bool ans = IsValid(arr);
            Console.WriteLine(ans);
            Console.ReadKey();

        }

        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach(char i in s)
            {
                switch (i)
                {
                    case '[':
                    case '(':
                    case '{':
                        stack.Push(i);
                        break;
                    case ']':
                        if (stack.Count == 0) return false;
                        char element = stack.Pop();
                        if (element == '[')
                            break;
                        return false;
                    case ')':
                        if (stack.Count == 0) return false;
                        char element2 = stack.Pop();
                        if (element2 == '(')
                            break;
                        return false;
                    case '}':
                        if (stack.Count == 0) return false;
                        char element3 = stack.Pop();
                        if (element3 == '{')
                            break;
                        return false;
                    default:
                        return false;
                }
            }
            return true;
        }

    }
}
