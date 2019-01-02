using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            int ans = getIndexByValue(5);
            Console.Write(ans);
            Console.ReadKey();
        }

        public static int fibGetNumberByIndex(int index)
        {
            int value;
            if (index == 1)
            {
                value = 1;
                return value;
            }
            else if(index==2)
            {
                value = 2;
                return value;
            }
            else
            {
                value = fibGetNumberByIndex(index - 1) + fibGetNumberByIndex(index - 2);
                return value;
            } 
        }

        public static int getIndexByValue(int value)//直接加上去就好；
        {
            int oprand1 = 1;
            int oprand2 = 2;
            int index = 3;
            while (oprand1 + oprand2 < value)
            {
                index++;    //index代表加过的次数
                int sum = oprand1 + oprand2;
                oprand1 = oprand2;  //每次加了过后更新operand1和operand2的值
                oprand2 = sum;
            }
            if (oprand1 + oprand2 == value)
            {
                return index;
            }
            return -1;
        }
    }
}
