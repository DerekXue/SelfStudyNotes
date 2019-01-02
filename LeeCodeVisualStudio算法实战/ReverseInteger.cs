using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//https://leetcode.com/problems/reverse-integer/description/
namespace ConsoleApp2
{
    class Program
    {
        public static void reverseNum(int x)
        {
            int revers = 0;
            while (x != 0)
            {
                int pop = x % 10;// -1234%10 equals -4
                x /= 10; //eg: 23/10 equals 2 but not 2.3
                if (revers > int.MaxValue / 10 || (revers == int.MaxValue / 10 && pop > 7))
                {
                    Console.WriteLine(0);
                }
                   
                if (revers < int.MinValue / 10 || (revers == int.MinValue / 10 && pop < -8)) 
                {
                    Console.WriteLine(0);
                }
                revers = revers * 10+pop;
            }

            Console.WriteLine(revers);
              
        }
        static void Main(string[] args)
        {
            reverseNum(-1234);
            Console.ReadLine();
        }
    }
}
