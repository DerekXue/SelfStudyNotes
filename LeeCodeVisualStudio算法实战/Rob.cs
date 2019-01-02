using System;

namespace ConsoleApp50
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = { 2, 7, 9, 3, 1 };
            Rob(arr);
        }

        public static int Rob(int[] nums)
        {
            int odd_sum = 0;
            int even_sum = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if (i % 2 == 0)
                {
                    odd_sum = Math.Max(even_sum, odd_sum + nums[i]);
                }
                else
                {
                    even_sum = Math.Max(odd_sum, even_sum + nums[i]);
                }
            }
            int result = Math.Max(odd_sum, even_sum);
            return result;
        }
    }
}
