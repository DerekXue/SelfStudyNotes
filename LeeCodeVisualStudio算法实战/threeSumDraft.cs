using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] para = { 1, 2, -3,5,-6 };
            threeSum(para);
        }

        public static IList<IList<int>> threeSum(int[] nums)
        {
            Dictionary<int,int> keys = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++)
            {
                keys.Add(i, nums[i]);
            }
            IList<IList<int>> answ = new List<IList<int>>();
            List<int> added = new List<int>();
            for(int j=0;j<nums.Length;j++)
            {
                for(int q = j+1; q < nums.Length; q++)
                {
                    int oppo = -1 * (nums[j] + nums[q]);
                    int currentKey = keys.FirstOrDefault(x=>x.Value==oppo).Key;
                    if (keys.ContainsValue(oppo)&&currentKey!=j&&currentKey!=q&&(!added.Contains(nums[j])||!added.Contains(nums[q])))
                    {
                        List < int > theAns= new List<int>(new int[]{  nums[j], nums[q], -1*(nums[j] + nums[q]) });
                        answ.Add(theAns);
                        added.Add(nums[j]);
                        added.Add(nums[q]);
                        added.Add(-1 * (nums[j] + nums[q]));
                    }
                }
            }
            return answ;
        }
    }
}
