using System;
using System.Linq;

namespace ConsoleApp47
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] para = new int[] { -2, 1 };
            int answ=MaxSubArray(para);
            Console.WriteLine(answ);
            Console.ReadKey();
        }

        public static int MaxSubArray(int[] nums)
        {
            int ans = 0;
            int length = nums.Length;
            int[] checkPoint = new int[length] ;

            for(int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    checkPoint[i] = nums[i];
                    
                }
                else if(checkPoint[i-1]>0)
                {
                    checkPoint[i] = checkPoint[i - 1] + nums[i];
                }
                else
                {
                    checkPoint[i] = nums[i];
                }
            }

            ans = checkPoint.Max();

            return ans;
        }
    }
}
