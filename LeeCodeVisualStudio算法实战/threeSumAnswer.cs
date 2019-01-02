using System;
using System.Collections.Generic;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] para = {0,0,0 };
            IList<IList<int>> answs=ThreeSum(para);
        }

        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> answs = new List<IList<int>>();
            if (nums == null || nums.Length < 3) return answs;

            Array.Sort(nums);
            for(int i = 0; i < nums.Length; i++)
            {
                if (i != 0 && nums[i - 1] == nums[i]) continue;

                int l = i + 1;
                int r = nums.Length - 1;
                while(l<r)
                {
                    if (nums[i] + nums[l] + nums[r]==0)
                    {
                        int[] array = { nums[i], nums[l], nums[r] };
                        IList<int> answ = new List<int>(array);
                        answs.Add(answ);
                        do
                        {
                            l++;
                        } while (l<r&&nums[l] == nums[l - 1]);
                        do
                        {
                            r--;
                        }
                        while (l<r&&nums[r] == nums[r + 1]);
                    }
                    else if(nums[i] + nums[l] + nums[r] < 0)
                    {
                        l++;
                    }
                    else
                    {
                        r--;
                    }
                }
            }
            

            return answs;
        }
    }
}
