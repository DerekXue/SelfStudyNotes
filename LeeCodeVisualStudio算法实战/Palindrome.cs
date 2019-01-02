using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

https://leetcode.com/problems/palindrome-number/description/
namespace ConsoleApp3
{
    class Program
    {
        public static void checkPalindrome(int x)
        {
            if(x<0)
            {
                Console.Write("false");
            }
            else
            {
                int rev = 0;
                int origin = x;
                while (x != 0)
                { 
                int pop = x % 10;
                rev = rev * 10 + pop;
                x /= 10;
                }
                if(rev==origin)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }

        }

        static void Main(string[] args)
        {
            checkPalindrome(324123);
            Console.ReadLine();
        }
    }
}
