using System;
using System.Collections.Generic;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] para = { 0,0,0,0 };
            IList<IList<int>> answers = new List<IList<int>>();
            answers=fourSum(para, 0);
        }

        public static IList<IList<int>> fourSum(int[] nums, int target)
        {
            IList<IList<int>> answers = new List<IList<int>>();

            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                if (i != 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                int thirdPointer = i + 1;

                while (thirdPointer < nums.Length - 2)
                {
                    int l = thirdPointer + 1;
                    int r = nums.Length - 1;
                    while (l < r)
                    {
                        if (nums[i] + nums[thirdPointer] + nums[l] + nums[r] == target)
                        {
                            List<int> answer = new List<int> { nums[i], nums[thirdPointer], nums[l], nums[r] };
                            answers.Add(answer);
                            do
                            {
                                l++;
                            } while (nums[l] == nums[l - 1] && l < r);
                            do
                            {
                                r--;
                            } while (nums[r] == nums[r + 1] && l < r);
                        }
                        else if (nums[i] + nums[thirdPointer] + nums[l] + nums[r] > target)
                        {
                            r--;
                        }
                        else
                        {
                            l++;
                        }
                    }
                    do
                    {
                        thirdPointer++;
                    } while (thirdPointer != i + 1 && nums[thirdPointer] == nums[thirdPointer - 1]&& thirdPointer < nums.Length - 2);
                }
                
            }
            return answers;
        }
    }

    
}
