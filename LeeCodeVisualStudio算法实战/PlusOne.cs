using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp49
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] para = { 1, 2, 3, 9};
            int[] answ =PlusOne(para);
            foreach(int i in answ)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }

        public static int[] PlusOne(int[] digits)
        {
            int lastDigit = digits[digits.Length - 1];
            int newLast = lastDigit + 1;
            if (newLast == 10)
            {
                int finalScore = 0;
                for (int i = 0; i < digits.Length; i++)
                {
                    finalScore += digits[i] * Convert.ToInt32(Math.Pow(10, digits.Length - i - 1));
                }
                int final = finalScore + 1;

                Stack<int> stack = new Stack<int>();
                while (final > 0)
                {
                    int digit = final % 10;
                    stack.Push(digit);
                    final =final/ 10;
                }
                int[] result=stack.ToArray();
                
                return result;
            }
            else
            {
                digits[digits.Length - 1] += 1;
                return digits;
            }

        }
    }
}
