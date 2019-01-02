using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp51
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] nums = { -2, 0, 3, -5, 2, -1 };
            NumArray obj = new NumArray(nums);
            int param_1 = obj.SumRange(2, 5);
        }

        public class NumArray
        {
            private int[] myarr;

            public NumArray(int[] nums)
            {
                myarr = nums;
            }

            public int SumRange(int i, int j)
            {
                int sum = 0;
                for(int q = i; q <= j; q++)
                {
                    sum += myarr[q];
                }
                return sum;
            }
        }
    }
}
