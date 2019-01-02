using System;

namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] para = { -1, 2, 1, -4 };
            int answer = threeSumClosest(para, 1);

        }

        public static int threeSumClosest(int[] nums, int target)
        {
            int answer=0;
            int gapRecord = int.MaxValue;

            Array.Sort(nums);

            for(int i = 0; i < nums.Length; i++)
            {
                int l = i+1;
                int r = nums.Length - 1;
                int gap;

                while (l < r)
                {
                    gap = Math.Abs(target - (nums[i] + nums[l] + nums[r]));
                    if (gap == 0)
                    {
                        return target;
                    }
                    else if(target< nums[i] + nums[l] + nums[r])
                    {
                        if (gapRecord > gap)
                        {
                            gapRecord = gap;
                            answer = nums[i] + nums[l] + nums[r];
                        }
                        r--;
                    }
                    else
                    {
                        if (gapRecord > gap)
                        {
                            gapRecord = gap;
                            answer = nums[i] + nums[l] + nums[r];
                        }
                        l++;
                    }
                }
            }
            return answer;
        }
    }
}
