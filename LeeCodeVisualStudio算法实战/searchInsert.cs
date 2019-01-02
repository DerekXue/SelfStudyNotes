using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1,2,4,5,7 };
            int value = -1;
            int ans = searchInsertBinary(arr, value);
            Console.Write(ans);
            Console.ReadKey();
        }

        public static int searchInsertBinary(int[] nums,int target)
        {
            int i = 0;
            int j = nums.Length - 1;

            if (target < nums[0]) return 0;
            if (target > nums[nums.Length - 1]) return nums.Length;

            while (i <= j)
            {
                int p = nums[(i + j) / 2];
                if (target == p) return (i + j) / 2;
                else if (target > p) i++;
                else if (target < p) j--;
            }
            return i;
        }


        public static int searchInsert(int[] nums, int target)
        {
            if (nums[0] > target) return 0;
            else
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] == target) return i;
                    else if (nums[i] < target && nums[i + 1] > target) return i + 1;
                }
            }
            if (nums[nums.Length - 1] == target) return nums.Length - 1;
            else return nums.Length;
        }
    }
}
