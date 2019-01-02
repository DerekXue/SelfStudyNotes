using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] nums1 = { 3 };
            int[] nums2 = { -1, -2 };
            double answer=findMedianSortedArrays(nums1, nums2);
        }

        public static double findMedianSortedArrays(int[] nums1,int[] nums2)
        {
            double answer = 0;
            List<int> nums1List = new List<int>(nums1);
            nums1List.AddRange(nums2);
            nums1List.Sort();
            nums1List.Distinct();

            if (nums1List.Count % 2 == 0)
            {
                double op1 = nums1List[nums1List.Count / 2-1];
                double op2= nums1List[nums1List.Count / 2];
                answer = (op1 + op2) / 2;
            }
            else
            {
                answer = nums1List[nums1List.Count / 2];
            }
            return answer;
        }
    }
}
