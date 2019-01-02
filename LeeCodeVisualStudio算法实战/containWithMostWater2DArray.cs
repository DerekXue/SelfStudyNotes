using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] para = { 2, 3, 4, 5, 18, 17, 6 };
            int[,] answ = maxArea(para);
            int rowl = answ.GetLength(0);
            int coll = answ.GetLength(1);
            for (int i = 0; i < rowl; i++)
            {
                for (int j = 0; j < coll; j++)
                {
                    Console.Write(answ[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public static int[,] maxArea(int[] height)
        {
            int [,] twoDarr = new int[height.Length,height.Length];
            for(int i = 0; i <height.Length; i++)
            {
                for(int j=i;j<height.Length;j++)
                {
                    if (i == j)
                    {
                        twoDarr[i, j] = 0;
                    }
                    else if (height[i]<=height[j])
                    {
                        twoDarr[i, j] = Math.Abs(height[i] * (j - i));
                    }
                    else
                    {
                        twoDarr[i, j] = Math.Abs(height[j] * (j - i));
                    }
                }
            }
            int max = twoDarr.Cast<int>().Max();
            return twoDarr;
        }
    }
}
