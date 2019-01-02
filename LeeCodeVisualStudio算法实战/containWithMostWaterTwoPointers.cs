using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp32
{
    class containWithMostWater
    {
        static void Main(string[] args)
        {
            int[] para = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int answ = containWithMostWaterTwoPointers(para);
            Console.Write(answ);
            Console.ReadKey();
        }

        public static int containWithMostWaterTwoPointers(int[] para)
        {
            int i = 0;
            int j = para.Length - 1;
            List<int> result = new List<int>();
            while (i < j)
            {
                if(para[i]>para[j])
                {
                    result.Add(para[j] * (j - i));
                    j--;
                }
                else
                {
                    result.Add(para[i] * (j - i));
                    i++;
                }
                
            }
            int answ = result.Max();
            return answ;
        }
    }
}
