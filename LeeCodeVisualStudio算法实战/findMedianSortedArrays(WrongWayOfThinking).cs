using System;

namespace ConsoleApp41
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2 };
            int[] nums2 = { 3,4 };
            double answ = findMedianSortedArrays(nums1, nums2);
        }

        public static double findMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double median1 = 0;
            double median2 = 0;

            if (nums1.Length == 0)
            {
                median1 = 0;
                median2 = getMedian2(nums2);
                return median2;
            }

            else if (nums2.Length == 0)
            {
                median2 = 0;
                median1 = getMedian1(nums1);
                return median1;
            }
            else
            {
                median1=getMedian1(nums1);
                median2=getMedian2(nums2);
                double answer = (median1 + median2) / 2;
                return answer;
            }
            
        }

        private static double getMedian1(int[] nums1)
        {
            double median1 = 0;
            if (nums1.Length % 2 == 0)
            {
                double op1 = nums1[nums1.Length / 2 - 1];
                double op2 = nums1[nums1.Length / 2];
                median1 = (op1 + op2) / 2;
                //median1 = (nums1[nums1.Length / 2 - 1] + nums1[nums1.Length / 2]) / 2;
            }
            else
            {
                median1 = nums1[nums1.Length / 2];
            }
            return median1;
        }

        private static double getMedian2(int[] nums2)
        {
            double median2 = 0;
            if (nums2.Length % 2 == 0)
            {
                double op1 = nums2[nums2.Length / 2 - 1];
                double op2 = nums2[nums2.Length / 2];
                median2 = (op1+op2) / 2;
            }
            else
            {
                median2 = nums2[nums2.Length / 2];
            }
            return median2;
        }
    }

    
}
